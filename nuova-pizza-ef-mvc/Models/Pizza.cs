
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nuova_pizza_ef_mvc.Models

{
    [Table("Pizza")]
    public class Pizza
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descrizione { get; set; }

        [Column("Immagine")]
        public string? ImgPath { get; set; }

        public string Prezzo { get; set; }

        [NotMapped()]
        public IFormFile? File { get; set; }

    }

    

}

