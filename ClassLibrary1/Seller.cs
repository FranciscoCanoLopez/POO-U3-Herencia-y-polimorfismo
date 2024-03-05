using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Seller : People
    {
		private string typeofcontract;
		private double sallary;

		public string TypeOfContract
        {
			get { return typeofcontract; }
			set { typeofcontract = value; }
		}	

		public double Sallary
		{
			get { return sallary; }
			set { sallary = value; }
		}

		public void CalculateSallary(double basesalary)
		{
			if (this.TypeOfContract == "C")
			{ 
				this.Sallary = basesalary + 350 ;
			}
			else if (this.TypeOfContract == "N")
			{
				this.Sallary = basesalary + 750 ;
			}
			else
			{
				this.Sallary = 0 ;
			}
		}
	}
}
