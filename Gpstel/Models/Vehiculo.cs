namespace Gpstel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vehiculo")]
    public partial class Vehiculo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vehiculo()
        {
            ObservacionVehiculo = new HashSet<ObservacionVehiculo>();
            Pago = new HashSet<Pago>();
        }

        [Key]
        public int idvehiculo { get; set; }

        [StringLength(7)]
        public string placa { get; set; }

        [StringLength(20)]
        public string marca { get; set; }

        [StringLength(20)]
        public string modelo { get; set; }

        [StringLength(4)]
        public string anio_vehiculo { get; set; }

        [StringLength(20)]
        public string color { get; set; }

        [StringLength(20)]
        public string nro_motor { get; set; }

        [StringLength(10)]
        public string particular_mtc { get; set; }

        [StringLength(1)]
        public string estado { get; set; }

        public int? idgps { get; set; }

        public DateTime? fecha_instalacion { get; set; }

        public int? idcliente { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual GPS GPS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ObservacionVehiculo> ObservacionVehiculo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pago> Pago { get; set; }
    }
}
