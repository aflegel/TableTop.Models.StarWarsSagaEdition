using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class Weapon
    {
        public Weapon()
        {
            WeaponAmmunitionMap = new HashSet<WeaponAmmunitionMap>();
            WeaponDamageMap = new HashSet<WeaponDamageMap>();
        }

        public int WeaponId { get; set; }
        public string Name { get; set; }
        public int? BookId { get; set; }
        public int? Page { get; set; }
        public int? WeaponCategoryId { get; set; }
        public int? AvailabilityId { get; set; }
        public bool? Rare { get; set; }
        public int? SizeId { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Weight { get; set; }
        public string Damage { get; set; }
        public int? StunTypeId { get; set; }
        public int? FireTypeId { get; set; }
        public bool? Accurate { get; set; }
        public bool? Inaccurate { get; set; }
        public string Description { get; set; }

        public Availability Availability { get; set; }
        public Book Book { get; set; }
        public WeaponFireType FireType { get; set; }
        public Size Size { get; set; }
        public WeaponStunType StunType { get; set; }
        public WeaponCategory WeaponCategory { get; set; }
        public ICollection<WeaponAmmunitionMap> WeaponAmmunitionMap { get; set; }
        public ICollection<WeaponDamageMap> WeaponDamageMap { get; set; }
    }
}
