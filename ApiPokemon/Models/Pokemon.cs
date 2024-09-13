using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPokemon.Models
{
    [Table("Pokemons")]
    public class Pokemon

    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Nome { get; set; }
        
        public string? Tipo { get; set; }
        public string? Habitat { get; set; }
        public string? Geracao { get; set; }
        public string? Fraqueza { get; set; }
        public string? Resistencia { get; set; }
        public string? Jogo { get; set; }
        public string? Console { get; set; }
        public string? Descricao { get; set; }
        public string? Foto { get; set; }
        
        [Required]
        public string Status { get; set; }

    }
}
