using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class PrerequisiteSkill
    {
        public int PrerequisiteSkillId { get; set; }
        public int RequiredSkillId { get; set; }
        public int? ClassId { get; set; }
        public int? FeatId { get; set; }
        public int? TalentId { get; set; }

        public Class Class { get; set; }
        public Feat Feat { get; set; }
        public Skill RequiredSkill { get; set; }
        public Talent Talent { get; set; }
    }
}
