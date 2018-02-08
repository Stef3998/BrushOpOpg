using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushUpOpg.Klasser
{
    class VernerWinterFolkesVehicleRenting
    {
        public Vehicle Vehicle { get; set; }
        public Customer Customer { get; set; }

        public VernerWinterFolkesVehicleRenting(Vehicle vehicle, Customer customer)
        {
            Vehicle = vehicle;
            Customer = customer;
        }
    }
}
