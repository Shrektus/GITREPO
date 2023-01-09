﻿using Microsoft.EntityFrameworkCore;
using ProjektZaliczeniowyMVCV2.Models;
using System;


    public class QuestContext : DbContext
    {
        public DbSet<QuestModel> Quests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptions)
        {
            var cs = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Testingbich;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            dbContextOptions.UseSqlServer(cs);
        }
    }
