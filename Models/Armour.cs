using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class Armour
    {
        public int ArmourId { get; set; }
        public string Name { get; set; }
        public int? BookId { get; set; }
        public int? Page { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Weight { get; set; }
        public int? ReflexBonus { get; set; }
        public int? FortitudeBonus { get; set; }
        public int? MaximumDexterity { get; set; }
        public int? AvailabilityId { get; set; }
        public bool? Rare { get; set; }
        public int? ArmourTypeId { get; set; }
        public int? HelmetId { get; set; }
        public int? AdditionalUpgrade { get; set; }
        public bool? Jetpack { get; set; }
        public string Description { get; set; }

        public ArmourType ArmourType { get; set; }
        public Availability Availability { get; set; }
        public Book Book { get; set; }
        public ArmourHelmet Helmet { get; set; }
    }
}
