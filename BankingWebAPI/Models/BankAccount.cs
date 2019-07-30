using System;
using System.Collections.Generic;

namespace BankingWebAPI.Models
{
    public partial class BankAccount
    {
        //public BankAccount()
        //{
        //    EntryAccount = new HashSet<Entry>();
        //    EntryCounterPart = new HashSet<Entry>();
        //}

        public long Id { get; set; }
        public string Holder { get; set; }
        public string HolderDocument { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public bool AllowsOverdraft { get; set; }
        public decimal UpdatedPosition { get; set; }
        public DateTime? CreationDate { get; set; }
        //public ICollection<Entry> EntryAccount { get; set; }
        //public ICollection<Entry> EntryCounterPart { get; set; }
    }
}
