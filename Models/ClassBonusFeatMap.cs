using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class ClassBonusFeatMap
    {
        public int BonusFeatId { get; set; }
        public int? ClassId { get; set; }
        public int? FeatId { get; set; }
        public int? BookId { get; set; }
        public int? PageNumber { get; set; }

        public Book Book { get; set; }
        public Class Class { get; set; }
        public Feat Feat { get; set; }
    }
}
