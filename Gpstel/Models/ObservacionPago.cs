namespace Gpstel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ObservacionPago")]
    public partial class ObservacionPago
    {
        [Key]
        public int idobservacio { get; set; }

        [StringLength(100)]
        public string observacion { get; set; }

        [StringLength(1)]
        public string estado { get; set; }

        public int? idpago { get; set; }

        public virtual Pago Pago { get; set; }
    }
}
