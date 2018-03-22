using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class WeaponAmmunition
    {
        public WeaponAmmunition()
        {
            WeaponAmmunitionMap = new HashSet<WeaponAmmunitionMap>();
        }

        public int WeaponAmmunitionId { get; set; }
        public string Name { get; set; }
        public decimal? Cost { get; set; }
        public int? AvailabilityId { get; set; }
        public decimal? Weight { get; set; }
        public int? BookId { get; set; }
        public int? Page { get; set; }
        public string Description { get; set; }

        public ICollection<WeaponAmmunitionMap> WeaponAmmunitionMap { get; set; }
    }
}
