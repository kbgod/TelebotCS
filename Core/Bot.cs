using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelebotCS.Core
{
    public class Bot
    {
        private string token;
        public Bot(string token)
        {
            this.token = token;
        }

        public void GetToken()
        {
            Console.WriteLine(this.token);
        }
    }
}
