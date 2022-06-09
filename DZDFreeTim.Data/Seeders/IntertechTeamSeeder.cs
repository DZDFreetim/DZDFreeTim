using DZDFreeTim.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZDFreeTim.Data.Seeders
{
    public class IntertechTeamSeeder
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            var IntertechTeams = new List<IntertechTeam>()
            {
                new IntertechTeam() { 
                    IntertechTeamId=1,
                    TeamName="Power Rangers"
                },
                new IntertechTeam() {
                    IntertechTeamId=2,
                    TeamName="Squad"
                },
                new IntertechTeam() {
                    IntertechTeamId=3,
                    TeamName="Team3"
                },



            };
            modelBuilder.Entity<IntertechTeam>().HasData(IntertechTeams);



        }
    }
}