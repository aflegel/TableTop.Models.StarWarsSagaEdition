using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class Vehicle
    {
        public Vehicle()
        {
            VehicleSystemMap = new HashSet<VehicleSystemMap>();
        }

        public int VehicleId { get; set; }
        public int? VehicleTypeId { get; set; }
        public string Name { get; set; }
        public int? SizeId { get; set; }
        public decimal? Cost { get; set; }
        public int? AvailabilityId { get; set; }
        public int? HitPoints { get; set; }
        public int? ShieldRating { get; set; }
        public int? DamageReduction { get; set; }
        public int? CargoSpace { get; set; }
        public int? Crew { get; set; }
        public int? Passengers { get; set; }
        public bool? CarriedCraft { get; set; }
        public int? AdditionalEmplacements { get; set; }
        public int? BookId { get; set; }
        public int? Page { get; set; }
        public string Description { get; set; }

        public Availability Availability { get; set; }
        public Book Book { get; set; }
        public Size Size { get; set; }
        public VehicleType VehicleType { get; set; }
        public ICollection<VehicleSystemMap> VehicleSystemMap { get; set; }
    }
}
