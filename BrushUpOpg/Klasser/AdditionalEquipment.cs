using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Text;
using Windows.UI.Xaml;

namespace BrushUpOpg.Klasser
{
    class AdditionalEquipment
    {
        #region Properties
        public string Description { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public Price Price { get; set; }    
        #endregion

        #region Konstruktør

        public AdditionalEquipment(string description, string name, string type, Price price)
        {
            Description = description;
            Name = name;
            Type = type;
            Price = price;
        }
        #endregion
        List<Price>eqiupmentprice=new List<Price>();
    }
}
