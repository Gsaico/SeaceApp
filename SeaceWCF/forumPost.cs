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
    
    public partial class forumPost
    {
        public forumPost()
        {
            this.forumPosts1 = new HashSet<forumPost>();
            this.forumVotes = new HashSet<forumVote>();
        }
    
        public long idForumPost { get; set; }
        public Nullable<long> idSubcategory { get; set; }
        public Nullable<long> idPerson { get; set; }
        public Nullable<long> parent_post { get; set; }
        public string title { get; set; }
        public string content_forum { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string ip { get; set; }
    
        public virtual ICollection<forumPost> forumPosts1 { get; set; }
        public virtual forumPost forumPost1 { get; set; }
        public virtual forumSubcategory forumSubcategory { get; set; }
        public virtual person person { get; set; }
        public virtual ICollection<forumVote> forumVotes { get; set; }
    }
}
