namespace WebApiEFModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    /// <summary>
    /// Class SUPPLIER is a POCO class pointing to a table into database
    /// Creation: Gildasio Cardoso
    /// </summary>
    
    [Table("SUPPLIER")]
    public partial class SUPPLIER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SUPPLIER()
        {
            BRAND = new HashSet<BRAND>();
        }

        [Key]
        public int ID_SUPPLIER { get; set; }

        [Required]
        [StringLength(80)]
        public string DSC_SUPPLIER { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DATE_OF_REGISTER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BRAND> BRAND { get; set; }
    }
}
