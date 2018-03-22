using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class WeaponDamageMap
    {
        public int WeaponDamageId { get; set; }
        public int? WeaponId { get; set; }
        public int? DamageTypeId { get; set; }

        public WeaponDamageType DamageType { get; set; }
        public Weapon Weapon { get; set; }
    }
}
