using System.ComponentModel.DataAnnotations.Schema;

namespace CarroCompras.Modelos
{
    public class Compra
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public int UsuarioId { get; set; }
        public int Cantidad { get; set; }

        [ForeignKey("ProductoId")]
        public Producto Producto { get; set; }

        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }
    }
}
