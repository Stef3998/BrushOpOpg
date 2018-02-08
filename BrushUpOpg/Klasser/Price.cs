using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushUpOpg.Klasser
{
    class Price
    {
        #region Properties
        public DateTime Period { get; set; }
        public double RentPerDay { get; set; }
        public double RentPerWeek { get; set; }
        #endregion

        #region Konstruktør
        public Price(DateTime period, double rentPerDay, double rentPerWeek)
        {
            Period = period;
            RentPerDay = rentPerDay;
            RentPerWeek = rentPerWeek;
        }
        #endregion
        
    }
}
