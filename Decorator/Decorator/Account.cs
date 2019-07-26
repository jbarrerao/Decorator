using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// base class.
    /// </summary>
    public class Account
    {
        private int Id;
        private string Client;

        public Account()
        {                
        }

        public Account(int id, string client)
        {
            this.Id = id;
            this.Client = client;
        }

        public int GetId()
        {
            return Id;
        }

        public void SetId(int id)
        {
            this.Id = id;
        }

        public string GetClient()
        {
            return Client;
        }

        public void SetClient(string client)
        {
            this.Client = client;
        }
    }
}
