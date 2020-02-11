using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VolvoCaminhoes.Models
{
    [DataContract]
    public class BaseModel
    {
        [DataMember]
        public int Id { get; set; }
    }

    public class Caminhao : BaseModel
    {
        [RegularExpression(@"FH|FM", ErrorMessage = "O caminhão deve ser do modelo FH ou FM.")]
        [Required]
        public string Modelo { get; set; }
        [Required]
        public string AnoFabricacao { get; set; }
        [Required]
        public string AnoModelo { get; set; }

        public Caminhao()
        {
            this.AnoFabricacao = DateTime.Now.Year.ToString();
        }

        public Caminhao(string modelo, string anoFabricacao, string anoModelo)
        {
            this.Modelo = modelo;
            this.AnoFabricacao = anoFabricacao;
            this.AnoModelo = anoModelo;
        }
    }
}
