using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class VehicleSystem
    {
        public VehicleSystem()
        {
            VehicleSystemMap = new HashSet<VehicleSystemMap>();
        }

        public int VehicleSystemId { get; set; }
        public string Name { get; set; }
        public decimal? Cost { get; set; }
        public int? AvailabilityId { get; set; }
        public int? EmplacementCost { get; set; }
        public int? BookId { get; set; }
        public int? Page { get; set; }
        public string Description { get; set; }
        public string Damage { get; set; }
        public int? VehicleAmmunitionId { get; set; }
        public int? VehicleWeaponRangeId { get; set; }
        public int? ShieldRating { get; set; }
        public int? MinimumSizeId { get; set; }
        public int? MaximumSizeId { get; set; }
        public int? MaximumCount { get; set; }

        public Availability Availability { get; set; }
        public Book Book { get; set; }
        public Size MaximumSize { get; set; }
        public Size MinimumSize { get; set; }
        public VehicleAmmunition VehicleAmmunition { get; set; }
        public VehicleWeaponRange VehicleWeaponRange { get; set; }
        public ICollection<VehicleSystemMap> VehicleSystemMap { get; set; }
    }
}
