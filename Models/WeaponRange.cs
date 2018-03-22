using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class WeaponRange
    {
        public WeaponRange()
        {
            WeaponCategory = new HashSet<WeaponCategory>();
        }

        public int WeaponRangeId { get; set; }
        public int? WeaponCategoryId { get; set; }
        public int? PointBlank { get; set; }
        public int? Short { get; set; }
        public int? Medium { get; set; }
        public int? Long { get; set; }

        public ICollection<WeaponCategory> WeaponCategory { get; set; }
    }
}
