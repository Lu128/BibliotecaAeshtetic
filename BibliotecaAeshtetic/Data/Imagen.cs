using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace MudBlazor.Examples.Data.Models
{
    public class Imagen
    {
        [Key]
        public int idImagen { get; set; }
        public string nombre { get; set; }
        public string fotografo { get; set; }
        public string pais { get; set; }
        public int fecha { get; set; }
        public string descripcion { get; set; }
    }
}
