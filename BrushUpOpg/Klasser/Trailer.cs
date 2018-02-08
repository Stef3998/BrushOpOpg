using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushUpOpg.Klasser
{
    class Trailer : Vehicle
    {
        public string Type { get; set; }
        public int LoadCapacity { get; set; }

        public Trailer(string mark, string model, string regNo, Price price, AdditionalEquipment additionalEquipment, string type, int loadCapacity) : base(mark, model, regNo, price, additionalEquipment)
        {
            Type = type;
            LoadCapacity = loadCapacity;
        }
    }
}
