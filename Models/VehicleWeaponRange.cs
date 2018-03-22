using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class VehicleWeaponRange
    {
        public VehicleWeaponRange()
        {
            VehicleSystem = new HashSet<VehicleSystem>();
        }

        public int WeaponRangeId { get; set; }
        public int? CharacterPointBlank { get; set; }
        public int? CharacterShort { get; set; }
        public int? CharacterMedium { get; set; }
        public int? CharacterLong { get; set; }
        public int? StarshipPointBlank { get; set; }
        public int? StarshipShort { get; set; }
        public int? StarshipMedium { get; set; }
        public int? StarshipLong { get; set; }

        public ICollection<VehicleSystem> VehicleSystem { get; set; }
    }
}
