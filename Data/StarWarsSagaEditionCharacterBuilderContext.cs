using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StarWarsSagaEdition.Models
{
    public partial class StarWarsSagaEditionCharacterBuilderContext : DbContext
    {
        public virtual DbSet<Ability> Ability { get; set; }
        public virtual DbSet<Armour> Armour { get; set; }
        public virtual DbSet<ArmourHelmet> ArmourHelmet { get; set; }
        public virtual DbSet<ArmourTemplate> ArmourTemplate { get; set; }
        public virtual DbSet<ArmourType> ArmourType { get; set; }
        public virtual DbSet<Availability> Availability { get; set; }
        public virtual DbSet<Background> Background { get; set; }
        public virtual DbSet<Beast> Beast { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<Character> Character { get; set; }
        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<ClassBonusFeatMap> ClassBonusFeatMap { get; set; }
        public virtual DbSet<ClassPrestigeSpecial> ClassPrestigeSpecial { get; set; }
        public virtual DbSet<ClassSkillMap> ClassSkillMap { get; set; }
        public virtual DbSet<ClassTalentTreeMap> ClassTalentTreeMap { get; set; }
        public virtual DbSet<Droid> Droid { get; set; }
        public virtual DbSet<DroidSystem> DroidSystem { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<EquipmentCybernetic> EquipmentCybernetic { get; set; }
        public virtual DbSet<EquipmentDroid> EquipmentDroid { get; set; }
        public virtual DbSet<EquipmentUpgrade> EquipmentUpgrade { get; set; }
        public virtual DbSet<Feat> Feat { get; set; }
        public virtual DbSet<ForcePower> ForcePower { get; set; }
        public virtual DbSet<ForceSecret> ForceSecret { get; set; }
        public virtual DbSet<ForceTechnique> ForceTechnique { get; set; }
        public virtual DbSet<Index> Index { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<Level> Level { get; set; }
        public virtual DbSet<MedicalSecret> MedicalSecret { get; set; }
        public virtual DbSet<Planet> Planet { get; set; }
        public virtual DbSet<PrerequisiteAbility> PrerequisiteAbility { get; set; }
        public virtual DbSet<PrerequisiteFeat> PrerequisiteFeat { get; set; }
        public virtual DbSet<PrerequisiteLevel> PrerequisiteLevel { get; set; }
        public virtual DbSet<PrerequisiteSize> PrerequisiteSize { get; set; }
        public virtual DbSet<PrerequisiteSkill> PrerequisiteSkill { get; set; }
        public virtual DbSet<PrerequisiteSpecies> PrerequisiteSpecies { get; set; }
        public virtual DbSet<PrerequisiteSpeciesTrait> PrerequisiteSpeciesTrait { get; set; }
        public virtual DbSet<PrerequisiteTalent> PrerequisiteTalent { get; set; }
        public virtual DbSet<PrerequisiteTalentTree> PrerequisiteTalentTree { get; set; }
        public virtual DbSet<ShieldTemplate> ShieldTemplate { get; set; }
        public virtual DbSet<Size> Size { get; set; }
        public virtual DbSet<Skill> Skill { get; set; }
        public virtual DbSet<SkillAction> SkillAction { get; set; }
        public virtual DbSet<Species> Species { get; set; }
        public virtual DbSet<SpeciesBonusFeatMap> SpeciesBonusFeatMap { get; set; }
        public virtual DbSet<SpeciesLanguageMap> SpeciesLanguageMap { get; set; }
        public virtual DbSet<SpeciesTrait> SpeciesTrait { get; set; }
        public virtual DbSet<SpeciesTraitMap> SpeciesTraitMap { get; set; }
        public virtual DbSet<StarhipManeuver> StarhipManeuver { get; set; }
        public virtual DbSet<Talent> Talent { get; set; }
        public virtual DbSet<TalentTree> TalentTree { get; set; }
        public virtual DbSet<Vehicle> Vehicle { get; set; }
        public virtual DbSet<VehicleAmmunition> VehicleAmmunition { get; set; }
        public virtual DbSet<VehicleSystem> VehicleSystem { get; set; }
        public virtual DbSet<VehicleSystemMap> VehicleSystemMap { get; set; }
        public virtual DbSet<VehicleTemplate> VehicleTemplate { get; set; }
        public virtual DbSet<VehicleType> VehicleType { get; set; }
        public virtual DbSet<VehicleWeaponRange> VehicleWeaponRange { get; set; }
        public virtual DbSet<Weapon> Weapon { get; set; }
        public virtual DbSet<WeaponAmmunition> WeaponAmmunition { get; set; }
        public virtual DbSet<WeaponAmmunitionMap> WeaponAmmunitionMap { get; set; }
        public virtual DbSet<WeaponCategory> WeaponCategory { get; set; }
        public virtual DbSet<WeaponDamageMap> WeaponDamageMap { get; set; }
        public virtual DbSet<WeaponDamageType> WeaponDamageType { get; set; }
        public virtual DbSet<WeaponFireType> WeaponFireType { get; set; }
        public virtual DbSet<WeaponRange> WeaponRange { get; set; }
        public virtual DbSet<WeaponStunType> WeaponStunType { get; set; }
        public virtual DbSet<WeaponTemplate> WeaponTemplate { get; set; }

        // Unable to generate entity type for table 'dbo.age'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=Alex-Desktop;Database=StarWarsSagaEditionCharacterBuilder;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ability>(entity =>
            {
                entity.ToTable("ability");

                entity.Property(e => e.AbilityId).HasColumnName("ability_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Armour>(entity =>
            {
                entity.ToTable("armour");

                entity.Property(e => e.ArmourId).HasColumnName("armour_id");

                entity.Property(e => e.AdditionalUpgrade).HasColumnName("additional_upgrade");

                entity.Property(e => e.ArmourTypeId).HasColumnName("armour_type_id");

                entity.Property(e => e.AvailabilityId).HasColumnName("availability_id");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.FortitudeBonus).HasColumnName("fortitude_bonus");

                entity.Property(e => e.HelmetId).HasColumnName("helmet_id");

                entity.Property(e => e.Jetpack).HasColumnName("jetpack");

                entity.Property(e => e.MaximumDexterity).HasColumnName("maximum_dexterity");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Page).HasColumnName("page");

                entity.Property(e => e.Rare).HasColumnName("rare");

                entity.Property(e => e.ReflexBonus).HasColumnName("reflex_bonus");

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.HasOne(d => d.ArmourType)
                    .WithMany(p => p.Armour)
                    .HasForeignKey(d => d.ArmourTypeId)
                    .HasConstraintName("FK_armour_armourType");

                entity.HasOne(d => d.Availability)
                    .WithMany(p => p.Armour)
                    .HasForeignKey(d => d.AvailabilityId)
                    .HasConstraintName("FK_armour_availability");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Armour)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_armour_book");

                entity.HasOne(d => d.Helmet)
                    .WithMany(p => p.Armour)
                    .HasForeignKey(d => d.HelmetId)
                    .HasConstraintName("FK_armour_armourHelmet");
            });

            modelBuilder.Entity<ArmourHelmet>(entity =>
            {
                entity.HasKey(e => e.HelmetId);

                entity.ToTable("armourHelmet");

                entity.Property(e => e.HelmetId).HasColumnName("helmet_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ArmourTemplate>(entity =>
            {
                entity.ToTable("armourTemplate");

                entity.Property(e => e.ArmourTemplateId).HasColumnName("armour_template_id");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Page).HasColumnName("page");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.ArmourTemplate)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_armourTemplate_book");
            });

            modelBuilder.Entity<ArmourType>(entity =>
            {
                entity.ToTable("armourType");

                entity.Property(e => e.ArmourTypeId).HasColumnName("armour_type_id");

                entity.Property(e => e.CheckPenalty).HasColumnName("check_penalty");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Availability>(entity =>
            {
                entity.ToTable("availability");

                entity.Property(e => e.AvailabilityId).HasColumnName("availability_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.Licensing).HasColumnName("licensing");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Background>(entity =>
            {
                entity.ToTable("background");

                entity.Property(e => e.BackgroundId).HasColumnName("background_id");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Page).HasColumnName("page");
            });

            modelBuilder.Entity<Beast>(entity =>
            {
                entity.ToTable("beast");

                entity.Property(e => e.BeastId).HasColumnName("beast_id");

                entity.Property(e => e.AvailabilityId).HasColumnName("availability_id");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Page).HasColumnName("page");

                entity.HasOne(d => d.Availability)
                    .WithMany(p => p.Beast)
                    .HasForeignKey(d => d.AvailabilityId)
                    .HasConstraintName("FK_beasts_availability");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Beast)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_beasts_book");
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("book");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.PageCount).HasColumnName("page_count");

                entity.Property(e => e.Published)
                    .HasColumnName("published")
                    .HasColumnType("date");

                entity.Property(e => e.ShortTitle)
                    .HasColumnName("short_title")
                    .HasMaxLength(20);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Character>(entity =>
            {
                entity.ToTable("character");

                entity.Property(e => e.CharacterId).HasColumnName("character_id");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Page).HasColumnName("page");

                entity.Property(e => e.SpeciesId).HasColumnName("species_id");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Character)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_characters_book");

                entity.HasOne(d => d.Species)
                    .WithMany(p => p.Character)
                    .HasForeignKey(d => d.SpeciesId)
                    .HasConstraintName("FK_characters_species");
            });

            modelBuilder.Entity<Class>(entity =>
            {
                entity.ToTable("class");

                entity.Property(e => e.ClassId).HasColumnName("class_id");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.PageNumber).HasColumnName("page_number");

                entity.Property(e => e.Prestige).HasColumnName("prestige");

                entity.Property(e => e.Tradition).HasColumnName("tradition");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Class)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_class_book");
            });

            modelBuilder.Entity<ClassBonusFeatMap>(entity =>
            {
                entity.HasKey(e => e.BonusFeatId);

                entity.ToTable("classBonusFeatMap");

                entity.Property(e => e.BonusFeatId).HasColumnName("bonus_feat_id");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.ClassId).HasColumnName("class_id");

                entity.Property(e => e.FeatId).HasColumnName("feat_id");

                entity.Property(e => e.PageNumber).HasColumnName("page_number");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.ClassBonusFeatMap)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_classBonusFeat_book");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.ClassBonusFeatMap)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_classBonusFeat_class");

                entity.HasOne(d => d.Feat)
                    .WithMany(p => p.ClassBonusFeatMap)
                    .HasForeignKey(d => d.FeatId)
                    .HasConstraintName("FK_classBonusFeat_feat");
            });

            modelBuilder.Entity<ClassPrestigeSpecial>(entity =>
            {
                entity.ToTable("classPrestigeSpecial");

                entity.Property(e => e.ClassPrestigeSpecialId).HasColumnName("class_prestige_special_id");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.ClassId).HasColumnName("class_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Page).HasColumnName("page");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.ClassPrestigeSpecial)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_classPrestigeSpecial_book");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.ClassPrestigeSpecial)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_classPrestigeSpecial_class");
            });

            modelBuilder.Entity<ClassSkillMap>(entity =>
            {
                entity.HasKey(e => e.ClassSkillId);

                entity.ToTable("classSkillMap");

                entity.Property(e => e.ClassSkillId).HasColumnName("class_skill_id");

                entity.Property(e => e.ClassId).HasColumnName("class_id");

                entity.Property(e => e.SkillId).HasColumnName("skill_id");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.ClassSkillMap)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_classSkill_class");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.ClassSkillMap)
                    .HasForeignKey(d => d.SkillId)
                    .HasConstraintName("FK_classSkill_skill");
            });

            modelBuilder.Entity<ClassTalentTreeMap>(entity =>
            {
                entity.HasKey(e => e.ClassTreeId);

                entity.ToTable("classTalentTreeMap");

                entity.Property(e => e.ClassTreeId).HasColumnName("class_tree_id");

                entity.Property(e => e.ClassId).HasColumnName("class_id");

                entity.Property(e => e.TalentTreeId).HasColumnName("talent_tree_id");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.ClassTalentTreeMap)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_classTalentTree_class");

                entity.HasOne(d => d.TalentTree)
                    .WithMany(p => p.ClassTalentTreeMap)
                    .HasForeignKey(d => d.TalentTreeId)
                    .HasConstraintName("FK_classTalentTree_talentTree");
            });

            modelBuilder.Entity<Droid>(entity =>
            {
                entity.ToTable("droid");

                entity.Property(e => e.DroidId).HasColumnName("droid_id");

                entity.Property(e => e.AvailabilityId).HasColumnName("availability_id");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.Degree).HasColumnName("degree");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Page).HasColumnName("page");

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.HasOne(d => d.Availability)
                    .WithMany(p => p.Droid)
                    .HasForeignKey(d => d.AvailabilityId)
                    .HasConstraintName("FK_droid_availability");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Droid)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_droid_book");
            });

            modelBuilder.Entity<DroidSystem>(entity =>
            {
                entity.ToTable("droidSystem");

                entity.Property(e => e.DroidSystemId).HasColumnName("droid_system_id");

                entity.Property(e => e.DroidId).HasColumnName("droid_id");

                entity.Property(e => e.EquipmentDroidId).HasColumnName("equipment_droid_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.Droid)
                    .WithMany(p => p.DroidSystem)
                    .HasForeignKey(d => d.DroidId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_droidSystem_droid");

                entity.HasOne(d => d.EquipmentDroid)
                    .WithMany(p => p.DroidSystem)
                    .HasForeignKey(d => d.EquipmentDroidId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_droidSystem_equipmentDroid");
            });

            modelBuilder.Entity<Equipment>(entity =>
            {
                entity.ToTable("equipment");

                entity.Property(e => e.EquipmentId).HasColumnName("equipment_id");

                entity.Property(e => e.AvailabilityId).HasColumnName("availability_id");

                entity.Property(e => e.BodySlot).HasColumnName("body_slot");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.HeadSlot).HasColumnName("head_slot");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(75);

                entity.Property(e => e.Page).HasColumnName("page");

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.HasOne(d => d.Availability)
                    .WithMany(p => p.Equipment)
                    .HasForeignKey(d => d.AvailabilityId)
                    .HasConstraintName("FK_equipment_availability");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Equipment)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_equipment_book");
            });

            modelBuilder.Entity<EquipmentCybernetic>(entity =>
            {
                entity.ToTable("equipmentCybernetic");

                entity.Property(e => e.EquipmentCyberneticId).HasColumnName("equipment_cybernetic_id");

                entity.Property(e => e.AvailabilityId).HasColumnName("availability_id");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Page).HasColumnName("page");

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.HasOne(d => d.Availability)
                    .WithMany(p => p.EquipmentCybernetic)
                    .HasForeignKey(d => d.AvailabilityId)
                    .HasConstraintName("FK_equipmentCybernetic_availability");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.EquipmentCybernetic)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_equipmentCybernetic_book");
            });

            modelBuilder.Entity<EquipmentDroid>(entity =>
            {
                entity.ToTable("equipmentDroid");

                entity.Property(e => e.EquipmentDroidId).HasColumnName("equipment_droid_id");

                entity.Property(e => e.AvailabilityId).HasColumnName("availability_id");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.Detachable).HasColumnName("detachable");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Page).HasColumnName("page");

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.HasOne(d => d.Availability)
                    .WithMany(p => p.EquipmentDroid)
                    .HasForeignKey(d => d.AvailabilityId)
                    .HasConstraintName("FK_equipmentDroid_availability");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.EquipmentDroid)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_equipmentDroid_book");
            });

            modelBuilder.Entity<EquipmentUpgrade>(entity =>
            {
                entity.ToTable("equipmentUpgrade");

                entity.Property(e => e.EquipmentUpgradeId).HasColumnName("equipment_upgrade_id");

                entity.Property(e => e.ArmorUpgrade).HasColumnName("armor_upgrade");

                entity.Property(e => e.AvailabilityId).HasColumnName("availability_id");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Page).HasColumnName("page");

                entity.Property(e => e.UpgradeSlots).HasColumnName("upgrade_slots");

                entity.Property(e => e.WeaponUpgrade).HasColumnName("weapon_upgrade");

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.HasOne(d => d.Availability)
                    .WithMany(p => p.EquipmentUpgrade)
                    .HasForeignKey(d => d.AvailabilityId)
                    .HasConstraintName("FK_equipmentUpgrade_availability");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.EquipmentUpgrade)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_equipmentUpgrade_book");
            });

            modelBuilder.Entity<Feat>(entity =>
            {
                entity.ToTable("feat");

                entity.Property(e => e.FeatId).HasColumnName("feat_id");

                entity.Property(e => e.Asterix).HasColumnName("asterix");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.Combat).HasColumnName("combat");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.DescriptionShort)
                    .HasColumnName("description_short")
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.PageNumber).HasColumnName("page_number");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Feat)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_feat_book");
            });

            modelBuilder.Entity<ForcePower>(entity =>
            {
                entity.ToTable("forcePower");

                entity.Property(e => e.ForcePowerId).HasColumnName("force_power_id");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.DarkSide).HasColumnName("dark_side");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.LightSide).HasColumnName("light_side");

                entity.Property(e => e.LightsaberForm).HasColumnName("lightsaber_form");

                entity.Property(e => e.MindAffecting).HasColumnName("mind_affecting");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Page).HasColumnName("page");

                entity.Property(e => e.Telekenetic).HasColumnName("telekenetic");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.ForcePower)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_forcePower_book");
            });

            modelBuilder.Entity<ForceSecret>(entity =>
            {
                entity.ToTable("forceSecret");

                entity.Property(e => e.ForceSecretId).HasColumnName("force_secret_id");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Page).HasColumnName("page");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.ForceSecret)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_forceSecret_book");
            });

            modelBuilder.Entity<ForceTechnique>(entity =>
            {
                entity.ToTable("forceTechnique");

                entity.Property(e => e.ForceTechniqueId).HasColumnName("force_technique_id");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Page).HasColumnName("page");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.ForceTechnique)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_forceTechnique_book");
            });

            modelBuilder.Entity<Index>(entity =>
            {
                entity.ToTable("index");

                entity.Property(e => e.IndexId).HasColumnName("index_id");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Page).HasColumnName("page");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Index)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_index_book");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.ToTable("language");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Level>(entity =>
            {
                entity.ToTable("level");

                entity.Property(e => e.LevelId).HasColumnName("level_id");

                entity.Property(e => e.AbilityIncrease).HasColumnName("ability_increase");

                entity.Property(e => e.BaseCredits).HasColumnName("base_credits");

                entity.Property(e => e.BaseExperience).HasColumnName("base_experience");

                entity.Property(e => e.ChallengeExperience).HasColumnName("challenge_experience");

                entity.Property(e => e.ChallengeLevel)
                    .HasColumnName("challenge_level")
                    .HasMaxLength(50);

                entity.Property(e => e.FeatIncrease).HasColumnName("feat_increase");
            });

            modelBuilder.Entity<MedicalSecret>(entity =>
            {
                entity.ToTable("medicalSecret");

                entity.Property(e => e.MedicalSecretId).HasColumnName("medical_secret_id");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Page).HasColumnName("page");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.MedicalSecret)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_medicalSecret_book");
            });

            modelBuilder.Entity<Planet>(entity =>
            {
                entity.ToTable("planet");

                entity.Property(e => e.PlanetId).HasColumnName("planet_id");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Page).HasColumnName("page");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Planet)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_planet_book");
            });

            modelBuilder.Entity<PrerequisiteAbility>(entity =>
            {
                entity.ToTable("prerequisiteAbility");

                entity.Property(e => e.PrerequisiteAbilityId).HasColumnName("prerequisite_ability_id");

                entity.Property(e => e.ClassId).HasColumnName("class_id");

                entity.Property(e => e.FeatId).HasColumnName("feat_id");

                entity.Property(e => e.RequiredAbilityId).HasColumnName("required_ability_id");

                entity.Property(e => e.RequiredScore).HasColumnName("required_score");

                entity.Property(e => e.TalentId).HasColumnName("talent_id");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.PrerequisiteAbility)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_prerequisiteAbility_class");

                entity.HasOne(d => d.Feat)
                    .WithMany(p => p.PrerequisiteAbility)
                    .HasForeignKey(d => d.FeatId)
                    .HasConstraintName("FK_prerequisiteAbility_feat");

                entity.HasOne(d => d.RequiredAbility)
                    .WithMany(p => p.PrerequisiteAbility)
                    .HasForeignKey(d => d.RequiredAbilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_prerequisiteAbility_ability");

                entity.HasOne(d => d.Talent)
                    .WithMany(p => p.PrerequisiteAbility)
                    .HasForeignKey(d => d.TalentId)
                    .HasConstraintName("FK_prerequisiteAbility_talent");
            });

            modelBuilder.Entity<PrerequisiteFeat>(entity =>
            {
                entity.ToTable("prerequisiteFeat");

                entity.Property(e => e.PrerequisiteFeatId).HasColumnName("prerequisite_feat_id");

                entity.Property(e => e.ClassId).HasColumnName("class_id");

                entity.Property(e => e.FeatId).HasColumnName("feat_id");

                entity.Property(e => e.RequiredFeatId).HasColumnName("required_feat_id");

                entity.Property(e => e.TalentId).HasColumnName("talent_id");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.PrerequisiteFeat)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_prerequisiteFeat_class");

                entity.HasOne(d => d.Feat)
                    .WithMany(p => p.PrerequisiteFeatFeat)
                    .HasForeignKey(d => d.FeatId)
                    .HasConstraintName("FK_prerequisiteFeat_feat");

                entity.HasOne(d => d.RequiredFeat)
                    .WithMany(p => p.PrerequisiteFeatRequiredFeat)
                    .HasForeignKey(d => d.RequiredFeatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_prerequisiteFeat_feat_required");

                entity.HasOne(d => d.Talent)
                    .WithMany(p => p.PrerequisiteFeat)
                    .HasForeignKey(d => d.TalentId)
                    .HasConstraintName("FK_prerequisiteFeat_talent");
            });

            modelBuilder.Entity<PrerequisiteLevel>(entity =>
            {
                entity.ToTable("prerequisiteLevel");

                entity.Property(e => e.PrerequisiteLevelId).HasColumnName("prerequisite_level_id");

                entity.Property(e => e.BaseAttack).HasColumnName("base_attack");

                entity.Property(e => e.ClassId).HasColumnName("class_id");

                entity.Property(e => e.DarkSideScore).HasColumnName("dark_side_score");

                entity.Property(e => e.FeatId).HasColumnName("feat_id");

                entity.Property(e => e.RequiredLevelId).HasColumnName("required_level_id");

                entity.Property(e => e.TalentId).HasColumnName("talent_id");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.PrerequisiteLevel)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_prerequisiteLevel_class");

                entity.HasOne(d => d.Feat)
                    .WithMany(p => p.PrerequisiteLevel)
                    .HasForeignKey(d => d.FeatId)
                    .HasConstraintName("FK_prerequisiteLevel_feat");

                entity.HasOne(d => d.RequiredLevel)
                    .WithMany(p => p.PrerequisiteLevel)
                    .HasForeignKey(d => d.RequiredLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_prerequisiteLevel_level");

                entity.HasOne(d => d.Talent)
                    .WithMany(p => p.PrerequisiteLevel)
                    .HasForeignKey(d => d.TalentId)
                    .HasConstraintName("FK_prerequisiteLevel_talent");
            });

            modelBuilder.Entity<PrerequisiteSize>(entity =>
            {
                entity.ToTable("prerequisiteSize");

                entity.Property(e => e.PrerequisiteSizeId).HasColumnName("prerequisite_size_id");

                entity.Property(e => e.ClassId).HasColumnName("class_id");

                entity.Property(e => e.FeatId).HasColumnName("feat_id");

                entity.Property(e => e.RequiredSideId).HasColumnName("required_side_id");

                entity.Property(e => e.TalentId).HasColumnName("talent_id");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.PrerequisiteSize)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_prerequisiteSize_class");

                entity.HasOne(d => d.Feat)
                    .WithMany(p => p.PrerequisiteSize)
                    .HasForeignKey(d => d.FeatId)
                    .HasConstraintName("FK_prerequisiteSize_feat");

                entity.HasOne(d => d.RequiredSide)
                    .WithMany(p => p.PrerequisiteSize)
                    .HasForeignKey(d => d.RequiredSideId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_prerequisiteSize_size");

                entity.HasOne(d => d.Talent)
                    .WithMany(p => p.PrerequisiteSize)
                    .HasForeignKey(d => d.TalentId)
                    .HasConstraintName("FK_prerequisiteSize_talent");
            });

            modelBuilder.Entity<PrerequisiteSkill>(entity =>
            {
                entity.ToTable("prerequisiteSkill");

                entity.Property(e => e.PrerequisiteSkillId).HasColumnName("prerequisite_skill_id");

                entity.Property(e => e.ClassId).HasColumnName("class_id");

                entity.Property(e => e.FeatId).HasColumnName("feat_id");

                entity.Property(e => e.RequiredSkillId).HasColumnName("required_skill_id");

                entity.Property(e => e.TalentId).HasColumnName("talent_id");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.PrerequisiteSkill)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_prerequisiteSkill_class");

                entity.HasOne(d => d.Feat)
                    .WithMany(p => p.PrerequisiteSkill)
                    .HasForeignKey(d => d.FeatId)
                    .HasConstraintName("FK_prerequisiteSkill_feat");

                entity.HasOne(d => d.RequiredSkill)
                    .WithMany(p => p.PrerequisiteSkill)
                    .HasForeignKey(d => d.RequiredSkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_prerequisiteSkill_skill");

                entity.HasOne(d => d.Talent)
                    .WithMany(p => p.PrerequisiteSkill)
                    .HasForeignKey(d => d.TalentId)
                    .HasConstraintName("FK_prerequisiteSkill_talent");
            });

            modelBuilder.Entity<PrerequisiteSpecies>(entity =>
            {
                entity.ToTable("prerequisiteSpecies");

                entity.Property(e => e.PrerequisiteSpeciesId).HasColumnName("prerequisite_species_id");

                entity.Property(e => e.ClassId).HasColumnName("class_id");

                entity.Property(e => e.FeatId).HasColumnName("feat_id");

                entity.Property(e => e.RequiredSpeciesId).HasColumnName("required_species_id");

                entity.Property(e => e.TalentId).HasColumnName("talent_id");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.PrerequisiteSpecies)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_prerequisiteSpecies_class");

                entity.HasOne(d => d.Feat)
                    .WithMany(p => p.PrerequisiteSpecies)
                    .HasForeignKey(d => d.FeatId)
                    .HasConstraintName("FK_prerequisiteSpecies_feat");

                entity.HasOne(d => d.RequiredSpecies)
                    .WithMany(p => p.PrerequisiteSpecies)
                    .HasForeignKey(d => d.RequiredSpeciesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_prerequisiteSpecies_species");

                entity.HasOne(d => d.Talent)
                    .WithMany(p => p.PrerequisiteSpecies)
                    .HasForeignKey(d => d.TalentId)
                    .HasConstraintName("FK_prerequisiteSpecies_talent");
            });

            modelBuilder.Entity<PrerequisiteSpeciesTrait>(entity =>
            {
                entity.HasKey(e => e.PrerequisiteTraitId);

                entity.ToTable("prerequisiteSpeciesTrait");

                entity.Property(e => e.PrerequisiteTraitId).HasColumnName("prerequisite_trait_id");

                entity.Property(e => e.ClassId).HasColumnName("class_id");

                entity.Property(e => e.FeatId).HasColumnName("feat_id");

                entity.Property(e => e.RequiredTraitId).HasColumnName("required_trait_id");

                entity.Property(e => e.TalentId).HasColumnName("talent_id");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.PrerequisiteSpeciesTrait)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_prerequisiteSpeciesTrait_class");

                entity.HasOne(d => d.Feat)
                    .WithMany(p => p.PrerequisiteSpeciesTrait)
                    .HasForeignKey(d => d.FeatId)
                    .HasConstraintName("FK_prerequisiteSpeciesTrait_feat");

                entity.HasOne(d => d.RequiredTrait)
                    .WithMany(p => p.PrerequisiteSpeciesTrait)
                    .HasForeignKey(d => d.RequiredTraitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_prerequisiteSpeciesTrait_speciesTrait");

                entity.HasOne(d => d.Talent)
                    .WithMany(p => p.PrerequisiteSpeciesTrait)
                    .HasForeignKey(d => d.TalentId)
                    .HasConstraintName("FK_prerequisiteSpeciesTrait_talent");
            });

            modelBuilder.Entity<PrerequisiteTalent>(entity =>
            {
                entity.ToTable("prerequisiteTalent");

                entity.Property(e => e.PrerequisiteTalentId).HasColumnName("prerequisite_talent_id");

                entity.Property(e => e.ClassId).HasColumnName("class_id");

                entity.Property(e => e.FeatId).HasColumnName("feat_id");

                entity.Property(e => e.RequiredTalentId).HasColumnName("required_talent_id");

                entity.Property(e => e.TalentId).HasColumnName("talent_id");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.PrerequisiteTalent)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_prerequisiteTalent_class");

                entity.HasOne(d => d.Feat)
                    .WithMany(p => p.PrerequisiteTalent)
                    .HasForeignKey(d => d.FeatId)
                    .HasConstraintName("FK_prerequisiteTalent_feat");

                entity.HasOne(d => d.RequiredTalent)
                    .WithMany(p => p.PrerequisiteTalentRequiredTalent)
                    .HasForeignKey(d => d.RequiredTalentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_prerequisiteTalent_talent_required");

                entity.HasOne(d => d.Talent)
                    .WithMany(p => p.PrerequisiteTalentTalent)
                    .HasForeignKey(d => d.TalentId)
                    .HasConstraintName("FK_prerequisiteTalent_talent");
            });

            modelBuilder.Entity<PrerequisiteTalentTree>(entity =>
            {
                entity.HasKey(e => e.PrerequisiteTreeId);

                entity.ToTable("prerequisiteTalentTree");

                entity.Property(e => e.PrerequisiteTreeId).HasColumnName("prerequisite_tree_id");

                entity.Property(e => e.ClassId).HasColumnName("class_id");

                entity.Property(e => e.FeatId).HasColumnName("feat_id");

                entity.Property(e => e.RequiredTreeId).HasColumnName("required_tree_id");

                entity.Property(e => e.TalentCount).HasColumnName("talent_count");

                entity.Property(e => e.TalentId).HasColumnName("talent_id");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.PrerequisiteTalentTree)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_prerequisiteTalentTree_class");

                entity.HasOne(d => d.Feat)
                    .WithMany(p => p.PrerequisiteTalentTree)
                    .HasForeignKey(d => d.FeatId)
                    .HasConstraintName("FK_prerequisiteTalentTree_feat");

                entity.HasOne(d => d.RequiredTree)
                    .WithMany(p => p.PrerequisiteTalentTree)
                    .HasForeignKey(d => d.RequiredTreeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_prerequisiteTalentTree_talentTree");

                entity.HasOne(d => d.Talent)
                    .WithMany(p => p.PrerequisiteTalentTree)
                    .HasForeignKey(d => d.TalentId)
                    .HasConstraintName("FK_prerequisiteTalentTree_talent");
            });

            modelBuilder.Entity<ShieldTemplate>(entity =>
            {
                entity.HasKey(e => e.TemplateId);

                entity.ToTable("shieldTemplate");

                entity.Property(e => e.TemplateId).HasColumnName("template_id");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Page).HasColumnName("page");
            });

            modelBuilder.Entity<Size>(entity =>
            {
                entity.ToTable("size");

                entity.Property(e => e.SizeId).HasColumnName("size_id");

                entity.Property(e => e.CarryCapacityModifier).HasColumnName("carry_capacity_modifier");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.DexterityModifier).HasColumnName("dexterity_modifier");

                entity.Property(e => e.DroidHitpoints).HasColumnName("droid_hitpoints");

                entity.Property(e => e.DroidMultiplier).HasColumnName("droid_multiplier");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.ReflexModifier).HasColumnName("reflex_modifier");

                entity.Property(e => e.StarshipMultiplier).HasColumnName("starship_multiplier");

                entity.Property(e => e.StealthModifier).HasColumnName("stealth_modifier");

                entity.Property(e => e.StrengthModifier).HasColumnName("strength_modifier");

                entity.Property(e => e.ThresholdModifier).HasColumnName("threshold_modifier");
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.ToTable("skill");

                entity.Property(e => e.SkillId).HasColumnName("skill_id");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.PageNumber).HasColumnName("page_number");
            });

            modelBuilder.Entity<SkillAction>(entity =>
            {
                entity.ToTable("skillAction");

                entity.Property(e => e.SkillActionId).HasColumnName("skill_action_id");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Page).HasColumnName("page");
            });

            modelBuilder.Entity<Species>(entity =>
            {
                entity.ToTable("species");

                entity.Property(e => e.SpeciesId).HasColumnName("species_id");

                entity.Property(e => e.BaseSpeed).HasColumnName("base_speed");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.CharismaModifier).HasColumnName("charisma_modifier");

                entity.Property(e => e.ConstitutionModifier).HasColumnName("constitution_modifier");

                entity.Property(e => e.DexterityModifier).HasColumnName("dexterity_modifier");

                entity.Property(e => e.IntelligenceModifier).HasColumnName("intelligence_modifier");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Page).HasColumnName("page");

                entity.Property(e => e.SizeId).HasColumnName("size_id");

                entity.Property(e => e.StrengthModifier).HasColumnName("strength_modifier");

                entity.Property(e => e.WisdomModifier).HasColumnName("wisdom_modifier");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Species)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_species_book");
            });

            modelBuilder.Entity<SpeciesBonusFeatMap>(entity =>
            {
                entity.HasKey(e => e.SpeciesBonusFeatId);

                entity.ToTable("speciesBonusFeatMap");

                entity.Property(e => e.SpeciesBonusFeatId).HasColumnName("species_bonus_feat_id");

                entity.Property(e => e.Conditional).HasColumnName("conditional");

                entity.Property(e => e.FeatId).HasColumnName("feat_id");

                entity.Property(e => e.SkillId).HasColumnName("skill_id");

                entity.Property(e => e.SpeciesId).HasColumnName("species_id");
            });

            modelBuilder.Entity<SpeciesLanguageMap>(entity =>
            {
                entity.HasKey(e => e.SpeciesLanguageId);

                entity.ToTable("speciesLanguageMap");

                entity.Property(e => e.SpeciesLanguageId).HasColumnName("species_language_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.SpeciesId).HasColumnName("species_id");
            });

            modelBuilder.Entity<SpeciesTrait>(entity =>
            {
                entity.ToTable("speciesTrait");

                entity.Property(e => e.SpeciesTraitId).HasColumnName("species_trait_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(500);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SpeciesTraitMap>(entity =>
            {
                entity.ToTable("speciesTraitMap");

                entity.Property(e => e.SpeciesTraitMapId).HasColumnName("species_trait_map_id");

                entity.Property(e => e.SpeciesId).HasColumnName("species_id");

                entity.Property(e => e.SpeciesTraitId).HasColumnName("species_trait_id");

                entity.HasOne(d => d.Species)
                    .WithMany(p => p.SpeciesTraitMap)
                    .HasForeignKey(d => d.SpeciesId)
                    .HasConstraintName("FK_speciesTraitMap_species");

                entity.HasOne(d => d.SpeciesTrait)
                    .WithMany(p => p.SpeciesTraitMap)
                    .HasForeignKey(d => d.SpeciesTraitId)
                    .HasConstraintName("FK_speciesTraitMap_speciesTrait");
            });

            modelBuilder.Entity<StarhipManeuver>(entity =>
            {
                entity.HasKey(e => e.StarshipManeuverId);

                entity.ToTable("starhipManeuver");

                entity.Property(e => e.StarshipManeuverId).HasColumnName("starship_maneuver_id");

                entity.Property(e => e.AttackPattern).HasColumnName("attack_pattern");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.Dogfight).HasColumnName("dogfight");

                entity.Property(e => e.Force).HasColumnName("force");

                entity.Property(e => e.Gunner).HasColumnName("gunner");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Page).HasColumnName("page");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.StarhipManeuver)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_starhipManeuver_book");
            });

            modelBuilder.Entity<Talent>(entity =>
            {
                entity.ToTable("talent");

                entity.Property(e => e.TalentId).HasColumnName("talent_id");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.PageNumber).HasColumnName("page_number");

                entity.Property(e => e.TalentTreeId).HasColumnName("talent_tree_id");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Talent)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_talent_book");

                entity.HasOne(d => d.TalentTree)
                    .WithMany(p => p.Talent)
                    .HasForeignKey(d => d.TalentTreeId)
                    .HasConstraintName("FK_talent_talentTree");
            });

            modelBuilder.Entity<TalentTree>(entity =>
            {
                entity.ToTable("talentTree");

                entity.Property(e => e.TalentTreeId).HasColumnName("talent_tree_id");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.PageNumber).HasColumnName("page_number");
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.ToTable("vehicle");

                entity.Property(e => e.VehicleId).HasColumnName("vehicle_id");

                entity.Property(e => e.AdditionalEmplacements).HasColumnName("additional_emplacements");

                entity.Property(e => e.AvailabilityId).HasColumnName("availability_id");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.CargoSpace).HasColumnName("cargo_space");

                entity.Property(e => e.CarriedCraft).HasColumnName("carried_craft");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.Crew).HasColumnName("crew");

                entity.Property(e => e.DamageReduction).HasColumnName("damage_reduction");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.HitPoints).HasColumnName("hit_points");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Page).HasColumnName("page");

                entity.Property(e => e.Passengers).HasColumnName("passengers");

                entity.Property(e => e.ShieldRating).HasColumnName("shield_rating");

                entity.Property(e => e.SizeId).HasColumnName("size_id");

                entity.Property(e => e.VehicleTypeId).HasColumnName("vehicle_type_id");

                entity.HasOne(d => d.Availability)
                    .WithMany(p => p.Vehicle)
                    .HasForeignKey(d => d.AvailabilityId)
                    .HasConstraintName("FK_vehicle_availability");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Vehicle)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_vehicle_book");

                entity.HasOne(d => d.Size)
                    .WithMany(p => p.Vehicle)
                    .HasForeignKey(d => d.SizeId)
                    .HasConstraintName("FK_vehicle_size");

                entity.HasOne(d => d.VehicleType)
                    .WithMany(p => p.Vehicle)
                    .HasForeignKey(d => d.VehicleTypeId)
                    .HasConstraintName("FK_vehicle_vehicleType");
            });

            modelBuilder.Entity<VehicleAmmunition>(entity =>
            {
                entity.ToTable("vehicleAmmunition");

                entity.Property(e => e.VehicleAmmunitionId).HasColumnName("vehicle_ammunition_id");

                entity.Property(e => e.AvailabilityId).HasColumnName("availability_id");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Page).HasColumnName("page");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.VehicleAmmunition)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_vehicleAmmunition_book");
            });

            modelBuilder.Entity<VehicleSystem>(entity =>
            {
                entity.ToTable("vehicleSystem");

                entity.Property(e => e.VehicleSystemId).HasColumnName("vehicle_system_id");

                entity.Property(e => e.AvailabilityId).HasColumnName("availability_id");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.Damage)
                    .HasColumnName("damage")
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.EmplacementCost).HasColumnName("emplacement_cost");

                entity.Property(e => e.MaximumCount).HasColumnName("maximum_count");

                entity.Property(e => e.MaximumSizeId).HasColumnName("maximum_size_id");

                entity.Property(e => e.MinimumSizeId).HasColumnName("minimum_size_id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Page).HasColumnName("page");

                entity.Property(e => e.ShieldRating).HasColumnName("shield_rating");

                entity.Property(e => e.VehicleAmmunitionId).HasColumnName("vehicle_ammunition_id");

                entity.Property(e => e.VehicleWeaponRangeId).HasColumnName("vehicle_weapon_range_id");

                entity.HasOne(d => d.Availability)
                    .WithMany(p => p.VehicleSystem)
                    .HasForeignKey(d => d.AvailabilityId)
                    .HasConstraintName("FK_vehicleSystem_availability");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.VehicleSystem)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_vehicleEmplacement_book");

                entity.HasOne(d => d.MaximumSize)
                    .WithMany(p => p.VehicleSystemMaximumSize)
                    .HasForeignKey(d => d.MaximumSizeId)
                    .HasConstraintName("FK_vehicleSystem_size1");

                entity.HasOne(d => d.MinimumSize)
                    .WithMany(p => p.VehicleSystemMinimumSize)
                    .HasForeignKey(d => d.MinimumSizeId)
                    .HasConstraintName("FK_vehicleSystem_size");

                entity.HasOne(d => d.VehicleAmmunition)
                    .WithMany(p => p.VehicleSystem)
                    .HasForeignKey(d => d.VehicleAmmunitionId)
                    .HasConstraintName("FK_vehicleSystem_vehicleAmmunition");

                entity.HasOne(d => d.VehicleWeaponRange)
                    .WithMany(p => p.VehicleSystem)
                    .HasForeignKey(d => d.VehicleWeaponRangeId)
                    .HasConstraintName("FK_vehicleSystem_vehicleWeaponRange");
            });

            modelBuilder.Entity<VehicleSystemMap>(entity =>
            {
                entity.ToTable("vehicleSystemMap");

                entity.Property(e => e.VehicleSystemMapId).HasColumnName("vehicle_system_map_id");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.VehicleId).HasColumnName("vehicle_id");

                entity.Property(e => e.VehicleSystemId).HasColumnName("vehicle_system_id");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.VehicleSystemMap)
                    .HasForeignKey(d => d.VehicleId)
                    .HasConstraintName("FK_vehicleSystemMap_vehicle");

                entity.HasOne(d => d.VehicleSystem)
                    .WithMany(p => p.VehicleSystemMap)
                    .HasForeignKey(d => d.VehicleSystemId)
                    .HasConstraintName("FK_vehicleSystemMap_vehicleSystem");
            });

            modelBuilder.Entity<VehicleTemplate>(entity =>
            {
                entity.ToTable("vehicleTemplate");

                entity.Property(e => e.VehicleTemplateId).HasColumnName("vehicle_template_id");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Page).HasColumnName("page");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.VehicleTemplate)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_vehicleTemplate_book");
            });

            modelBuilder.Entity<VehicleType>(entity =>
            {
                entity.ToTable("vehicleType");

                entity.Property(e => e.VehicleTypeId).HasColumnName("vehicle_type_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VehicleWeaponRange>(entity =>
            {
                entity.HasKey(e => e.WeaponRangeId);

                entity.ToTable("vehicleWeaponRange");

                entity.Property(e => e.WeaponRangeId).HasColumnName("weapon_range_id");

                entity.Property(e => e.CharacterLong).HasColumnName("character_long");

                entity.Property(e => e.CharacterMedium).HasColumnName("character_medium");

                entity.Property(e => e.CharacterPointBlank).HasColumnName("character_point_blank");

                entity.Property(e => e.CharacterShort).HasColumnName("character_short");

                entity.Property(e => e.StarshipLong).HasColumnName("starship_long");

                entity.Property(e => e.StarshipMedium).HasColumnName("starship_medium");

                entity.Property(e => e.StarshipPointBlank).HasColumnName("starship_point_blank");

                entity.Property(e => e.StarshipShort).HasColumnName("starship_short");
            });

            modelBuilder.Entity<Weapon>(entity =>
            {
                entity.ToTable("weapon");

                entity.Property(e => e.WeaponId).HasColumnName("weapon_id");

                entity.Property(e => e.Accurate).HasColumnName("accurate");

                entity.Property(e => e.AvailabilityId).HasColumnName("availability_id");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.Damage)
                    .HasColumnName("damage")
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.FireTypeId).HasColumnName("fire_type_id");

                entity.Property(e => e.Inaccurate).HasColumnName("inaccurate");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Page).HasColumnName("page");

                entity.Property(e => e.Rare).HasColumnName("rare");

                entity.Property(e => e.SizeId).HasColumnName("size_id");

                entity.Property(e => e.StunTypeId).HasColumnName("stun_type_id");

                entity.Property(e => e.WeaponCategoryId).HasColumnName("weapon_category_id");

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.HasOne(d => d.Availability)
                    .WithMany(p => p.Weapon)
                    .HasForeignKey(d => d.AvailabilityId)
                    .HasConstraintName("FK_weapon_availability");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Weapon)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_weapon_book");

                entity.HasOne(d => d.FireType)
                    .WithMany(p => p.Weapon)
                    .HasForeignKey(d => d.FireTypeId)
                    .HasConstraintName("FK_weapon_weaponFireType");

                entity.HasOne(d => d.Size)
                    .WithMany(p => p.Weapon)
                    .HasForeignKey(d => d.SizeId)
                    .HasConstraintName("FK_weapon_size");

                entity.HasOne(d => d.StunType)
                    .WithMany(p => p.Weapon)
                    .HasForeignKey(d => d.StunTypeId)
                    .HasConstraintName("FK_weapon_weaponStunType");

                entity.HasOne(d => d.WeaponCategory)
                    .WithMany(p => p.Weapon)
                    .HasForeignKey(d => d.WeaponCategoryId)
                    .HasConstraintName("FK_weapon_weaponCategory");
            });

            modelBuilder.Entity<WeaponAmmunition>(entity =>
            {
                entity.ToTable("weaponAmmunition");

                entity.Property(e => e.WeaponAmmunitionId).HasColumnName("weapon_ammunition_id");

                entity.Property(e => e.AvailabilityId).HasColumnName("availability_id");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Page).HasColumnName("page");

                entity.Property(e => e.Weight).HasColumnName("weight");
            });

            modelBuilder.Entity<WeaponAmmunitionMap>(entity =>
            {
                entity.HasKey(e => e.WeaponAmmunitionTypeId);

                entity.ToTable("weaponAmmunitionMap");

                entity.Property(e => e.WeaponAmmunitionTypeId).HasColumnName("weapon_ammunition_type_id");

                entity.Property(e => e.Capacity).HasColumnName("capacity");

                entity.Property(e => e.WeaponAmmunitionId).HasColumnName("weapon_ammunition_id");

                entity.Property(e => e.WeaponId).HasColumnName("weapon_id");

                entity.HasOne(d => d.WeaponAmmunition)
                    .WithMany(p => p.WeaponAmmunitionMap)
                    .HasForeignKey(d => d.WeaponAmmunitionId)
                    .HasConstraintName("FK_weaponAmmunitionMap_weaponAmmunition");

                entity.HasOne(d => d.Weapon)
                    .WithMany(p => p.WeaponAmmunitionMap)
                    .HasForeignKey(d => d.WeaponId)
                    .HasConstraintName("FK_weaponAmmunitionMap_weapon");
            });

            modelBuilder.Entity<WeaponCategory>(entity =>
            {
                entity.ToTable("weaponCategory");

                entity.Property(e => e.WeaponCategoryId).HasColumnName("weapon_category_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.WeaponRangeId).HasColumnName("weapon_range_id");

                entity.HasOne(d => d.WeaponRange)
                    .WithMany(p => p.WeaponCategory)
                    .HasForeignKey(d => d.WeaponRangeId)
                    .HasConstraintName("FK_weaponCategory_weaponRange");
            });

            modelBuilder.Entity<WeaponDamageMap>(entity =>
            {
                entity.HasKey(e => e.WeaponDamageId);

                entity.ToTable("weaponDamageMap");

                entity.Property(e => e.WeaponDamageId).HasColumnName("weapon_damage_id");

                entity.Property(e => e.DamageTypeId).HasColumnName("damage_type_id");

                entity.Property(e => e.WeaponId).HasColumnName("weapon_id");

                entity.HasOne(d => d.DamageType)
                    .WithMany(p => p.WeaponDamageMap)
                    .HasForeignKey(d => d.DamageTypeId)
                    .HasConstraintName("FK_weaponDamageMap_weaponDamageType");

                entity.HasOne(d => d.Weapon)
                    .WithMany(p => p.WeaponDamageMap)
                    .HasForeignKey(d => d.WeaponId)
                    .HasConstraintName("FK_weaponDamageMap_weapon");
            });

            modelBuilder.Entity<WeaponDamageType>(entity =>
            {
                entity.HasKey(e => e.DamageTypeId);

                entity.ToTable("weaponDamageType");

                entity.Property(e => e.DamageTypeId).HasColumnName("damage_type_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<WeaponFireType>(entity =>
            {
                entity.HasKey(e => e.FireTypeId);

                entity.ToTable("weaponFireType");

                entity.Property(e => e.FireTypeId).HasColumnName("fire_type_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<WeaponRange>(entity =>
            {
                entity.ToTable("weaponRange");

                entity.Property(e => e.WeaponRangeId).HasColumnName("weapon_range_id");

                entity.Property(e => e.Long).HasColumnName("long");

                entity.Property(e => e.Medium).HasColumnName("medium");

                entity.Property(e => e.PointBlank).HasColumnName("point_blank");

                entity.Property(e => e.Short).HasColumnName("short");

                entity.Property(e => e.WeaponCategoryId).HasColumnName("weapon_category_id");
            });

            modelBuilder.Entity<WeaponStunType>(entity =>
            {
                entity.HasKey(e => e.StunTypeId);

                entity.ToTable("weaponStunType");

                entity.Property(e => e.StunTypeId).HasColumnName("stun_type_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<WeaponTemplate>(entity =>
            {
                entity.ToTable("weaponTemplate");

                entity.Property(e => e.WeaponTemplateId).HasColumnName("weapon_template_id");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.DescriptionShort)
                    .HasColumnName("description_short")
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Page).HasColumnName("page");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.WeaponTemplate)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_weaponTemplate_book");
            });
        }
    }
}
