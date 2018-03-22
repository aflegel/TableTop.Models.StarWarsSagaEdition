using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class VehicleAmmunition
    {
        public VehicleAmmunition()
        {
            VehicleSystem = new HashSet<VehicleSystem>();
        }

        public int VehicleAmmunitionId { get; set; }
        public string Name { get; set; }
        public decimal? Cost { get; set; }
        public int? AvailabilityId { get; set; }
        public int? BookId { get; set; }
        public int? Page { get; set; }
        public string Description { get; set; }

        public Book Book { get; set; }
        public ICollection<VehicleSystem> VehicleSystem { get; set; }
    }
}
