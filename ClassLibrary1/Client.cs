using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class Client : People
    {
        private string category;
        private string code;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public void generateCode()
        {
            this.Code = "C" + this.Surname.Substring(0, 3) + "05";
        }
    }
}
