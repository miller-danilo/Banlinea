//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class FichaDB
    {
        public int Id { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int TipoFichaDBId { get; set; }
    
        public virtual TipoFichaDB TipoFichaDB { get; set; }
    }
}
