using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class Feat
    {
        public Feat()
        {
            ClassBonusFeatMap = new HashSet<ClassBonusFeatMap>();
            PrerequisiteAbility = new HashSet<PrerequisiteAbility>();
            PrerequisiteFeatFeat = new HashSet<PrerequisiteFeat>();
            PrerequisiteFeatRequiredFeat = new HashSet<PrerequisiteFeat>();
            PrerequisiteLevel = new HashSet<PrerequisiteLevel>();
            PrerequisiteSize = new HashSet<PrerequisiteSize>();
            PrerequisiteSkill = new HashSet<PrerequisiteSkill>();
            PrerequisiteSpecies = new HashSet<PrerequisiteSpecies>();
            PrerequisiteSpeciesTrait = new HashSet<PrerequisiteSpeciesTrait>();
            PrerequisiteTalent = new HashSet<PrerequisiteTalent>();
            PrerequisiteTalentTree = new HashSet<PrerequisiteTalentTree>();
        }

        public int FeatId { get; set; }
        public string Name { get; set; }
        public int? BookId { get; set; }
        public int? PageNumber { get; set; }
        public bool? Asterix { get; set; }
        public bool? Combat { get; set; }
        public string DescriptionShort { get; set; }
        public string Description { get; set; }

        public Book Book { get; set; }
        public ICollection<ClassBonusFeatMap> ClassBonusFeatMap { get; set; }
        public ICollection<PrerequisiteAbility> PrerequisiteAbility { get; set; }
        public ICollection<PrerequisiteFeat> PrerequisiteFeatFeat { get; set; }
        public ICollection<PrerequisiteFeat> PrerequisiteFeatRequiredFeat { get; set; }
        public ICollection<PrerequisiteLevel> PrerequisiteLevel { get; set; }
        public ICollection<PrerequisiteSize> PrerequisiteSize { get; set; }
        public ICollection<PrerequisiteSkill> PrerequisiteSkill { get; set; }
        public ICollection<PrerequisiteSpecies> PrerequisiteSpecies { get; set; }
        public ICollection<PrerequisiteSpeciesTrait> PrerequisiteSpeciesTrait { get; set; }
        public ICollection<PrerequisiteTalent> PrerequisiteTalent { get; set; }
        public ICollection<PrerequisiteTalentTree> PrerequisiteTalentTree { get; set; }
    }
}
