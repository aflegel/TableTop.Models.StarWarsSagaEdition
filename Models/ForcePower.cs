using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class ForcePower
    {
        public int ForcePowerId { get; set; }
        public string Name { get; set; }
        public int? BookId { get; set; }
        public int? Page { get; set; }
        public bool? LightSide { get; set; }
        public bool? DarkSide { get; set; }
        public bool? LightsaberForm { get; set; }
        public bool? Telekenetic { get; set; }
        public bool? MindAffecting { get; set; }
        public string Description { get; set; }

        public Book Book { get; set; }
    }
}
