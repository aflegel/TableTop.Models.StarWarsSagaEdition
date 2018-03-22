using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class Availability
    {
        public Availability()
        {
            Armour = new HashSet<Armour>();
            Beast = new HashSet<Beast>();
            Droid = new HashSet<Droid>();
            Equipment = new HashSet<Equipment>();
            EquipmentCybernetic = new HashSet<EquipmentCybernetic>();
            EquipmentDroid = new HashSet<EquipmentDroid>();
            EquipmentUpgrade = new HashSet<EquipmentUpgrade>();
            Vehicle = new HashSet<Vehicle>();
            VehicleSystem = new HashSet<VehicleSystem>();
            Weapon = new HashSet<Weapon>();
        }

        public int AvailabilityId { get; set; }
        public string Name { get; set; }
        public decimal? Licensing { get; set; }
        public string Description { get; set; }

        public ICollection<Armour> Armour { get; set; }
        public ICollection<Beast> Beast { get; set; }
        public ICollection<Droid> Droid { get; set; }
        public ICollection<Equipment> Equipment { get; set; }
        public ICollection<EquipmentCybernetic> EquipmentCybernetic { get; set; }
        public ICollection<EquipmentDroid> EquipmentDroid { get; set; }
        public ICollection<EquipmentUpgrade> EquipmentUpgrade { get; set; }
        public ICollection<Vehicle> Vehicle { get; set; }
        public ICollection<VehicleSystem> VehicleSystem { get; set; }
        public ICollection<Weapon> Weapon { get; set; }
    }
}
