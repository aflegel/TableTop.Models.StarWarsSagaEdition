using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class Class
    {
        public Class()
        {
            ClassBonusFeatMap = new HashSet<ClassBonusFeatMap>();
            ClassPrestigeSpecial = new HashSet<ClassPrestigeSpecial>();
            ClassSkillMap = new HashSet<ClassSkillMap>();
            ClassTalentTreeMap = new HashSet<ClassTalentTreeMap>();
            PrerequisiteAbility = new HashSet<PrerequisiteAbility>();
            PrerequisiteFeat = new HashSet<PrerequisiteFeat>();
            PrerequisiteLevel = new HashSet<PrerequisiteLevel>();
            PrerequisiteSize = new HashSet<PrerequisiteSize>();
            PrerequisiteSkill = new HashSet<PrerequisiteSkill>();
            PrerequisiteSpecies = new HashSet<PrerequisiteSpecies>();
            PrerequisiteSpeciesTrait = new HashSet<PrerequisiteSpeciesTrait>();
            PrerequisiteTalent = new HashSet<PrerequisiteTalent>();
            PrerequisiteTalentTree = new HashSet<PrerequisiteTalentTree>();
        }

        public int ClassId { get; set; }
        public string Name { get; set; }
        public int? BookId { get; set; }
        public int? PageNumber { get; set; }
        public string Description { get; set; }
        public bool? Prestige { get; set; }
        public bool? Tradition { get; set; }

        public Book Book { get; set; }
        public ICollection<ClassBonusFeatMap> ClassBonusFeatMap { get; set; }
        public ICollection<ClassPrestigeSpecial> ClassPrestigeSpecial { get; set; }
        public ICollection<ClassSkillMap> ClassSkillMap { get; set; }
        public ICollection<ClassTalentTreeMap> ClassTalentTreeMap { get; set; }
        public ICollection<PrerequisiteAbility> PrerequisiteAbility { get; set; }
        public ICollection<PrerequisiteFeat> PrerequisiteFeat { get; set; }
        public ICollection<PrerequisiteLevel> PrerequisiteLevel { get; set; }
        public ICollection<PrerequisiteSize> PrerequisiteSize { get; set; }
        public ICollection<PrerequisiteSkill> PrerequisiteSkill { get; set; }
        public ICollection<PrerequisiteSpecies> PrerequisiteSpecies { get; set; }
        public ICollection<PrerequisiteSpeciesTrait> PrerequisiteSpeciesTrait { get; set; }
        public ICollection<PrerequisiteTalent> PrerequisiteTalent { get; set; }
        public ICollection<PrerequisiteTalentTree> PrerequisiteTalentTree { get; set; }
    }
}
