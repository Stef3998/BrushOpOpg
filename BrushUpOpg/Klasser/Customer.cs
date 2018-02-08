using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BrushUpOpg.Klasser

{
    public class Customer
    {
        #region Properties
        public string Address { get; set; }
        public int Bonus { get; set; }
        public string CustomerNo { get; set; }
        public string Mobile { get; set; }
        public string Name { get; set; }
        #endregion

        #region Konstruktør
        public Customer(string address, int bonus, string customerNo, string mobile, string name)
        {
            Address = address;
            Bonus = bonus;
            CustomerNo = customerNo;
            Mobile = mobile;
            Name = name;
        }
        #endregion
        
        List<Rent>rents=new List<Rent>();
    }
}
