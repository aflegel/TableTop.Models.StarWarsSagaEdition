using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class Book
    {
        public Book()
        {
            Armour = new HashSet<Armour>();
            ArmourTemplate = new HashSet<ArmourTemplate>();
            Beast = new HashSet<Beast>();
            Character = new HashSet<Character>();
            Class = new HashSet<Class>();
            ClassBonusFeatMap = new HashSet<ClassBonusFeatMap>();
            ClassPrestigeSpecial = new HashSet<ClassPrestigeSpecial>();
            Droid = new HashSet<Droid>();
            Equipment = new HashSet<Equipment>();
            EquipmentCybernetic = new HashSet<EquipmentCybernetic>();
            EquipmentDroid = new HashSet<EquipmentDroid>();
            EquipmentUpgrade = new HashSet<EquipmentUpgrade>();
            Feat = new HashSet<Feat>();
            ForcePower = new HashSet<ForcePower>();
            ForceSecret = new HashSet<ForceSecret>();
            ForceTechnique = new HashSet<ForceTechnique>();
            Index = new HashSet<Index>();
            MedicalSecret = new HashSet<MedicalSecret>();
            Planet = new HashSet<Planet>();
            Species = new HashSet<Species>();
            StarhipManeuver = new HashSet<StarhipManeuver>();
            Talent = new HashSet<Talent>();
            Vehicle = new HashSet<Vehicle>();
            VehicleAmmunition = new HashSet<VehicleAmmunition>();
            VehicleSystem = new HashSet<VehicleSystem>();
            VehicleTemplate = new HashSet<VehicleTemplate>();
            Weapon = new HashSet<Weapon>();
            WeaponTemplate = new HashSet<WeaponTemplate>();
        }

        public int BookId { get; set; }
        public string Title { get; set; }
        public DateTime? Published { get; set; }
        public int? PageCount { get; set; }
        public string ShortTitle { get; set; }

        public ICollection<Armour> Armour { get; set; }
        public ICollection<ArmourTemplate> ArmourTemplate { get; set; }
        public ICollection<Beast> Beast { get; set; }
        public ICollection<Character> Character { get; set; }
        public ICollection<Class> Class { get; set; }
        public ICollection<ClassBonusFeatMap> ClassBonusFeatMap { get; set; }
        public ICollection<ClassPrestigeSpecial> ClassPrestigeSpecial { get; set; }
        public ICollection<Droid> Droid { get; set; }
        public ICollection<Equipment> Equipment { get; set; }
        public ICollection<EquipmentCybernetic> EquipmentCybernetic { get; set; }
        public ICollection<EquipmentDroid> EquipmentDroid { get; set; }
        public ICollection<EquipmentUpgrade> EquipmentUpgrade { get; set; }
        public ICollection<Feat> Feat { get; set; }
        public ICollection<ForcePower> ForcePower { get; set; }
        public ICollection<ForceSecret> ForceSecret { get; set; }
        public ICollection<ForceTechnique> ForceTechnique { get; set; }
        public ICollection<Index> Index { get; set; }
        public ICollection<MedicalSecret> MedicalSecret { get; set; }
        public ICollection<Planet> Planet { get; set; }
        public ICollection<Species> Species { get; set; }
        public ICollection<StarhipManeuver> StarhipManeuver { get; set; }
        public ICollection<Talent> Talent { get; set; }
        public ICollection<Vehicle> Vehicle { get; set; }
        public ICollection<VehicleAmmunition> VehicleAmmunition { get; set; }
        public ICollection<VehicleSystem> VehicleSystem { get; set; }
        public ICollection<VehicleTemplate> VehicleTemplate { get; set; }
        public ICollection<Weapon> Weapon { get; set; }
        public ICollection<WeaponTemplate> WeaponTemplate { get; set; }
    }
}
