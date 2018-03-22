using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class PrerequisiteLevel
    {
        public int PrerequisiteLevelId { get; set; }
        public int RequiredLevelId { get; set; }
        public bool BaseAttack { get; set; }
        public bool DarkSideScore { get; set; }
        public int? ClassId { get; set; }
        public int? FeatId { get; set; }
        public int? TalentId { get; set; }

        public Class Class { get; set; }
        public Feat Feat { get; set; }
        public Level RequiredLevel { get; set; }
        public Talent Talent { get; set; }
    }
}
