namespace Primer_proyecto.Models
{
    public class Recinto
    {
        public Recinto() {

            Telefono = "No Aplica";
        
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get;}
        public string? Telefono { get; set; }
        List<Persona> Personas { get; set;}
        Persona JefeRecinto { get; set; }
    }
}
