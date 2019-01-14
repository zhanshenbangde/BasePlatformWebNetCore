using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasePlatformWebApi.Models
{
    [Table("cap.published")]
    public partial class CapPublished
    {
        [Column(TypeName = "bigint(20)")]
        public long Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(200)")]
        public string Name { get; set; }
        [Column(TypeName = "longtext")]
        public string Content { get; set; }
        [Column(TypeName = "int(11)")]
        public int? Retries { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Added { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExpiresAt { get; set; }

        [Required]
        [Column(TypeName = "varchar(40)")]
        public string StatusName { get; set; }
    }
}
