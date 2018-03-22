using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class ClassTalentTreeMap
    {
        public int ClassTreeId { get; set; }
        public int? ClassId { get; set; }
        public int? TalentTreeId { get; set; }

        public Class Class { get; set; }
        public TalentTree TalentTree { get; set; }
    }
}
