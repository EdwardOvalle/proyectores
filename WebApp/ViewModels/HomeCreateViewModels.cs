using System.ComponentModel.DataAnnotations;
using WebApp.Models;

namespace WebApp.ViewModels
{
    public class HomeCreateViewModels
    {
        [Required(ErrorMessage = "Debe de proporcionar un valor para el campo Marca")]
        [StringLength(24)]
        public string Marca { get; set; }
        [Required(ErrorMessage = "Debe de proporcionar un valor para el campo Modelo")]
        public string Modelo { get; set; }
        [Required(ErrorMessage = "Debe de proporcionar un valor para el campo Número de serie")]
        public string NumeroDeSerie { get; set; }
        public SituacionProyector Situacion { get; set; }
            = SituacionProyector.Bueno;
        [DataType(DataType.Date)]
        public DateTime FechaDeAlta { get; set; } = DateTime.Now;
        [DataType(DataType.Date)]
        public DateTime? FechaDeBaja { get; set; } = null;
    }
}
