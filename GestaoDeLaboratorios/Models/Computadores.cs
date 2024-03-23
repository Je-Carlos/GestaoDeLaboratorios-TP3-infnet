using System.ComponentModel.DataAnnotations;

namespace GestaoDeLaboratorios.Models
{
    public class Computadores
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public string Processador { get; set; }
        [Required]
        public string PlacaMae { get; set; }
        [Required]
        public string Memoria { get; set; }
        [Required]
        public string HD { get; set; }
        [Required]
        public int Patrimonio { get; set; }
        [Required]
        public string DataCompra { get; set; }

    }
}