namespace Gpstel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GPS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GPS()
        {
            Vehiculo = new HashSet<Vehiculo>();
        }

        [Key]
        public int idgps { get; set; }

        [StringLength(50)]
        public string modelo { get; set; }

        [StringLength(20)]
        public string estado_uso { get; set; }

        [StringLength(20)]
        public string garantia { get; set; }

        public int idchip { get; set; }

        public DateTime? fecha_compra { get; set; }

        [StringLength(50)]
        public string imei { get; set; }

        public virtual CHIP CHIP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vehiculo> Vehiculo { get; set; }
    }
}
