using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class VehicleType
    {
        public VehicleType()
        {
            Vehicle = new HashSet<Vehicle>();
        }

        public int VehicleTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Vehicle> Vehicle { get; set; }
    }
}
