namespace WebApiEFModel
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Xml.Serialization;

    /// <summary>
    /// Class BRAND is a POCO class pointing to a table into database
    /// Creation: Gildasio Cardoso
    /// </summary>

    [Table("BRAND")]
    public partial class BRAND
    {
        [Key]
        public int ID_BRAND { get; set; }

        public int ID_SUPPLIER { get; set; }

        [Required]
        [StringLength(40)]
        public string DSC_BRAND { get; set; }

//        [XmlIgnore, JsonIgnore, System.ComponentModel.DataAnnotations.Schema.ForeignKey("ID_SUPPLIER")]
        public virtual SUPPLIER SUPPLIER { get; set; }
    }
}
