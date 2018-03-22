using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class Ability
    {
        public Ability()
        {
            PrerequisiteAbility = new HashSet<PrerequisiteAbility>();
        }

        public int AbilityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<PrerequisiteAbility> PrerequisiteAbility { get; set; }
    }
}
