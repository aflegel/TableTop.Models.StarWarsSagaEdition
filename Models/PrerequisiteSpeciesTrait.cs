using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class PrerequisiteSpeciesTrait
    {
        public int PrerequisiteTraitId { get; set; }
        public int RequiredTraitId { get; set; }
        public int? ClassId { get; set; }
        public int? FeatId { get; set; }
        public int? TalentId { get; set; }

        public Class Class { get; set; }
        public Feat Feat { get; set; }
        public SpeciesTrait RequiredTrait { get; set; }
        public Talent Talent { get; set; }
    }
}
