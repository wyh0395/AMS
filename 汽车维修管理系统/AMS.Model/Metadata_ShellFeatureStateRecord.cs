namespace AMS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Metadata_ShellFeatureStateRecord
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string InstallState { get; set; }

        [StringLength(255)]
        public string EnableState { get; set; }

        public int? ShellStateRecord_Id { get; set; }
    }
}
