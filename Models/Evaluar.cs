//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoPrueba.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Evaluar
    {
        public int IdEvaluar { get; set; }
        public int IdPedido { get; set; }
        public string Calificacion { get; set; }
        public string Comentario { get; set; }
    
        public virtual Pedidos Pedidos { get; set; }
    }
}
