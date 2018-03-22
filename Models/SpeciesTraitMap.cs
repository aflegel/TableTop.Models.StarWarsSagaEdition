using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class SpeciesTraitMap
    {
        public int SpeciesTraitMapId { get; set; }
        public int? SpeciesTraitId { get; set; }
        public int? SpeciesId { get; set; }

        public Species Species { get; set; }
        public SpeciesTrait SpeciesTrait { get; set; }
    }
}
