namespace Gpstel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cliente")]
    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            ObservacionCliente = new HashSet<ObservacionCliente>();
            Vehiculo = new HashSet<Vehiculo>();
        }

        [Key]
        public int idcliente { get; set; }

        public DateTime? fecha_contrato { get; set; }

        [StringLength(1)]
        public string estado { get; set; }

        [StringLength(50)]
        public string nombre { get; set; }

        [StringLength(50)]
        public string apellido { get; set; }

        [StringLength(11)]
        public string dni_ruc { get; set; }

        [StringLength(9)]
        public string telefono { get; set; }

        [StringLength(9)]
        public string celular { get; set; }

        [StringLength(50)]
        public string correo { get; set; }

        [StringLength(50)]
        public string direccion { get; set; }

        public int? iddistrito { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ObservacionCliente> ObservacionCliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vehiculo> Vehiculo { get; set; }

        public virtual Distrito Distrito { get; set; }
    }
}
