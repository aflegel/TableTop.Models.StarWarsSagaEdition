using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class TalentTree
    {
        public TalentTree()
        {
            ClassTalentTreeMap = new HashSet<ClassTalentTreeMap>();
            PrerequisiteTalentTree = new HashSet<PrerequisiteTalentTree>();
            Talent = new HashSet<Talent>();
        }

        public int TalentTreeId { get; set; }
        public string Name { get; set; }
        public int? BookId { get; set; }
        public int? PageNumber { get; set; }

        public ICollection<ClassTalentTreeMap> ClassTalentTreeMap { get; set; }
        public ICollection<PrerequisiteTalentTree> PrerequisiteTalentTree { get; set; }
        public ICollection<Talent> Talent { get; set; }
    }
}
