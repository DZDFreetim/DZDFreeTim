using System;
using DataAccessLayer.Concrete;
using DZDFreeTim.Data.Entity;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZDFreeTim.Business.Concrete
{
    public class BankManager
    {
        Repository<Bank> repoBank = new Repository<Bank>();
        public string GetNameById(int id)
        {
            var bank = repoBank.GetById(id);
            if(bank == null)
            {
                return String.Empty;
            }
            return bank.BankName;
        }


    }
}
