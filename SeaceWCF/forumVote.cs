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
    
    public partial class forumVote
    {
        public long idVote { get; set; }
        public Nullable<long> idForumPost { get; set; }
        public Nullable<long> idPerson { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string comment { get; set; }
        public string ip { get; set; }
    
        public virtual forumPost forumPost { get; set; }
        public virtual person person { get; set; }
    }
}
