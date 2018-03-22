using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class PrerequisiteSize
    {
        public int PrerequisiteSizeId { get; set; }
        public int RequiredSideId { get; set; }
        public int? ClassId { get; set; }
        public int? FeatId { get; set; }
        public int? TalentId { get; set; }

        public Class Class { get; set; }
        public Feat Feat { get; set; }
        public Size RequiredSide { get; set; }
        public Talent Talent { get; set; }
    }
}
