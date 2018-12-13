namespace WebApiEFModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    /// <summary>
    /// Class KIND_OF_PACKING is a POCO class pointing to a table into database
    /// Creation: Gildasio Cardoso
    /// </summary>B
    [Table("KIND_OF_PACKING")]
    public partial class KIND_OF_PACKING
    {
        [Key]
        public int ID_KIND_OF_PACKING { get; set; }

        [Required]
        [StringLength(40)]
        public string DSC_KIND_OF_PACKING { get; set; }

        public decimal HEIGHT { get; set; }

        public decimal WIDTH { get; set; }

        public decimal DEPTH { get; set; }

        public decimal WEIGHT { get; set; }
    }
}
