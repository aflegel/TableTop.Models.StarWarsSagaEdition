using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class DroidSystem
    {
        public int DroidSystemId { get; set; }
        public int DroidId { get; set; }
        public int EquipmentDroidId { get; set; }
        public int? Quantity { get; set; }

        public Droid Droid { get; set; }
        public EquipmentDroid EquipmentDroid { get; set; }
    }
}
