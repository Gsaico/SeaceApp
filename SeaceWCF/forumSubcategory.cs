//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SeaceWCF
{
    using System;
    using System.Collections.Generic;
    
    public partial class forumSubcategory
    {
        public forumSubcategory()
        {
            this.forumPosts = new HashSet<forumPost>();
        }
    
        public long idSubcategory { get; set; }
        public Nullable<long> idCategory { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string ip { get; set; }
    
        public virtual forumCategory forumCategory { get; set; }
        public virtual ICollection<forumPost> forumPosts { get; set; }
    }
}
