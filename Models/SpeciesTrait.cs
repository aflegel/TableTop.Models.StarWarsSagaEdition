using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class SpeciesTrait
    {
        public SpeciesTrait()
        {
            PrerequisiteSpeciesTrait = new HashSet<PrerequisiteSpeciesTrait>();
            SpeciesTraitMap = new HashSet<SpeciesTraitMap>();
        }

        public int SpeciesTraitId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<PrerequisiteSpeciesTrait> PrerequisiteSpeciesTrait { get; set; }
        public ICollection<SpeciesTraitMap> SpeciesTraitMap { get; set; }
    }
}
