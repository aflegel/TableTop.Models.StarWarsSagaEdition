using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class Size
    {
        public Size()
        {
            PrerequisiteSize = new HashSet<PrerequisiteSize>();
            Vehicle = new HashSet<Vehicle>();
            VehicleSystemMaximumSize = new HashSet<VehicleSystem>();
            VehicleSystemMinimumSize = new HashSet<VehicleSystem>();
            Weapon = new HashSet<Weapon>();
        }

        public int SizeId { get; set; }
        public string Name { get; set; }
        public int? StrengthModifier { get; set; }
        public int? DexterityModifier { get; set; }
        public string Description { get; set; }
        public int? StarshipMultiplier { get; set; }
        public int? DroidMultiplier { get; set; }
        public int? ReflexModifier { get; set; }
        public int? StealthModifier { get; set; }
        public int? DroidHitpoints { get; set; }
        public int? ThresholdModifier { get; set; }
        public decimal? CarryCapacityModifier { get; set; }

        public ICollection<PrerequisiteSize> PrerequisiteSize { get; set; }
        public ICollection<Vehicle> Vehicle { get; set; }
        public ICollection<VehicleSystem> VehicleSystemMaximumSize { get; set; }
        public ICollection<VehicleSystem> VehicleSystemMinimumSize { get; set; }
        public ICollection<Weapon> Weapon { get; set; }
    }
}
