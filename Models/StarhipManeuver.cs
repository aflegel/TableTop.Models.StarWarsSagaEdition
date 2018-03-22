using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class StarhipManeuver
    {
        public int StarshipManeuverId { get; set; }
        public string Name { get; set; }
        public int? BookId { get; set; }
        public int? Page { get; set; }
        public bool? AttackPattern { get; set; }
        public bool? Gunner { get; set; }
        public bool? Dogfight { get; set; }
        public bool? Force { get; set; }

        public Book Book { get; set; }
    }
}
