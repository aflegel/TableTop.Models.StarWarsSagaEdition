using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class PrerequisiteFeat
    {
        public int PrerequisiteFeatId { get; set; }
        public int RequiredFeatId { get; set; }
        public int? ClassId { get; set; }
        public int? FeatId { get; set; }
        public int? TalentId { get; set; }

        public Class Class { get; set; }
        public Feat Feat { get; set; }
        public Feat RequiredFeat { get; set; }
        public Talent Talent { get; set; }
    }
}
