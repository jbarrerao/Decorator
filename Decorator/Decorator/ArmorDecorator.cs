using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ArmorDecorator : DecoratorAccount
    {
        public ArmorDecorator(IBankAccount decoratorAccount) : base(decoratorAccount)
        {
        }

        public override void OpenAccount(Account a)
        {
            BankAccount.OpenAccount(a);
            AddArmorAccount(a);            
        }

        public void AddArmorAccount(Account a)
        {
            Console.WriteLine(string.Format("shield added to customer account {0}", a.GetClient()));            
        }
    }
}

