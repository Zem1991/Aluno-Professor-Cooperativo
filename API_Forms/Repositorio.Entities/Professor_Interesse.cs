//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repositorio.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Professor_Interesse
    {
        public int Prof_Interesse_ID { get; set; }
        public Nullable<int> Professor { get; set; }
        public Nullable<int> Interesse { get; set; }
    
        public virtual Interesse Interesse1 { get; set; }
        public virtual Professor Professor1 { get; set; }
    }
}
