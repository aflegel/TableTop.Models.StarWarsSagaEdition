using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class WeaponCategory
    {
        public WeaponCategory()
        {
            Weapon = new HashSet<Weapon>();
        }

        public int WeaponCategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? WeaponRangeId { get; set; }

        public WeaponRange WeaponRange { get; set; }
        public ICollection<Weapon> Weapon { get; set; }
    }
}
