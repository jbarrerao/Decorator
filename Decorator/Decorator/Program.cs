using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a = new Account(1, "MitoCode");

            IBankAccount account = new SavingAccount();
            IBankAccount armorAccount = new ArmorDecorator(account);

            armorAccount.OpenAccount(a);

            Console.ReadKey();
        }
    }
}
