using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushUpOpg.Klasser
{
    class Vehicle
    {
        #region Properties
        public string Mark { get; set; }
        public string Model { get; set; }
        public string RegNo { get; set; }
        public Price Price { get; set; }
        public AdditionalEquipment AdditionalEquipment { get; set; }
        #endregion

        #region Konstruktør
        public Vehicle(string mark, string model, string regNo, Price price, AdditionalEquipment additionalEquipment)
        {
            Mark = mark;
            Model = model;
            RegNo = regNo;
            Price = price;
            AdditionalEquipment = additionalEquipment;
        }
        #endregion

        List<Rent>vehiclerent=new List<Rent>();
        List<Price>vehicleprice=new List<Price>();
        List<AdditionalEquipment>vehicleequipment=new List<AdditionalEquipment>();
    }
}
