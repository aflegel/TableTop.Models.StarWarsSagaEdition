using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class VehicleSystemMap
    {
        public int VehicleSystemMapId { get; set; }
        public int? VehicleId { get; set; }
        public int? VehicleSystemId { get; set; }
        public int? Count { get; set; }
        public string Description { get; set; }

        public Vehicle Vehicle { get; set; }
        public VehicleSystem VehicleSystem { get; set; }
    }
}
