//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015/10/20 - 23:37:23
//
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//-------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SeaceWCF.Dtos
{
    [DataContract()]
    public partial class forumVoteDTO
    {
        [DataMember()]
        public Int64 idVote { get; set; }

        [DataMember()]
        public Nullable<Int64> idForumPost { get; set; }

        [DataMember()]
        public Nullable<Int64> idPerson { get; set; }

        [DataMember()]
        public Nullable<DateTime> date { get; set; }

        [DataMember()]
        public String comment { get; set; }

        [DataMember()]
        public String ip { get; set; }

        [DataMember()]
        public forumPostDTO forumPost { get; set; }

        [DataMember()]
        public personDTO person { get; set; }

        public forumVoteDTO()
        {
        }

        public forumVoteDTO(Int64 idVote, Nullable<Int64> idForumPost, Nullable<Int64> idPerson, Nullable<DateTime> date, String comment, String ip, forumPostDTO forumPost, personDTO person)
        {
			this.idVote = idVote;
			this.idForumPost = idForumPost;
			this.idPerson = idPerson;
			this.date = date;
			this.comment = comment;
			this.ip = ip;
			this.forumPost = forumPost;
			this.person = person;
        }
    }
}
