using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class Level
    {
        public Level()
        {
            PrerequisiteLevel = new HashSet<PrerequisiteLevel>();
        }

        public int LevelId { get; set; }
        public string ChallengeLevel { get; set; }
        public int? ChallengeExperience { get; set; }
        public int? BaseExperience { get; set; }
        public int? BaseCredits { get; set; }
        public bool? FeatIncrease { get; set; }
        public bool? AbilityIncrease { get; set; }

        public ICollection<PrerequisiteLevel> PrerequisiteLevel { get; set; }
    }
}
