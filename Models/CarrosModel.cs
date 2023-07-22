using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_teste.Models
{
    [Table("Carros")]
    public class CarrosModel
    {

        

        [Key]
        public int Id { get; set; }

        public string? Modelo { get; set; }

        public string? Cor { get; set; }
        public string? Marca { get; set; }

        public string? Ano { get; set; }

       


        public CarrosModel(string Modelo, string Cor, string Marca, string Ano)
        {

            this.Modelo = Modelo;
            this.Cor = Cor;
            this.Marca = Marca;
            this.Ano = Ano;
           

        }

    }
}

