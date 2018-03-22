using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class EquipmentUpgrade
    {
        public int EquipmentUpgradeId { get; set; }
        public string Name { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Weight { get; set; }
        public int? AvailabilityId { get; set; }
        public int? BookId { get; set; }
        public int? Page { get; set; }
        public bool? WeaponUpgrade { get; set; }
        public bool? ArmorUpgrade { get; set; }
        public int? UpgradeSlots { get; set; }
        public string Description { get; set; }

        public Availability Availability { get; set; }
        public Book Book { get; set; }
    }
}
