namespace F1HUB.Models
{
    public class Publicacion
    {
        public int IdPubli { get; set; }
        public string Texto { get; set; }
        public long FechaPublicacion { get; set; }
        public Usuario Usuario { get; set; }

        public string NombreUsuario => Usuario?.NombreUsuario ?? string.Empty;
    }
}
