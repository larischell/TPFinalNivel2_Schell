namespace Negocio
{
    internal class Articulo
    {
        internal Marca marca;
        internal Categoria categoria;

        public int Id { get; internal set; }
        public string Codigo { get; internal set; }
        public string Nombre { get; internal set; }
        public string Descripcion { get; internal set; }
        public decimal Precio { get; internal set; }
        public string ImagenUrl { get; internal set; }
    }
}