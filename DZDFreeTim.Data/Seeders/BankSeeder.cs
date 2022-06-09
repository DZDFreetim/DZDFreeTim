using DZDFreeTim.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZDFreeTim.Data.Seeders
{
    public class BankSeeder
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            var banks = new List<Bank>()
            {
                new Bank() {
                    BankId=1,
                    BankName="odeabank"
                },
                  new Bank() {
                    BankId=2,
                    BankName="denizbank"
                },
                    new Bank() {
                    BankId=3,
                    BankName="akbank"
                },



            };
            modelBuilder.Entity<Bank>().HasData(banks);



        }
    }
}
