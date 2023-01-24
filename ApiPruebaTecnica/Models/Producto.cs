namespace ApiPruebaTecnica.Models
{
    public class Producto
    {
        public string? id { get; set; }
        public string nombre { get; set; }
        public string especie { get; set;}
        public ImagenProducto urlarchivo { get; set; }
        public List<VariedadProducto> variedades { get; set;}
        public List<GradoProducto>grados { get; set; }

    }
}
