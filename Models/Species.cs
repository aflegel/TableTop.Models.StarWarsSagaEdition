using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class Species
    {
        public Species()
        {
            Character = new HashSet<Character>();
            PrerequisiteSpecies = new HashSet<PrerequisiteSpecies>();
            SpeciesTraitMap = new HashSet<SpeciesTraitMap>();
        }

        public int SpeciesId { get; set; }
        public string Name { get; set; }
        public int? StrengthModifier { get; set; }
        public int? DexterityModifier { get; set; }
        public int? ConstitutionModifier { get; set; }
        public int? IntelligenceModifier { get; set; }
        public int? WisdomModifier { get; set; }
        public int? CharismaModifier { get; set; }
        public int? BookId { get; set; }
        public int? Page { get; set; }
        public int? SizeId { get; set; }
        public int? BaseSpeed { get; set; }

        public Book Book { get; set; }
        public ICollection<Character> Character { get; set; }
        public ICollection<PrerequisiteSpecies> PrerequisiteSpecies { get; set; }
        public ICollection<SpeciesTraitMap> SpeciesTraitMap { get; set; }
    }
}
