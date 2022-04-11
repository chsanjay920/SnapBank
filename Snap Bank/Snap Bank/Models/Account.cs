﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Snap_Bank.Models
{
    [Table("AccountTable")]
    public class AccountTable
    {
        [Key]
        public int UserId { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
        public Decimal AccountNumber { get; set; }
        public int Pin { get; set; }
        public Decimal SortCode { get; set; }
        public String AccountType { get; set; }
    }
}