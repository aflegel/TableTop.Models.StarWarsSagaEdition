﻿using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class ForceSecret
    {
        public int ForceSecretId { get; set; }
        public string Name { get; set; }
        public int? BookId { get; set; }
        public int? Page { get; set; }
        public string Description { get; set; }

        public Book Book { get; set; }
    }
}
