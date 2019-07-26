using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// Decorator Account.
    /// </summary>
    public abstract class DecoratorAccount : IBankAccount
    {
        protected IBankAccount BankAccount;

        public DecoratorAccount(IBankAccount decoratorAccount)
        {
            this.BankAccount = decoratorAccount;
        }

        public virtual void OpenAccount(Account a)
        {
            this.BankAccount.OpenAccount(a);
        }
    }
}
