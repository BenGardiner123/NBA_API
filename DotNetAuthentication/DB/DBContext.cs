﻿using DotNetAuthentication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetAuthentication.DB
{
    public class NBAContext : DbContext
    {

        //entities
        public DbSet<User> Users { get; set; }

        public DbSet<Player> allPlayers { get; set; }

        public DbSet<Team> Team { get; set; }

        public DbSet<PlayerSelection> PlayerSelection { get; set; }

        public NBAContext(DbContextOptions<NBAContext> options): base(options)
        {

        }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => new {
                u.UserId
            });

            modelBuilder.Entity<Player>().HasKey(p => new {
                p.Player_key
            });
            modelBuilder.Entity<Team>().HasKey(t => new
            {
                t.TeamName,
                t.UserID
          
            });

            modelBuilder.Entity<PlayerSelection>().HasKey(p => new
            {
                p.TeamName,
                p.UserID,
                p.Player_key
            });


        }

       

    }
}
