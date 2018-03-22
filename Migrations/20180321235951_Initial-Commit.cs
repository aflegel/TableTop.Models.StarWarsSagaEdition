using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarWarsSagaEdition.Migrations
{
    public partial class InitialCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ability",
                columns: table => new
                {
                    ability_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 15, nullable: true),
                    description = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ability", x => x.ability_id);
                });

            migrationBuilder.CreateTable(
                name: "armourHelmet",
                columns: table => new
                {
                    helmet_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_armourHelmet", x => x.helmet_id);
                });

            migrationBuilder.CreateTable(
                name: "armourType",
                columns: table => new
                {
                    armour_type_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(maxLength: 50, nullable: true),
                    check_penalty = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_armourType", x => x.armour_type_id);
                });

            migrationBuilder.CreateTable(
                name: "availability",
                columns: table => new
                {
                    availability_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    licensing = table.Column<decimal>(nullable: true),
                    description = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_availability", x => x.availability_id);
                });

            migrationBuilder.CreateTable(
                name: "background",
                columns: table => new
                {
                    background_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(maxLength: 100, nullable: true),
                    book_id = table.Column<int>(nullable: true),
                    page = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_background", x => x.background_id);
                });

            migrationBuilder.CreateTable(
                name: "book",
                columns: table => new
                {
                    book_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    title = table.Column<string>(maxLength: 100, nullable: true),
                    published = table.Column<DateTime>(type: "date", nullable: true),
                    page_count = table.Column<int>(nullable: true),
                    short_title = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_book", x => x.book_id);
                });

            migrationBuilder.CreateTable(
                name: "language",
                columns: table => new
                {
                    language_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_language", x => x.language_id);
                });

            migrationBuilder.CreateTable(
                name: "level",
                columns: table => new
                {
                    level_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    challenge_level = table.Column<string>(maxLength: 50, nullable: true),
                    challenge_experience = table.Column<int>(nullable: true),
                    base_experience = table.Column<int>(nullable: true),
                    base_credits = table.Column<int>(nullable: true),
                    feat_increase = table.Column<bool>(nullable: true),
                    ability_increase = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_level", x => x.level_id);
                });

            migrationBuilder.CreateTable(
                name: "shieldTemplate",
                columns: table => new
                {
                    template_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    book_id = table.Column<int>(nullable: true),
                    page = table.Column<int>(nullable: true),
                    description = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shieldTemplate", x => x.template_id);
                });

            migrationBuilder.CreateTable(
                name: "size",
                columns: table => new
                {
                    size_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    strength_modifier = table.Column<int>(nullable: true),
                    dexterity_modifier = table.Column<int>(nullable: true),
                    description = table.Column<string>(maxLength: 100, nullable: true),
                    starship_multiplier = table.Column<int>(nullable: true),
                    droid_multiplier = table.Column<int>(nullable: true),
                    reflex_modifier = table.Column<int>(nullable: true),
                    stealth_modifier = table.Column<int>(nullable: true),
                    droid_hitpoints = table.Column<int>(nullable: true),
                    threshold_modifier = table.Column<int>(nullable: true),
                    carry_capacity_modifier = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_size", x => x.size_id);
                });

            migrationBuilder.CreateTable(
                name: "skill",
                columns: table => new
                {
                    skill_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 100, nullable: true),
                    book_id = table.Column<int>(nullable: true),
                    page_number = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_skill", x => x.skill_id);
                });

            migrationBuilder.CreateTable(
                name: "skillAction",
                columns: table => new
                {
                    skill_action_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(maxLength: 100, nullable: true),
                    book_id = table.Column<int>(nullable: true),
                    page = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_skillAction", x => x.skill_action_id);
                });

            migrationBuilder.CreateTable(
                name: "speciesBonusFeatMap",
                columns: table => new
                {
                    species_bonus_feat_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    species_id = table.Column<int>(nullable: true),
                    feat_id = table.Column<int>(nullable: true),
                    conditional = table.Column<bool>(nullable: true),
                    skill_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_speciesBonusFeatMap", x => x.species_bonus_feat_id);
                });

            migrationBuilder.CreateTable(
                name: "speciesLanguageMap",
                columns: table => new
                {
                    species_language_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    language_id = table.Column<int>(nullable: true),
                    species_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_speciesLanguageMap", x => x.species_language_id);
                });

            migrationBuilder.CreateTable(
                name: "speciesTrait",
                columns: table => new
                {
                    species_trait_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_speciesTrait", x => x.species_trait_id);
                });

            migrationBuilder.CreateTable(
                name: "talentTree",
                columns: table => new
                {
                    talent_tree_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 100, nullable: true),
                    book_id = table.Column<int>(nullable: true),
                    page_number = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_talentTree", x => x.talent_tree_id);
                });

            migrationBuilder.CreateTable(
                name: "vehicleType",
                columns: table => new
                {
                    vehicle_type_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicleType", x => x.vehicle_type_id);
                });

            migrationBuilder.CreateTable(
                name: "vehicleWeaponRange",
                columns: table => new
                {
                    weapon_range_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    character_point_blank = table.Column<int>(nullable: true),
                    character_short = table.Column<int>(nullable: true),
                    character_medium = table.Column<int>(nullable: true),
                    character_long = table.Column<int>(nullable: true),
                    starship_point_blank = table.Column<int>(nullable: true),
                    starship_short = table.Column<int>(nullable: true),
                    starship_medium = table.Column<int>(nullable: true),
                    starship_long = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicleWeaponRange", x => x.weapon_range_id);
                });

            migrationBuilder.CreateTable(
                name: "weaponAmmunition",
                columns: table => new
                {
                    weapon_ammunition_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    cost = table.Column<decimal>(nullable: true),
                    availability_id = table.Column<int>(nullable: true),
                    weight = table.Column<decimal>(nullable: true),
                    book_id = table.Column<int>(nullable: true),
                    page = table.Column<int>(nullable: true),
                    description = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_weaponAmmunition", x => x.weapon_ammunition_id);
                });

            migrationBuilder.CreateTable(
                name: "weaponDamageType",
                columns: table => new
                {
                    damage_type_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_weaponDamageType", x => x.damage_type_id);
                });

            migrationBuilder.CreateTable(
                name: "weaponFireType",
                columns: table => new
                {
                    fire_type_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_weaponFireType", x => x.fire_type_id);
                });

            migrationBuilder.CreateTable(
                name: "weaponRange",
                columns: table => new
                {
                    weapon_range_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    weapon_category_id = table.Column<int>(nullable: true),
                    point_blank = table.Column<int>(nullable: true),
                    @short = table.Column<int>(name: "short", nullable: true),
                    medium = table.Column<int>(nullable: true),
                    @long = table.Column<int>(name: "long", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_weaponRange", x => x.weapon_range_id);
                });

            migrationBuilder.CreateTable(
                name: "weaponStunType",
                columns: table => new
                {
                    stun_type_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_weaponStunType", x => x.stun_type_id);
                });

            migrationBuilder.CreateTable(
                name: "armour",
                columns: table => new
                {
                    armour_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    book_id = table.Column<int>(nullable: true),
                    page = table.Column<int>(nullable: true),
                    cost = table.Column<decimal>(nullable: true),
                    weight = table.Column<decimal>(nullable: true),
                    reflex_bonus = table.Column<int>(nullable: true),
                    fortitude_bonus = table.Column<int>(nullable: true),
                    maximum_dexterity = table.Column<int>(nullable: true),
                    availability_id = table.Column<int>(nullable: true),
                    rare = table.Column<bool>(nullable: true),
                    armour_type_id = table.Column<int>(nullable: true),
                    helmet_id = table.Column<int>(nullable: true),
                    additional_upgrade = table.Column<int>(nullable: true),
                    jetpack = table.Column<bool>(nullable: true),
                    description = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_armour", x => x.armour_id);
                    table.ForeignKey(
                        name: "FK_armour_armourType",
                        column: x => x.armour_type_id,
                        principalTable: "armourType",
                        principalColumn: "armour_type_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_armour_availability",
                        column: x => x.availability_id,
                        principalTable: "availability",
                        principalColumn: "availability_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_armour_book",
                        column: x => x.book_id,
                        principalTable: "book",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_armour_armourHelmet",
                        column: x => x.helmet_id,
                        principalTable: "armourHelmet",
                        principalColumn: "helmet_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "armourTemplate",
                columns: table => new
                {
                    armour_template_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    book_id = table.Column<int>(nullable: true),
                    page = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_armourTemplate", x => x.armour_template_id);
                    table.ForeignKey(
                        name: "FK_armourTemplate_book",
                        column: x => x.book_id,
                        principalTable: "book",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "beast",
                columns: table => new
                {
                    beast_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 100, nullable: true),
                    page = table.Column<int>(nullable: true),
                    book_id = table.Column<int>(nullable: true),
                    cost = table.Column<decimal>(nullable: true),
                    availability_id = table.Column<int>(nullable: true),
                    description = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_beast", x => x.beast_id);
                    table.ForeignKey(
                        name: "FK_beasts_availability",
                        column: x => x.availability_id,
                        principalTable: "availability",
                        principalColumn: "availability_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_beasts_book",
                        column: x => x.book_id,
                        principalTable: "book",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "class",
                columns: table => new
                {
                    class_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 100, nullable: true),
                    book_id = table.Column<int>(nullable: true),
                    page_number = table.Column<int>(nullable: true),
                    description = table.Column<string>(maxLength: 100, nullable: true),
                    prestige = table.Column<bool>(nullable: true),
                    tradition = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_class", x => x.class_id);
                    table.ForeignKey(
                        name: "FK_class_book",
                        column: x => x.book_id,
                        principalTable: "book",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "droid",
                columns: table => new
                {
                    droid_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 100, nullable: true),
                    degree = table.Column<int>(nullable: true),
                    cost = table.Column<decimal>(nullable: true),
                    availability_id = table.Column<int>(nullable: true),
                    weight = table.Column<decimal>(nullable: true),
                    book_id = table.Column<int>(nullable: true),
                    page = table.Column<int>(nullable: true),
                    description = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_droid", x => x.droid_id);
                    table.ForeignKey(
                        name: "FK_droid_availability",
                        column: x => x.availability_id,
                        principalTable: "availability",
                        principalColumn: "availability_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_droid_book",
                        column: x => x.book_id,
                        principalTable: "book",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "equipment",
                columns: table => new
                {
                    equipment_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 75, nullable: true),
                    cost = table.Column<decimal>(nullable: true),
                    weight = table.Column<decimal>(nullable: true),
                    availability_id = table.Column<int>(nullable: true),
                    book_id = table.Column<int>(nullable: true),
                    page = table.Column<int>(nullable: true),
                    description = table.Column<string>(maxLength: 100, nullable: true),
                    head_slot = table.Column<bool>(nullable: true),
                    body_slot = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_equipment", x => x.equipment_id);
                    table.ForeignKey(
                        name: "FK_equipment_availability",
                        column: x => x.availability_id,
                        principalTable: "availability",
                        principalColumn: "availability_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_equipment_book",
                        column: x => x.book_id,
                        principalTable: "book",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "equipmentCybernetic",
                columns: table => new
                {
                    equipment_cybernetic_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    cost = table.Column<decimal>(nullable: true),
                    weight = table.Column<decimal>(nullable: true),
                    availability_id = table.Column<int>(nullable: true),
                    book_id = table.Column<int>(nullable: true),
                    page = table.Column<int>(nullable: true),
                    description = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_equipmentCybernetic", x => x.equipment_cybernetic_id);
                    table.ForeignKey(
                        name: "FK_equipmentCybernetic_availability",
                        column: x => x.availability_id,
                        principalTable: "availability",
                        principalColumn: "availability_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_equipmentCybernetic_book",
                        column: x => x.book_id,
                        principalTable: "book",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "equipmentDroid",
                columns: table => new
                {
                    equipment_droid_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    cost = table.Column<decimal>(nullable: true),
                    weight = table.Column<decimal>(nullable: true),
                    book_id = table.Column<int>(nullable: true),
                    page = table.Column<int>(nullable: true),
                    detachable = table.Column<bool>(nullable: true),
                    availability_id = table.Column<int>(nullable: true),
                    description = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_equipmentDroid", x => x.equipment_droid_id);
                    table.ForeignKey(
                        name: "FK_equipmentDroid_availability",
                        column: x => x.availability_id,
                        principalTable: "availability",
                        principalColumn: "availability_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_equipmentDroid_book",
                        column: x => x.book_id,
                        principalTable: "book",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "equipmentUpgrade",
                columns: table => new
                {
                    equipment_upgrade_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    cost = table.Column<decimal>(nullable: true),
                    weight = table.Column<decimal>(nullable: true),
                    availability_id = table.Column<int>(nullable: true),
                    book_id = table.Column<int>(nullable: true),
                    page = table.Column<int>(nullable: true),
                    weapon_upgrade = table.Column<bool>(nullable: true),
                    armor_upgrade = table.Column<bool>(nullable: true),
                    upgrade_slots = table.Column<int>(nullable: true),
                    description = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_equipmentUpgrade", x => x.equipment_upgrade_id);
                    table.ForeignKey(
                        name: "FK_equipmentUpgrade_availability",
                        column: x => x.availability_id,
                        principalTable: "availability",
                        principalColumn: "availability_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_equipmentUpgrade_book",
                        column: x => x.book_id,
                        principalTable: "book",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "feat",
                columns: table => new
                {
                    feat_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 100, nullable: true),
                    book_id = table.Column<int>(nullable: true),
                    page_number = table.Column<int>(nullable: true),
                    asterix = table.Column<bool>(nullable: true),
                    combat = table.Column<bool>(nullable: true),
                    description_short = table.Column<string>(maxLength: 100, nullable: true),
                    description = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_feat", x => x.feat_id);
                    table.ForeignKey(
                        name: "FK_feat_book",
                        column: x => x.book_id,
                        principalTable: "book",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "forcePower",
                columns: table => new
                {
                    force_power_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 100, nullable: true),
                    book_id = table.Column<int>(nullable: true),
                    page = table.Column<int>(nullable: true),
                    light_side = table.Column<bool>(nullable: true),
                    dark_side = table.Column<bool>(nullable: true),
                    lightsaber_form = table.Column<bool>(nullable: true),
                    telekenetic = table.Column<bool>(nullable: true),
                    mind_affecting = table.Column<bool>(nullable: true),
                    description = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_forcePower", x => x.force_power_id);
                    table.ForeignKey(
                        name: "FK_forcePower_book",
                        column: x => x.book_id,
                        principalTable: "book",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "forceSecret",
                columns: table => new
                {
                    force_secret_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 100, nullable: true),
                    book_id = table.Column<int>(nullable: true),
                    page = table.Column<int>(nullable: true),
                    description = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_forceSecret", x => x.force_secret_id);
                    table.ForeignKey(
                        name: "FK_forceSecret_book",
                        column: x => x.book_id,
                        principalTable: "book",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "forceTechnique",
                columns: table => new
                {
                    force_technique_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 100, nullable: true),
                    book_id = table.Column<int>(nullable: true),
                    page = table.Column<int>(nullable: true),
                    description = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_forceTechnique", x => x.force_technique_id);
                    table.ForeignKey(
                        name: "FK_forceTechnique_book",
                        column: x => x.book_id,
                        principalTable: "book",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "index",
                columns: table => new
                {
                    index_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 100, nullable: true),
                    book_id = table.Column<int>(nullable: true),
                    page = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_index", x => x.index_id);
                    table.ForeignKey(
                        name: "FK_index_book",
                        column: x => x.book_id,
                        principalTable: "book",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "medicalSecret",
                columns: table => new
                {
                    medical_secret_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    book_id = table.Column<int>(nullable: true),
                    page = table.Column<int>(nullable: true),
                    description = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicalSecret", x => x.medical_secret_id);
                    table.ForeignKey(
                        name: "FK_medicalSecret_book",
                        column: x => x.book_id,
                        principalTable: "book",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "planet",
                columns: table => new
                {
                    planet_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 100, nullable: true),
                    book_id = table.Column<int>(nullable: true),
                    page = table.Column<int>(nullable: true),
                    description = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_planet", x => x.planet_id);
                    table.ForeignKey(
                        name: "FK_planet_book",
                        column: x => x.book_id,
                        principalTable: "book",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "species",
                columns: table => new
                {
                    species_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 100, nullable: true),
                    strength_modifier = table.Column<int>(nullable: true),
                    dexterity_modifier = table.Column<int>(nullable: true),
                    constitution_modifier = table.Column<int>(nullable: true),
                    intelligence_modifier = table.Column<int>(nullable: true),
                    wisdom_modifier = table.Column<int>(nullable: true),
                    charisma_modifier = table.Column<int>(nullable: true),
                    book_id = table.Column<int>(nullable: true),
                    page = table.Column<int>(nullable: true),
                    size_id = table.Column<int>(nullable: true),
                    base_speed = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_species", x => x.species_id);
                    table.ForeignKey(
                        name: "FK_species_book",
                        column: x => x.book_id,
                        principalTable: "book",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "starhipManeuver",
                columns: table => new
                {
                    starship_maneuver_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    book_id = table.Column<int>(nullable: true),
                    page = table.Column<int>(nullable: true),
                    attack_pattern = table.Column<bool>(nullable: true),
                    gunner = table.Column<bool>(nullable: true),
                    dogfight = table.Column<bool>(nullable: true),
                    force = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_starhipManeuver", x => x.starship_maneuver_id);
                    table.ForeignKey(
                        name: "FK_starhipManeuver_book",
                        column: x => x.book_id,
                        principalTable: "book",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "vehicleAmmunition",
                columns: table => new
                {
                    vehicle_ammunition_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    cost = table.Column<decimal>(nullable: true),
                    availability_id = table.Column<int>(nullable: true),
                    book_id = table.Column<int>(nullable: true),
                    page = table.Column<int>(nullable: true),
                    description = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicleAmmunition", x => x.vehicle_ammunition_id);
                    table.ForeignKey(
                        name: "FK_vehicleAmmunition_book",
                        column: x => x.book_id,
                        principalTable: "book",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "vehicleTemplate",
                columns: table => new
                {
                    vehicle_template_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    book_id = table.Column<int>(nullable: true),
                    page = table.Column<int>(nullable: true),
                    description = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicleTemplate", x => x.vehicle_template_id);
                    table.ForeignKey(
                        name: "FK_vehicleTemplate_book",
                        column: x => x.book_id,
                        principalTable: "book",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "weaponTemplate",
                columns: table => new
                {
                    weapon_template_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    cost = table.Column<decimal>(nullable: true),
                    book_id = table.Column<int>(nullable: true),
                    page = table.Column<int>(nullable: true),
                    description = table.Column<string>(maxLength: 100, nullable: true),
                    description_short = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_weaponTemplate", x => x.weapon_template_id);
                    table.ForeignKey(
                        name: "FK_weaponTemplate_book",
                        column: x => x.book_id,
                        principalTable: "book",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "talent",
                columns: table => new
                {
                    talent_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 100, nullable: true),
                    talent_tree_id = table.Column<int>(nullable: true),
                    book_id = table.Column<int>(nullable: true),
                    page_number = table.Column<int>(nullable: true),
                    description = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_talent", x => x.talent_id);
                    table.ForeignKey(
                        name: "FK_talent_book",
                        column: x => x.book_id,
                        principalTable: "book",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_talent_talentTree",
                        column: x => x.talent_tree_id,
                        principalTable: "talentTree",
                        principalColumn: "talent_tree_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "vehicle",
                columns: table => new
                {
                    vehicle_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    vehicle_type_id = table.Column<int>(nullable: true),
                    name = table.Column<string>(maxLength: 100, nullable: true),
                    size_id = table.Column<int>(nullable: true),
                    cost = table.Column<decimal>(nullable: true),
                    availability_id = table.Column<int>(nullable: true),
                    hit_points = table.Column<int>(nullable: true),
                    shield_rating = table.Column<int>(nullable: true),
                    damage_reduction = table.Column<int>(nullable: true),
                    cargo_space = table.Column<int>(nullable: true),
                    crew = table.Column<int>(nullable: true),
                    passengers = table.Column<int>(nullable: true),
                    carried_craft = table.Column<bool>(nullable: true),
                    additional_emplacements = table.Column<int>(nullable: true),
                    book_id = table.Column<int>(nullable: true),
                    page = table.Column<int>(nullable: true),
                    description = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicle", x => x.vehicle_id);
                    table.ForeignKey(
                        name: "FK_vehicle_availability",
                        column: x => x.availability_id,
                        principalTable: "availability",
                        principalColumn: "availability_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_vehicle_book",
                        column: x => x.book_id,
                        principalTable: "book",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_vehicle_size",
                        column: x => x.size_id,
                        principalTable: "size",
                        principalColumn: "size_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_vehicle_vehicleType",
                        column: x => x.vehicle_type_id,
                        principalTable: "vehicleType",
                        principalColumn: "vehicle_type_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "weaponCategory",
                columns: table => new
                {
                    weapon_category_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(maxLength: 100, nullable: true),
                    weapon_range_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_weaponCategory", x => x.weapon_category_id);
                    table.ForeignKey(
                        name: "FK_weaponCategory_weaponRange",
                        column: x => x.weapon_range_id,
                        principalTable: "weaponRange",
                        principalColumn: "weapon_range_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "classPrestigeSpecial",
                columns: table => new
                {
                    class_prestige_special_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    class_id = table.Column<int>(nullable: true),
                    book_id = table.Column<int>(nullable: true),
                    page = table.Column<int>(nullable: true),
                    description = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_classPrestigeSpecial", x => x.class_prestige_special_id);
                    table.ForeignKey(
                        name: "FK_classPrestigeSpecial_book",
                        column: x => x.book_id,
                        principalTable: "book",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_classPrestigeSpecial_class",
                        column: x => x.class_id,
                        principalTable: "class",
                        principalColumn: "class_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "classSkillMap",
                columns: table => new
                {
                    class_skill_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    class_id = table.Column<int>(nullable: true),
                    skill_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_classSkillMap", x => x.class_skill_id);
                    table.ForeignKey(
                        name: "FK_classSkill_class",
                        column: x => x.class_id,
                        principalTable: "class",
                        principalColumn: "class_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_classSkill_skill",
                        column: x => x.skill_id,
                        principalTable: "skill",
                        principalColumn: "skill_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "classTalentTreeMap",
                columns: table => new
                {
                    class_tree_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    class_id = table.Column<int>(nullable: true),
                    talent_tree_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_classTalentTreeMap", x => x.class_tree_id);
                    table.ForeignKey(
                        name: "FK_classTalentTree_class",
                        column: x => x.class_id,
                        principalTable: "class",
                        principalColumn: "class_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_classTalentTree_talentTree",
                        column: x => x.talent_tree_id,
                        principalTable: "talentTree",
                        principalColumn: "talent_tree_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "droidSystem",
                columns: table => new
                {
                    droid_system_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    droid_id = table.Column<int>(nullable: false),
                    equipment_droid_id = table.Column<int>(nullable: false),
                    quantity = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_droidSystem", x => x.droid_system_id);
                    table.ForeignKey(
                        name: "FK_droidSystem_droid",
                        column: x => x.droid_id,
                        principalTable: "droid",
                        principalColumn: "droid_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_droidSystem_equipmentDroid",
                        column: x => x.equipment_droid_id,
                        principalTable: "equipmentDroid",
                        principalColumn: "equipment_droid_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "classBonusFeatMap",
                columns: table => new
                {
                    bonus_feat_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    class_id = table.Column<int>(nullable: true),
                    feat_id = table.Column<int>(nullable: true),
                    book_id = table.Column<int>(nullable: true),
                    page_number = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_classBonusFeatMap", x => x.bonus_feat_id);
                    table.ForeignKey(
                        name: "FK_classBonusFeat_book",
                        column: x => x.book_id,
                        principalTable: "book",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_classBonusFeat_class",
                        column: x => x.class_id,
                        principalTable: "class",
                        principalColumn: "class_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_classBonusFeat_feat",
                        column: x => x.feat_id,
                        principalTable: "feat",
                        principalColumn: "feat_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "character",
                columns: table => new
                {
                    character_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 100, nullable: false),
                    page = table.Column<int>(nullable: true),
                    book_id = table.Column<int>(nullable: true),
                    species_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_character", x => x.character_id);
                    table.ForeignKey(
                        name: "FK_characters_book",
                        column: x => x.book_id,
                        principalTable: "book",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_characters_species",
                        column: x => x.species_id,
                        principalTable: "species",
                        principalColumn: "species_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "speciesTraitMap",
                columns: table => new
                {
                    species_trait_map_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    species_trait_id = table.Column<int>(nullable: true),
                    species_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_speciesTraitMap", x => x.species_trait_map_id);
                    table.ForeignKey(
                        name: "FK_speciesTraitMap_species",
                        column: x => x.species_id,
                        principalTable: "species",
                        principalColumn: "species_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_speciesTraitMap_speciesTrait",
                        column: x => x.species_trait_id,
                        principalTable: "speciesTrait",
                        principalColumn: "species_trait_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "vehicleSystem",
                columns: table => new
                {
                    vehicle_system_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    cost = table.Column<decimal>(nullable: true),
                    availability_id = table.Column<int>(nullable: true),
                    emplacement_cost = table.Column<int>(nullable: true),
                    book_id = table.Column<int>(nullable: true),
                    page = table.Column<int>(nullable: true),
                    description = table.Column<string>(maxLength: 100, nullable: true),
                    damage = table.Column<string>(maxLength: 50, nullable: true),
                    vehicle_ammunition_id = table.Column<int>(nullable: true),
                    vehicle_weapon_range_id = table.Column<int>(nullable: true),
                    shield_rating = table.Column<int>(nullable: true),
                    minimum_size_id = table.Column<int>(nullable: true),
                    maximum_size_id = table.Column<int>(nullable: true),
                    maximum_count = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicleSystem", x => x.vehicle_system_id);
                    table.ForeignKey(
                        name: "FK_vehicleSystem_availability",
                        column: x => x.availability_id,
                        principalTable: "availability",
                        principalColumn: "availability_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_vehicleEmplacement_book",
                        column: x => x.book_id,
                        principalTable: "book",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_vehicleSystem_size1",
                        column: x => x.maximum_size_id,
                        principalTable: "size",
                        principalColumn: "size_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_vehicleSystem_size",
                        column: x => x.minimum_size_id,
                        principalTable: "size",
                        principalColumn: "size_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_vehicleSystem_vehicleAmmunition",
                        column: x => x.vehicle_ammunition_id,
                        principalTable: "vehicleAmmunition",
                        principalColumn: "vehicle_ammunition_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_vehicleSystem_vehicleWeaponRange",
                        column: x => x.vehicle_weapon_range_id,
                        principalTable: "vehicleWeaponRange",
                        principalColumn: "weapon_range_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "prerequisiteAbility",
                columns: table => new
                {
                    prerequisite_ability_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    required_ability_id = table.Column<int>(nullable: false),
                    required_score = table.Column<int>(nullable: true),
                    class_id = table.Column<int>(nullable: true),
                    feat_id = table.Column<int>(nullable: true),
                    talent_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prerequisiteAbility", x => x.prerequisite_ability_id);
                    table.ForeignKey(
                        name: "FK_prerequisiteAbility_class",
                        column: x => x.class_id,
                        principalTable: "class",
                        principalColumn: "class_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prerequisiteAbility_feat",
                        column: x => x.feat_id,
                        principalTable: "feat",
                        principalColumn: "feat_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prerequisiteAbility_ability",
                        column: x => x.required_ability_id,
                        principalTable: "ability",
                        principalColumn: "ability_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prerequisiteAbility_talent",
                        column: x => x.talent_id,
                        principalTable: "talent",
                        principalColumn: "talent_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "prerequisiteFeat",
                columns: table => new
                {
                    prerequisite_feat_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    required_feat_id = table.Column<int>(nullable: false),
                    class_id = table.Column<int>(nullable: true),
                    feat_id = table.Column<int>(nullable: true),
                    talent_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prerequisiteFeat", x => x.prerequisite_feat_id);
                    table.ForeignKey(
                        name: "FK_prerequisiteFeat_class",
                        column: x => x.class_id,
                        principalTable: "class",
                        principalColumn: "class_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prerequisiteFeat_feat",
                        column: x => x.feat_id,
                        principalTable: "feat",
                        principalColumn: "feat_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prerequisiteFeat_feat_required",
                        column: x => x.required_feat_id,
                        principalTable: "feat",
                        principalColumn: "feat_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prerequisiteFeat_talent",
                        column: x => x.talent_id,
                        principalTable: "talent",
                        principalColumn: "talent_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "prerequisiteLevel",
                columns: table => new
                {
                    prerequisite_level_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    required_level_id = table.Column<int>(nullable: false),
                    base_attack = table.Column<bool>(nullable: false),
                    dark_side_score = table.Column<bool>(nullable: false),
                    class_id = table.Column<int>(nullable: true),
                    feat_id = table.Column<int>(nullable: true),
                    talent_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prerequisiteLevel", x => x.prerequisite_level_id);
                    table.ForeignKey(
                        name: "FK_prerequisiteLevel_class",
                        column: x => x.class_id,
                        principalTable: "class",
                        principalColumn: "class_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prerequisiteLevel_feat",
                        column: x => x.feat_id,
                        principalTable: "feat",
                        principalColumn: "feat_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prerequisiteLevel_level",
                        column: x => x.required_level_id,
                        principalTable: "level",
                        principalColumn: "level_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prerequisiteLevel_talent",
                        column: x => x.talent_id,
                        principalTable: "talent",
                        principalColumn: "talent_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "prerequisiteSize",
                columns: table => new
                {
                    prerequisite_size_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    required_side_id = table.Column<int>(nullable: false),
                    class_id = table.Column<int>(nullable: true),
                    feat_id = table.Column<int>(nullable: true),
                    talent_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prerequisiteSize", x => x.prerequisite_size_id);
                    table.ForeignKey(
                        name: "FK_prerequisiteSize_class",
                        column: x => x.class_id,
                        principalTable: "class",
                        principalColumn: "class_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prerequisiteSize_feat",
                        column: x => x.feat_id,
                        principalTable: "feat",
                        principalColumn: "feat_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prerequisiteSize_size",
                        column: x => x.required_side_id,
                        principalTable: "size",
                        principalColumn: "size_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prerequisiteSize_talent",
                        column: x => x.talent_id,
                        principalTable: "talent",
                        principalColumn: "talent_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "prerequisiteSkill",
                columns: table => new
                {
                    prerequisite_skill_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    required_skill_id = table.Column<int>(nullable: false),
                    class_id = table.Column<int>(nullable: true),
                    feat_id = table.Column<int>(nullable: true),
                    talent_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prerequisiteSkill", x => x.prerequisite_skill_id);
                    table.ForeignKey(
                        name: "FK_prerequisiteSkill_class",
                        column: x => x.class_id,
                        principalTable: "class",
                        principalColumn: "class_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prerequisiteSkill_feat",
                        column: x => x.feat_id,
                        principalTable: "feat",
                        principalColumn: "feat_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prerequisiteSkill_skill",
                        column: x => x.required_skill_id,
                        principalTable: "skill",
                        principalColumn: "skill_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prerequisiteSkill_talent",
                        column: x => x.talent_id,
                        principalTable: "talent",
                        principalColumn: "talent_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "prerequisiteSpecies",
                columns: table => new
                {
                    prerequisite_species_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    required_species_id = table.Column<int>(nullable: false),
                    class_id = table.Column<int>(nullable: true),
                    feat_id = table.Column<int>(nullable: true),
                    talent_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prerequisiteSpecies", x => x.prerequisite_species_id);
                    table.ForeignKey(
                        name: "FK_prerequisiteSpecies_class",
                        column: x => x.class_id,
                        principalTable: "class",
                        principalColumn: "class_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prerequisiteSpecies_feat",
                        column: x => x.feat_id,
                        principalTable: "feat",
                        principalColumn: "feat_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prerequisiteSpecies_species",
                        column: x => x.required_species_id,
                        principalTable: "species",
                        principalColumn: "species_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prerequisiteSpecies_talent",
                        column: x => x.talent_id,
                        principalTable: "talent",
                        principalColumn: "talent_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "prerequisiteSpeciesTrait",
                columns: table => new
                {
                    prerequisite_trait_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    required_trait_id = table.Column<int>(nullable: false),
                    class_id = table.Column<int>(nullable: true),
                    feat_id = table.Column<int>(nullable: true),
                    talent_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prerequisiteSpeciesTrait", x => x.prerequisite_trait_id);
                    table.ForeignKey(
                        name: "FK_prerequisiteSpeciesTrait_class",
                        column: x => x.class_id,
                        principalTable: "class",
                        principalColumn: "class_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prerequisiteSpeciesTrait_feat",
                        column: x => x.feat_id,
                        principalTable: "feat",
                        principalColumn: "feat_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prerequisiteSpeciesTrait_speciesTrait",
                        column: x => x.required_trait_id,
                        principalTable: "speciesTrait",
                        principalColumn: "species_trait_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prerequisiteSpeciesTrait_talent",
                        column: x => x.talent_id,
                        principalTable: "talent",
                        principalColumn: "talent_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "prerequisiteTalent",
                columns: table => new
                {
                    prerequisite_talent_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    required_talent_id = table.Column<int>(nullable: false),
                    class_id = table.Column<int>(nullable: true),
                    feat_id = table.Column<int>(nullable: true),
                    talent_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prerequisiteTalent", x => x.prerequisite_talent_id);
                    table.ForeignKey(
                        name: "FK_prerequisiteTalent_class",
                        column: x => x.class_id,
                        principalTable: "class",
                        principalColumn: "class_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prerequisiteTalent_feat",
                        column: x => x.feat_id,
                        principalTable: "feat",
                        principalColumn: "feat_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prerequisiteTalent_talent_required",
                        column: x => x.required_talent_id,
                        principalTable: "talent",
                        principalColumn: "talent_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prerequisiteTalent_talent",
                        column: x => x.talent_id,
                        principalTable: "talent",
                        principalColumn: "talent_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "prerequisiteTalentTree",
                columns: table => new
                {
                    prerequisite_tree_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    required_tree_id = table.Column<int>(nullable: false),
                    class_id = table.Column<int>(nullable: true),
                    feat_id = table.Column<int>(nullable: true),
                    talent_id = table.Column<int>(nullable: true),
                    talent_count = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prerequisiteTalentTree", x => x.prerequisite_tree_id);
                    table.ForeignKey(
                        name: "FK_prerequisiteTalentTree_class",
                        column: x => x.class_id,
                        principalTable: "class",
                        principalColumn: "class_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prerequisiteTalentTree_feat",
                        column: x => x.feat_id,
                        principalTable: "feat",
                        principalColumn: "feat_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prerequisiteTalentTree_talentTree",
                        column: x => x.required_tree_id,
                        principalTable: "talentTree",
                        principalColumn: "talent_tree_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prerequisiteTalentTree_talent",
                        column: x => x.talent_id,
                        principalTable: "talent",
                        principalColumn: "talent_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "weapon",
                columns: table => new
                {
                    weapon_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 100, nullable: true),
                    book_id = table.Column<int>(nullable: true),
                    page = table.Column<int>(nullable: true),
                    weapon_category_id = table.Column<int>(nullable: true),
                    availability_id = table.Column<int>(nullable: true),
                    rare = table.Column<bool>(nullable: true),
                    size_id = table.Column<int>(nullable: true),
                    cost = table.Column<decimal>(nullable: true),
                    weight = table.Column<decimal>(nullable: true),
                    damage = table.Column<string>(maxLength: 50, nullable: true),
                    stun_type_id = table.Column<int>(nullable: true),
                    fire_type_id = table.Column<int>(nullable: true),
                    accurate = table.Column<bool>(nullable: true),
                    inaccurate = table.Column<bool>(nullable: true),
                    description = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_weapon", x => x.weapon_id);
                    table.ForeignKey(
                        name: "FK_weapon_availability",
                        column: x => x.availability_id,
                        principalTable: "availability",
                        principalColumn: "availability_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_weapon_book",
                        column: x => x.book_id,
                        principalTable: "book",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_weapon_weaponFireType",
                        column: x => x.fire_type_id,
                        principalTable: "weaponFireType",
                        principalColumn: "fire_type_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_weapon_size",
                        column: x => x.size_id,
                        principalTable: "size",
                        principalColumn: "size_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_weapon_weaponStunType",
                        column: x => x.stun_type_id,
                        principalTable: "weaponStunType",
                        principalColumn: "stun_type_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_weapon_weaponCategory",
                        column: x => x.weapon_category_id,
                        principalTable: "weaponCategory",
                        principalColumn: "weapon_category_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "vehicleSystemMap",
                columns: table => new
                {
                    vehicle_system_map_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    vehicle_id = table.Column<int>(nullable: true),
                    vehicle_system_id = table.Column<int>(nullable: true),
                    count = table.Column<int>(nullable: true),
                    description = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicleSystemMap", x => x.vehicle_system_map_id);
                    table.ForeignKey(
                        name: "FK_vehicleSystemMap_vehicle",
                        column: x => x.vehicle_id,
                        principalTable: "vehicle",
                        principalColumn: "vehicle_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_vehicleSystemMap_vehicleSystem",
                        column: x => x.vehicle_system_id,
                        principalTable: "vehicleSystem",
                        principalColumn: "vehicle_system_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "weaponAmmunitionMap",
                columns: table => new
                {
                    weapon_ammunition_type_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    weapon_id = table.Column<int>(nullable: true),
                    weapon_ammunition_id = table.Column<int>(nullable: true),
                    capacity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_weaponAmmunitionMap", x => x.weapon_ammunition_type_id);
                    table.ForeignKey(
                        name: "FK_weaponAmmunitionMap_weaponAmmunition",
                        column: x => x.weapon_ammunition_id,
                        principalTable: "weaponAmmunition",
                        principalColumn: "weapon_ammunition_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_weaponAmmunitionMap_weapon",
                        column: x => x.weapon_id,
                        principalTable: "weapon",
                        principalColumn: "weapon_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "weaponDamageMap",
                columns: table => new
                {
                    weapon_damage_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    weapon_id = table.Column<int>(nullable: true),
                    damage_type_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_weaponDamageMap", x => x.weapon_damage_id);
                    table.ForeignKey(
                        name: "FK_weaponDamageMap_weaponDamageType",
                        column: x => x.damage_type_id,
                        principalTable: "weaponDamageType",
                        principalColumn: "damage_type_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_weaponDamageMap_weapon",
                        column: x => x.weapon_id,
                        principalTable: "weapon",
                        principalColumn: "weapon_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_armour_armour_type_id",
                table: "armour",
                column: "armour_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_armour_availability_id",
                table: "armour",
                column: "availability_id");

            migrationBuilder.CreateIndex(
                name: "IX_armour_book_id",
                table: "armour",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_armour_helmet_id",
                table: "armour",
                column: "helmet_id");

            migrationBuilder.CreateIndex(
                name: "IX_armourTemplate_book_id",
                table: "armourTemplate",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_beast_availability_id",
                table: "beast",
                column: "availability_id");

            migrationBuilder.CreateIndex(
                name: "IX_beast_book_id",
                table: "beast",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_character_book_id",
                table: "character",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_character_species_id",
                table: "character",
                column: "species_id");

            migrationBuilder.CreateIndex(
                name: "IX_class_book_id",
                table: "class",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_classBonusFeatMap_book_id",
                table: "classBonusFeatMap",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_classBonusFeatMap_class_id",
                table: "classBonusFeatMap",
                column: "class_id");

            migrationBuilder.CreateIndex(
                name: "IX_classBonusFeatMap_feat_id",
                table: "classBonusFeatMap",
                column: "feat_id");

            migrationBuilder.CreateIndex(
                name: "IX_classPrestigeSpecial_book_id",
                table: "classPrestigeSpecial",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_classPrestigeSpecial_class_id",
                table: "classPrestigeSpecial",
                column: "class_id");

            migrationBuilder.CreateIndex(
                name: "IX_classSkillMap_class_id",
                table: "classSkillMap",
                column: "class_id");

            migrationBuilder.CreateIndex(
                name: "IX_classSkillMap_skill_id",
                table: "classSkillMap",
                column: "skill_id");

            migrationBuilder.CreateIndex(
                name: "IX_classTalentTreeMap_class_id",
                table: "classTalentTreeMap",
                column: "class_id");

            migrationBuilder.CreateIndex(
                name: "IX_classTalentTreeMap_talent_tree_id",
                table: "classTalentTreeMap",
                column: "talent_tree_id");

            migrationBuilder.CreateIndex(
                name: "IX_droid_availability_id",
                table: "droid",
                column: "availability_id");

            migrationBuilder.CreateIndex(
                name: "IX_droid_book_id",
                table: "droid",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_droidSystem_droid_id",
                table: "droidSystem",
                column: "droid_id");

            migrationBuilder.CreateIndex(
                name: "IX_droidSystem_equipment_droid_id",
                table: "droidSystem",
                column: "equipment_droid_id");

            migrationBuilder.CreateIndex(
                name: "IX_equipment_availability_id",
                table: "equipment",
                column: "availability_id");

            migrationBuilder.CreateIndex(
                name: "IX_equipment_book_id",
                table: "equipment",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_equipmentCybernetic_availability_id",
                table: "equipmentCybernetic",
                column: "availability_id");

            migrationBuilder.CreateIndex(
                name: "IX_equipmentCybernetic_book_id",
                table: "equipmentCybernetic",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_equipmentDroid_availability_id",
                table: "equipmentDroid",
                column: "availability_id");

            migrationBuilder.CreateIndex(
                name: "IX_equipmentDroid_book_id",
                table: "equipmentDroid",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_equipmentUpgrade_availability_id",
                table: "equipmentUpgrade",
                column: "availability_id");

            migrationBuilder.CreateIndex(
                name: "IX_equipmentUpgrade_book_id",
                table: "equipmentUpgrade",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_feat_book_id",
                table: "feat",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_forcePower_book_id",
                table: "forcePower",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_forceSecret_book_id",
                table: "forceSecret",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_forceTechnique_book_id",
                table: "forceTechnique",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_index_book_id",
                table: "index",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_medicalSecret_book_id",
                table: "medicalSecret",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_planet_book_id",
                table: "planet",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_prerequisiteAbility_class_id",
                table: "prerequisiteAbility",
                column: "class_id");

            migrationBuilder.CreateIndex(
                name: "IX_prerequisiteAbility_feat_id",
                table: "prerequisiteAbility",
                column: "feat_id");

            migrationBuilder.CreateIndex(
                name: "IX_prerequisiteAbility_required_ability_id",
                table: "prerequisiteAbility",
                column: "required_ability_id");

            migrationBuilder.CreateIndex(
                name: "IX_prerequisiteAbility_talent_id",
                table: "prerequisiteAbility",
                column: "talent_id");

            migrationBuilder.CreateIndex(
                name: "IX_prerequisiteFeat_class_id",
                table: "prerequisiteFeat",
                column: "class_id");

            migrationBuilder.CreateIndex(
                name: "IX_prerequisiteFeat_feat_id",
                table: "prerequisiteFeat",
                column: "feat_id");

            migrationBuilder.CreateIndex(
                name: "IX_prerequisiteFeat_required_feat_id",
                table: "prerequisiteFeat",
                column: "required_feat_id");

            migrationBuilder.CreateIndex(
                name: "IX_prerequisiteFeat_talent_id",
                table: "prerequisiteFeat",
                column: "talent_id");

            migrationBuilder.CreateIndex(
                name: "IX_prerequisiteLevel_class_id",
                table: "prerequisiteLevel",
                column: "class_id");

            migrationBuilder.CreateIndex(
                name: "IX_prerequisiteLevel_feat_id",
                table: "prerequisiteLevel",
                column: "feat_id");

            migrationBuilder.CreateIndex(
                name: "IX_prerequisiteLevel_required_level_id",
                table: "prerequisiteLevel",
                column: "required_level_id");

            migrationBuilder.CreateIndex(
                name: "IX_prerequisiteLevel_talent_id",
                table: "prerequisiteLevel",
                column: "talent_id");

            migrationBuilder.CreateIndex(
                name: "IX_prerequisiteSize_class_id",
                table: "prerequisiteSize",
                column: "class_id");

            migrationBuilder.CreateIndex(
                name: "IX_prerequisiteSize_feat_id",
                table: "prerequisiteSize",
                column: "feat_id");

            migrationBuilder.CreateIndex(
                name: "IX_prerequisiteSize_required_side_id",
                table: "prerequisiteSize",
                column: "required_side_id");

            migrationBuilder.CreateIndex(
                name: "IX_prerequisiteSize_talent_id",
                table: "prerequisiteSize",
                column: "talent_id");

            migrationBuilder.CreateIndex(
                name: "IX_prerequisiteSkill_class_id",
                table: "prerequisiteSkill",
                column: "class_id");

            migrationBuilder.CreateIndex(
                name: "IX_prerequisiteSkill_feat_id",
                table: "prerequisiteSkill",
                column: "feat_id");

            migrationBuilder.CreateIndex(
                name: "IX_prerequisiteSkill_required_skill_id",
                table: "prerequisiteSkill",
                column: "required_skill_id");

            migrationBuilder.CreateIndex(
                name: "IX_prerequisiteSkill_talent_id",
                table: "prerequisiteSkill",
                column: "talent_id");

            migrationBuilder.CreateIndex(
                name: "IX_prerequisiteSpecies_class_id",
                table: "prerequisiteSpecies",
                column: "class_id");

            migrationBuilder.CreateIndex(
                name: "IX_prerequisiteSpecies_feat_id",
                table: "prerequisiteSpecies",
                column: "feat_id");

            migrationBuilder.CreateIndex(
                name: "IX_prerequisiteSpecies_required_species_id",
                table: "prerequisiteSpecies",
                column: "required_species_id");

            migrationBuilder.CreateIndex(
                name: "IX_prerequisiteSpecies_talent_id",
                table: "prerequisiteSpecies",
                column: "talent_id");

            migrationBuilder.CreateIndex(
                name: "IX_prerequisiteSpeciesTrait_class_id",
                table: "prerequisiteSpeciesTrait",
                column: "class_id");

            migrationBuilder.CreateIndex(
                name: "IX_prerequisiteSpeciesTrait_feat_id",
                table: "prerequisiteSpeciesTrait",
                column: "feat_id");

            migrationBuilder.CreateIndex(
                name: "IX_prerequisiteSpeciesTrait_required_trait_id",
                table: "prerequisiteSpeciesTrait",
                column: "required_trait_id");

            migrationBuilder.CreateIndex(
                name: "IX_prerequisiteSpeciesTrait_talent_id",
                table: "prerequisiteSpeciesTrait",
                column: "talent_id");

            migrationBuilder.CreateIndex(
                name: "IX_prerequisiteTalent_class_id",
                table: "prerequisiteTalent",
                column: "class_id");

            migrationBuilder.CreateIndex(
                name: "IX_prerequisiteTalent_feat_id",
                table: "prerequisiteTalent",
                column: "feat_id");

            migrationBuilder.CreateIndex(
                name: "IX_prerequisiteTalent_required_talent_id",
                table: "prerequisiteTalent",
                column: "required_talent_id");

            migrationBuilder.CreateIndex(
                name: "IX_prerequisiteTalent_talent_id",
                table: "prerequisiteTalent",
                column: "talent_id");

            migrationBuilder.CreateIndex(
                name: "IX_prerequisiteTalentTree_class_id",
                table: "prerequisiteTalentTree",
                column: "class_id");

            migrationBuilder.CreateIndex(
                name: "IX_prerequisiteTalentTree_feat_id",
                table: "prerequisiteTalentTree",
                column: "feat_id");

            migrationBuilder.CreateIndex(
                name: "IX_prerequisiteTalentTree_required_tree_id",
                table: "prerequisiteTalentTree",
                column: "required_tree_id");

            migrationBuilder.CreateIndex(
                name: "IX_prerequisiteTalentTree_talent_id",
                table: "prerequisiteTalentTree",
                column: "talent_id");

            migrationBuilder.CreateIndex(
                name: "IX_species_book_id",
                table: "species",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_speciesTraitMap_species_id",
                table: "speciesTraitMap",
                column: "species_id");

            migrationBuilder.CreateIndex(
                name: "IX_speciesTraitMap_species_trait_id",
                table: "speciesTraitMap",
                column: "species_trait_id");

            migrationBuilder.CreateIndex(
                name: "IX_starhipManeuver_book_id",
                table: "starhipManeuver",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_talent_book_id",
                table: "talent",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_talent_talent_tree_id",
                table: "talent",
                column: "talent_tree_id");

            migrationBuilder.CreateIndex(
                name: "IX_vehicle_availability_id",
                table: "vehicle",
                column: "availability_id");

            migrationBuilder.CreateIndex(
                name: "IX_vehicle_book_id",
                table: "vehicle",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_vehicle_size_id",
                table: "vehicle",
                column: "size_id");

            migrationBuilder.CreateIndex(
                name: "IX_vehicle_vehicle_type_id",
                table: "vehicle",
                column: "vehicle_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_vehicleAmmunition_book_id",
                table: "vehicleAmmunition",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_vehicleSystem_availability_id",
                table: "vehicleSystem",
                column: "availability_id");

            migrationBuilder.CreateIndex(
                name: "IX_vehicleSystem_book_id",
                table: "vehicleSystem",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_vehicleSystem_maximum_size_id",
                table: "vehicleSystem",
                column: "maximum_size_id");

            migrationBuilder.CreateIndex(
                name: "IX_vehicleSystem_minimum_size_id",
                table: "vehicleSystem",
                column: "minimum_size_id");

            migrationBuilder.CreateIndex(
                name: "IX_vehicleSystem_vehicle_ammunition_id",
                table: "vehicleSystem",
                column: "vehicle_ammunition_id");

            migrationBuilder.CreateIndex(
                name: "IX_vehicleSystem_vehicle_weapon_range_id",
                table: "vehicleSystem",
                column: "vehicle_weapon_range_id");

            migrationBuilder.CreateIndex(
                name: "IX_vehicleSystemMap_vehicle_id",
                table: "vehicleSystemMap",
                column: "vehicle_id");

            migrationBuilder.CreateIndex(
                name: "IX_vehicleSystemMap_vehicle_system_id",
                table: "vehicleSystemMap",
                column: "vehicle_system_id");

            migrationBuilder.CreateIndex(
                name: "IX_vehicleTemplate_book_id",
                table: "vehicleTemplate",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_weapon_availability_id",
                table: "weapon",
                column: "availability_id");

            migrationBuilder.CreateIndex(
                name: "IX_weapon_book_id",
                table: "weapon",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_weapon_fire_type_id",
                table: "weapon",
                column: "fire_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_weapon_size_id",
                table: "weapon",
                column: "size_id");

            migrationBuilder.CreateIndex(
                name: "IX_weapon_stun_type_id",
                table: "weapon",
                column: "stun_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_weapon_weapon_category_id",
                table: "weapon",
                column: "weapon_category_id");

            migrationBuilder.CreateIndex(
                name: "IX_weaponAmmunitionMap_weapon_ammunition_id",
                table: "weaponAmmunitionMap",
                column: "weapon_ammunition_id");

            migrationBuilder.CreateIndex(
                name: "IX_weaponAmmunitionMap_weapon_id",
                table: "weaponAmmunitionMap",
                column: "weapon_id");

            migrationBuilder.CreateIndex(
                name: "IX_weaponCategory_weapon_range_id",
                table: "weaponCategory",
                column: "weapon_range_id");

            migrationBuilder.CreateIndex(
                name: "IX_weaponDamageMap_damage_type_id",
                table: "weaponDamageMap",
                column: "damage_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_weaponDamageMap_weapon_id",
                table: "weaponDamageMap",
                column: "weapon_id");

            migrationBuilder.CreateIndex(
                name: "IX_weaponTemplate_book_id",
                table: "weaponTemplate",
                column: "book_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "armour");

            migrationBuilder.DropTable(
                name: "armourTemplate");

            migrationBuilder.DropTable(
                name: "background");

            migrationBuilder.DropTable(
                name: "beast");

            migrationBuilder.DropTable(
                name: "character");

            migrationBuilder.DropTable(
                name: "classBonusFeatMap");

            migrationBuilder.DropTable(
                name: "classPrestigeSpecial");

            migrationBuilder.DropTable(
                name: "classSkillMap");

            migrationBuilder.DropTable(
                name: "classTalentTreeMap");

            migrationBuilder.DropTable(
                name: "droidSystem");

            migrationBuilder.DropTable(
                name: "equipment");

            migrationBuilder.DropTable(
                name: "equipmentCybernetic");

            migrationBuilder.DropTable(
                name: "equipmentUpgrade");

            migrationBuilder.DropTable(
                name: "forcePower");

            migrationBuilder.DropTable(
                name: "forceSecret");

            migrationBuilder.DropTable(
                name: "forceTechnique");

            migrationBuilder.DropTable(
                name: "index");

            migrationBuilder.DropTable(
                name: "language");

            migrationBuilder.DropTable(
                name: "medicalSecret");

            migrationBuilder.DropTable(
                name: "planet");

            migrationBuilder.DropTable(
                name: "prerequisiteAbility");

            migrationBuilder.DropTable(
                name: "prerequisiteFeat");

            migrationBuilder.DropTable(
                name: "prerequisiteLevel");

            migrationBuilder.DropTable(
                name: "prerequisiteSize");

            migrationBuilder.DropTable(
                name: "prerequisiteSkill");

            migrationBuilder.DropTable(
                name: "prerequisiteSpecies");

            migrationBuilder.DropTable(
                name: "prerequisiteSpeciesTrait");

            migrationBuilder.DropTable(
                name: "prerequisiteTalent");

            migrationBuilder.DropTable(
                name: "prerequisiteTalentTree");

            migrationBuilder.DropTable(
                name: "shieldTemplate");

            migrationBuilder.DropTable(
                name: "skillAction");

            migrationBuilder.DropTable(
                name: "speciesBonusFeatMap");

            migrationBuilder.DropTable(
                name: "speciesLanguageMap");

            migrationBuilder.DropTable(
                name: "speciesTraitMap");

            migrationBuilder.DropTable(
                name: "starhipManeuver");

            migrationBuilder.DropTable(
                name: "vehicleSystemMap");

            migrationBuilder.DropTable(
                name: "vehicleTemplate");

            migrationBuilder.DropTable(
                name: "weaponAmmunitionMap");

            migrationBuilder.DropTable(
                name: "weaponDamageMap");

            migrationBuilder.DropTable(
                name: "weaponTemplate");

            migrationBuilder.DropTable(
                name: "armourType");

            migrationBuilder.DropTable(
                name: "armourHelmet");

            migrationBuilder.DropTable(
                name: "droid");

            migrationBuilder.DropTable(
                name: "equipmentDroid");

            migrationBuilder.DropTable(
                name: "ability");

            migrationBuilder.DropTable(
                name: "level");

            migrationBuilder.DropTable(
                name: "skill");

            migrationBuilder.DropTable(
                name: "class");

            migrationBuilder.DropTable(
                name: "feat");

            migrationBuilder.DropTable(
                name: "talent");

            migrationBuilder.DropTable(
                name: "species");

            migrationBuilder.DropTable(
                name: "speciesTrait");

            migrationBuilder.DropTable(
                name: "vehicle");

            migrationBuilder.DropTable(
                name: "vehicleSystem");

            migrationBuilder.DropTable(
                name: "weaponAmmunition");

            migrationBuilder.DropTable(
                name: "weaponDamageType");

            migrationBuilder.DropTable(
                name: "weapon");

            migrationBuilder.DropTable(
                name: "talentTree");

            migrationBuilder.DropTable(
                name: "vehicleType");

            migrationBuilder.DropTable(
                name: "vehicleAmmunition");

            migrationBuilder.DropTable(
                name: "vehicleWeaponRange");

            migrationBuilder.DropTable(
                name: "availability");

            migrationBuilder.DropTable(
                name: "weaponFireType");

            migrationBuilder.DropTable(
                name: "size");

            migrationBuilder.DropTable(
                name: "weaponStunType");

            migrationBuilder.DropTable(
                name: "weaponCategory");

            migrationBuilder.DropTable(
                name: "book");

            migrationBuilder.DropTable(
                name: "weaponRange");
        }
    }
}
