using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class PrerequisiteSpecies
    {
        public int PrerequisiteSpeciesId { get; set; }
        public int RequiredSpeciesId { get; set; }
        public int? ClassId { get; set; }
        public int? FeatId { get; set; }
        public int? TalentId { get; set; }

        public Class Class { get; set; }
        public Feat Feat { get; set; }
        public Species RequiredSpecies { get; set; }
        public Talent Talent { get; set; }
    }
}
