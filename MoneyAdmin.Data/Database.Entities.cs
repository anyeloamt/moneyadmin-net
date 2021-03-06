﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyAdmin.Data.Entities;

namespace MoneyAdmin.Data
{
    partial class Database
    {
        public DbSet<Wallet> Wallets { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<LoginHistory> LoginHistories { get; set; }

        public DbSet<File> Files { get; set; }

        public DbSet<ShareCode> ShareCodes { get; set; }
    }
}
