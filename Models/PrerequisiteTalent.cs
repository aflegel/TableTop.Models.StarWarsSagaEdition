using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class PrerequisiteTalent
    {
        public int PrerequisiteTalentId { get; set; }
        public int RequiredTalentId { get; set; }
        public int? ClassId { get; set; }
        public int? FeatId { get; set; }
        public int? TalentId { get; set; }

        public Class Class { get; set; }
        public Feat Feat { get; set; }
        public Talent RequiredTalent { get; set; }
        public Talent Talent { get; set; }
    }
}
