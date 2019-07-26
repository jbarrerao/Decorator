using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class SavingAccount : IBankAccount
    {
        public void OpenAccount(Account a)
        {
            Console.WriteLine("Open saving account");
            Console.WriteLine(string.Format("Client:{0}", a.GetClient()));
        }
    }
}
