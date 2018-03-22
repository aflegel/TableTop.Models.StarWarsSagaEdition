using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class Skill
    {
        public Skill()
        {
            ClassSkillMap = new HashSet<ClassSkillMap>();
            PrerequisiteSkill = new HashSet<PrerequisiteSkill>();
        }

        public int SkillId { get; set; }
        public string Name { get; set; }
        public int? BookId { get; set; }
        public int? PageNumber { get; set; }

        public ICollection<ClassSkillMap> ClassSkillMap { get; set; }
        public ICollection<PrerequisiteSkill> PrerequisiteSkill { get; set; }
    }
}
