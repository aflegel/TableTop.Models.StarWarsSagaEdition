using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class ArmourHelmet
    {
        public ArmourHelmet()
        {
            Armour = new HashSet<Armour>();
        }

        public int HelmetId { get; set; }
        public string Description { get; set; }

        public ICollection<Armour> Armour { get; set; }
    }
}
