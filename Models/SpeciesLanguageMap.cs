using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class SpeciesLanguageMap
    {
        public int SpeciesLanguageId { get; set; }
        public int? LanguageId { get; set; }
        public int? SpeciesId { get; set; }
    }
}
