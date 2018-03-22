using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class WeaponAmmunitionMap
    {
        public int WeaponAmmunitionTypeId { get; set; }
        public int? WeaponId { get; set; }
        public int? WeaponAmmunitionId { get; set; }
        public int Capacity { get; set; }

        public Weapon Weapon { get; set; }
        public WeaponAmmunition WeaponAmmunition { get; set; }
    }
}
