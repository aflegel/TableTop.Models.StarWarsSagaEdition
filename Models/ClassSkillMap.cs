using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class ClassSkillMap
    {
        public int ClassSkillId { get; set; }
        public int? ClassId { get; set; }
        public int? SkillId { get; set; }

        public Class Class { get; set; }
        public Skill Skill { get; set; }
    }
}
