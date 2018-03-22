using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class WeaponStunType
    {
        public WeaponStunType()
        {
            Weapon = new HashSet<Weapon>();
        }

        public int StunTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Weapon> Weapon { get; set; }
    }
}
