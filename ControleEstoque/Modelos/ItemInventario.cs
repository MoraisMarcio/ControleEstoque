//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modelos
{
    using System;
    using System.Collections.Generic;
    
    public partial class ItemInventario
    {
        public int Id { get; set; }
        public int Estoque { get; set; }
        public int InventarioId { get; set; }
        public int ProdutoId { get; set; }
    
        public virtual Inventario Inventario { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
