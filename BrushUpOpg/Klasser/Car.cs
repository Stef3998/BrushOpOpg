using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushUpOpg.Klasser
{
    class Car : Vehicle
    {
        public int Door { get; set; }
        public string Color { get; set; }
        public char Category { get; set; }
        public int StorageVolume { get; set; }

        public Car(string mark, string model, string regNo, Price price, AdditionalEquipment additionalEquipment, int door, string color, char category, int storageVolume) : base(mark, model, regNo, price, additionalEquipment)
        {
            Door = door;
            Color = color;
            Category = category;
            StorageVolume = storageVolume;
        }
    }
}
