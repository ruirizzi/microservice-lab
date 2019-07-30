using System;
using System.Collections.Generic;

namespace BankingWebAPI.Models
{
    public partial class Entry
    {
        public long Id { get; set; }
        public TransactionType Type { get; set; }
        public string TransactionId { get; set; }
        public long AccountId { get; set; }
        public long CounterPartId { get; set; }
        public decimal Amount { get; set; }
        public DateTime OccurenceDate { get; set; }
        public enum TransactionType
        {
            Debit = 0,
            Credit = 1
        }
        Entry() { }
        Entry(TransactionType _type, String _transId, Int64 _accountId, Int64 _counterPartId, DateTime _occDate, Decimal _amount)
        {
            Type = _type;
            TransactionId = _transId;
            AccountId = _accountId;
            CounterPartId = _counterPartId;
            OccurenceDate = _occDate;
            Amount = _amount;
        }
        public static Entry[] GetEntriesFromTransfer(ValueTransfer transfer)
        {

            Entry origEntry = new Entry(
                TransactionType.Debit,
                transfer.TransactionId,
                transfer.OriginAccount,
                transfer.DestinationAccount,
                transfer.OccurenceDate,
                transfer.TotalAmount * -1);

            Entry destEntry = new Entry(
                TransactionType.Credit,
                transfer.TransactionId,
                transfer.DestinationAccount,
                transfer.OriginAccount,
                transfer.OccurenceDate,
                transfer.TotalAmount);


            return new Entry[] { origEntry, destEntry };
        }
    }
}
