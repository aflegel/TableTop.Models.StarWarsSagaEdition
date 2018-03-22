using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class ArmourType
    {
        public ArmourType()
        {
            Armour = new HashSet<Armour>();
        }

        public int ArmourTypeId { get; set; }
        public string Description { get; set; }
        public int? CheckPenalty { get; set; }

        public ICollection<Armour> Armour { get; set; }
    }
}
