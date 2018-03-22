using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class SkillAction
    {
        public int SkillActionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? BookId { get; set; }
        public int? Page { get; set; }
    }
}
