using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class WeaponFireType
    {
        public WeaponFireType()
        {
            Weapon = new HashSet<Weapon>();
        }

        public int FireTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Weapon> Weapon { get; set; }
    }
}
