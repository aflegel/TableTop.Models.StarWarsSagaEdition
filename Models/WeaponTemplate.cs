using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class WeaponTemplate
    {
        public int WeaponTemplateId { get; set; }
        public string Name { get; set; }
        public decimal? Cost { get; set; }
        public int? BookId { get; set; }
        public int? Page { get; set; }
        public string Description { get; set; }
        public string DescriptionShort { get; set; }

        public Book Book { get; set; }
    }
}
