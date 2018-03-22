using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class PrerequisiteAbility
    {
        public int PrerequisiteAbilityId { get; set; }
        public int RequiredAbilityId { get; set; }
        public int? RequiredScore { get; set; }
        public int? ClassId { get; set; }
        public int? FeatId { get; set; }
        public int? TalentId { get; set; }

        public Class Class { get; set; }
        public Feat Feat { get; set; }
        public Ability RequiredAbility { get; set; }
        public Talent Talent { get; set; }
    }
}
