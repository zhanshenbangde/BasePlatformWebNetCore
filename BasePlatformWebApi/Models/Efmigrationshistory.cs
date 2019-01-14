using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasePlatformWebApi.Models
{
    [Table("__efmigrationshistory")]
    public partial class Efmigrationshistory
    {
        [Column(TypeName = "varchar(150)")]
        public string MigrationId { get; set; }
        [Required]
        [Column(TypeName = "varchar(32)")]
        public string ProductVersion { get; set; }
    }
}
