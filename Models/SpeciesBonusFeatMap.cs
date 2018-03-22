using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class SpeciesBonusFeatMap
    {
        public int SpeciesBonusFeatId { get; set; }
        public int? SpeciesId { get; set; }
        public int? FeatId { get; set; }
        public bool? Conditional { get; set; }
        public int? SkillId { get; set; }
    }
}
