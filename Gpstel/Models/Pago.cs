namespace Gpstel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pago")]
    public partial class Pago
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pago()
        {
            ObservacionPago = new HashSet<ObservacionPago>();
        }

        [Key]
        public int idpago { get; set; }

        [StringLength(50)]
        public string concepto { get; set; }

        public DateTime? fecha_pago { get; set; }

        public int? idvehiculo { get; set; }

        public decimal? monto { get; set; }

        [StringLength(1)]
        public string estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ObservacionPago> ObservacionPago { get; set; }

        public virtual Vehiculo Vehiculo { get; set; }
    }
}
