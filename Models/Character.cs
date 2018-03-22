using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class Character
    {
        public int CharacterId { get; set; }
        public string Name { get; set; }
        public int? Page { get; set; }
        public int? BookId { get; set; }
        public int? SpeciesId { get; set; }

        public Book Book { get; set; }
        public Species Species { get; set; }
    }
}
