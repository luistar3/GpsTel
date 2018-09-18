namespace Gpstel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ObservacionCliente")]
    public partial class ObservacionCliente
    {
        [Key]
        public int idobservacion { get; set; }

        [StringLength(100)]
        public string observacion { get; set; }

        [StringLength(1)]
        public string estado { get; set; }

        public int? idcliente { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
