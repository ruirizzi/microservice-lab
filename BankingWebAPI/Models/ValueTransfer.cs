using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BankingWebAPI.Models
{
    public class ValueTransfer
    {
        public ValueTransfer(Int64 _oriAcc, Int64 _destAcc, Decimal _amount)
        {
            OriginAccount = _oriAcc;
            DestinationAccount = _destAcc;
            TotalAmount = _amount;
            OccurenceDate = DateTime.Now;

            using (System.Security.Cryptography.MD5 md5Hash = System.Security.Cryptography.MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(OriginAccount.ToString() + DestinationAccount.ToString() + TotalAmount.ToString() + OccurenceDate.ToString()));
                StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }
                TransactionId = sBuilder.ToString();
            }
        }
        public Int64 OriginAccount { get; set; }
        public Int64 DestinationAccount { get; set; }
        public Decimal TotalAmount { get; set; }
        public String TransactionId { get; set; }
        public DateTime OccurenceDate { get; set; }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
