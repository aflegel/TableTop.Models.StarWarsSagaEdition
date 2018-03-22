using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class PrerequisiteTalentTree
    {
        public int PrerequisiteTreeId { get; set; }
        public int RequiredTreeId { get; set; }
        public int? ClassId { get; set; }
        public int? FeatId { get; set; }
        public int? TalentId { get; set; }
        public int? TalentCount { get; set; }

        public Class Class { get; set; }
        public Feat Feat { get; set; }
        public TalentTree RequiredTree { get; set; }
        public Talent Talent { get; set; }
    }
}
