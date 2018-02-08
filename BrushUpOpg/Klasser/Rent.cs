using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushUpOpg.Klasser
{
    class Rent
    {
        #region Properties
        public string From { get; set; }
        public string To { get; set; }
        public Customer Customer { get; set; }
        public Vehicle Vehicle { get; set; }

        #endregion

        #region Konstruktør

        public Rent(string from, string to, Customer customer, Vehicle vehicle)
        {
            From = from;
            To = to;
            Customer = customer;
            Vehicle = vehicle;
        }
        #endregion
  
    }
}
