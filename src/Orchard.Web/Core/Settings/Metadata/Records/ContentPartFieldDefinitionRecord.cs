﻿using Orchard.Data.Conventions;

namespace Orchard.Core.Settings.Metadata.Records {
    public class ContentPartFieldDefinitionRecord {
        public virtual int Id { get; set; }
        public virtual ContentFieldDefRecord ContentFieldDefRecord { get; set; }
        public virtual string Name { get; set; }
        [StringLengthMax]
        public virtual string Settings { get; set; }
    }
}