using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// Implement
    /// </summary>
    public class CurrentAccount : IBankAccount
    {
        public void OpenAccount(Account a)
        {
            Console.WriteLine("Open current account");
            Console.WriteLine(string.Format("Client:{0}", a.GetClient()));
        }
    }
}
