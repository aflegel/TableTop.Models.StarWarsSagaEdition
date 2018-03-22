using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class WeaponDamageType
    {
        public WeaponDamageType()
        {
            WeaponDamageMap = new HashSet<WeaponDamageMap>();
        }

        public int DamageTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<WeaponDamageMap> WeaponDamageMap { get; set; }
    }
}
