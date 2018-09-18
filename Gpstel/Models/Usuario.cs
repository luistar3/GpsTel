namespace Gpstel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usuario")]
    public partial class Usuario
    {
        [Key]
        public int idusuario { get; set; }

        [StringLength(50)]
        public string nombre { get; set; }

        [StringLength(100)]
        public string password { get; set; }

        [StringLength(1)]
        public string estado { get; set; }

        [StringLength(18)]
        public string tipo { get; set; }
    }
}
