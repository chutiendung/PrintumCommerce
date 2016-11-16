namespace PrintumCommerce.Areas.api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRO6 Recomendaciones de Procesamiento")]
    public partial class PRO6_Recomendaciones_de_Procesamiento
    {
        [StringLength(255)]
        public string Cod_PRO { get; set; }

        [Column(TypeName = "ntext")]
        public string Informacion { get; set; }

        [Key]
        public int idCode { get; set; }

        public  PRO1_Productos PRO1_Productos { get; set; }
    }
}