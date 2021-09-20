using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NotfisUpload.Models
{
    [Table("Arquivo")]


    public class Arquivo
    {
        [Key]
        public int intercambio { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string FileType { get; set; }

        [MaxLength]
        public Byte[] DataFiles { get; set; }

        public DateTime? Emissao { get; set; }
    }    
    
}
