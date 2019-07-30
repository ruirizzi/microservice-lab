using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BankingWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        BankContext _dbContext;

        public BankController(BankContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("It works!");
        }

        [HttpGet("GetEntriesByAccountId/{accountId}")]
        public IActionResult GetEntriesByAccountId(Int64 accountId)
        {
            var result = _dbContext.Entry.ToListAsync().Result.Where(x => x.AccountId == accountId).ToList();
            if (result.Count == 0) return NotFound($"No entry was found for account #{accountId}");
            return Ok(result);
        }

        [HttpPost]
        public IActionResult TransferValues([FromBody] ValueTransfer transfer)
        {
            if (!ModelState.IsValid) return BadRequest("Invalid data.");

            if (transfer.OriginAccount == transfer.DestinationAccount) return BadRequest("Origin and Destination accounts cannot be the same.");

            Entry originEntry = Entry.GetEntriesFromTransfer(transfer)[0];
            Entry destinationEntry = Entry.GetEntriesFromTransfer(transfer)[1];

            BankAccount originBankAccount = _dbContext.BankAccount.Find(transfer.OriginAccount);
            if (originBankAccount == null) return NotFound($"Account #{transfer.OriginAccount} does not exists.");

            BankAccount destinationBankAccount = _dbContext.BankAccount.Find(transfer.DestinationAccount);
            if (destinationBankAccount == null) return NotFound($"Account #{transfer.DestinationAccount} does not exists.");

            if (originBankAccount.UpdatedPosition - transfer.TotalAmount < 0 && !originBankAccount.AllowsOverdraft)
            {
                return BadRequest("The origin account does not allow overdraft.");
            }
            else
            {
                originBankAccount.UpdatedPosition = originBankAccount.UpdatedPosition - transfer.TotalAmount;
                destinationBankAccount.UpdatedPosition = destinationBankAccount.UpdatedPosition + transfer.TotalAmount;


                _dbContext.UpdateRange(originBankAccount, destinationBankAccount);

                _dbContext.AddRange(originEntry, destinationEntry);

                _dbContext.SaveChanges();

                return Ok();
            }

        }
    }
}
