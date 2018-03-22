using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class Talent
    {
        public Talent()
        {
            PrerequisiteAbility = new HashSet<PrerequisiteAbility>();
            PrerequisiteFeat = new HashSet<PrerequisiteFeat>();
            PrerequisiteLevel = new HashSet<PrerequisiteLevel>();
            PrerequisiteSize = new HashSet<PrerequisiteSize>();
            PrerequisiteSkill = new HashSet<PrerequisiteSkill>();
            PrerequisiteSpecies = new HashSet<PrerequisiteSpecies>();
            PrerequisiteSpeciesTrait = new HashSet<PrerequisiteSpeciesTrait>();
            PrerequisiteTalentRequiredTalent = new HashSet<PrerequisiteTalent>();
            PrerequisiteTalentTalent = new HashSet<PrerequisiteTalent>();
            PrerequisiteTalentTree = new HashSet<PrerequisiteTalentTree>();
        }

        public int TalentId { get; set; }
        public string Name { get; set; }
        public int? TalentTreeId { get; set; }
        public int? BookId { get; set; }
        public int? PageNumber { get; set; }
        public string Description { get; set; }

        public Book Book { get; set; }
        public TalentTree TalentTree { get; set; }
        public ICollection<PrerequisiteAbility> PrerequisiteAbility { get; set; }
        public ICollection<PrerequisiteFeat> PrerequisiteFeat { get; set; }
        public ICollection<PrerequisiteLevel> PrerequisiteLevel { get; set; }
        public ICollection<PrerequisiteSize> PrerequisiteSize { get; set; }
        public ICollection<PrerequisiteSkill> PrerequisiteSkill { get; set; }
        public ICollection<PrerequisiteSpecies> PrerequisiteSpecies { get; set; }
        public ICollection<PrerequisiteSpeciesTrait> PrerequisiteSpeciesTrait { get; set; }
        public ICollection<PrerequisiteTalent> PrerequisiteTalentRequiredTalent { get; set; }
        public ICollection<PrerequisiteTalent> PrerequisiteTalentTalent { get; set; }
        public ICollection<PrerequisiteTalentTree> PrerequisiteTalentTree { get; set; }
    }
}
