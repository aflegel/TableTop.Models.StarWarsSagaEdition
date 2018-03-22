using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class Beast
    {
        public int BeastId { get; set; }
        public string Name { get; set; }
        public int? Page { get; set; }
        public int? BookId { get; set; }
        public decimal? Cost { get; set; }
        public int? AvailabilityId { get; set; }
        public string Description { get; set; }

        public Availability Availability { get; set; }
        public Book Book { get; set; }
    }
}
