//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015/10/20 - 23:37:22
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
    public partial class forumPostDTO
    {
        [DataMember()]
        public Int64 idForumPost { get; set; }

        [DataMember()]
        public Nullable<Int64> idSubcategory { get; set; }

        [DataMember()]
        public Nullable<Int64> idPerson { get; set; }

        [DataMember()]
        public Nullable<Int64> parent_post { get; set; }

        [DataMember()]
        public String title { get; set; }

        [DataMember()]
        public String content_forum { get; set; }

        [DataMember()]
        public Nullable<DateTime> date { get; set; }

        [DataMember()]
        public String ip { get; set; }

        [DataMember()]
        public List<forumPostDTO> forumPosts1 { get; set; }

        [DataMember()]
        public forumPostDTO forumPost1 { get; set; }

        [DataMember()]
        public forumSubcategoryDTO forumSubcategory { get; set; }

        [DataMember()]
        public personDTO person { get; set; }

        [DataMember()]
        public List<forumVoteDTO> forumVotes { get; set; }

        public forumPostDTO()
        {
        }

        public forumPostDTO(Int64 idForumPost, Nullable<Int64> idSubcategory, Nullable<Int64> idPerson, Nullable<Int64> parent_post, String title, String content_forum, Nullable<DateTime> date, String ip, List<forumPostDTO> forumPosts1, forumPostDTO forumPost1, forumSubcategoryDTO forumSubcategory, personDTO person, List<forumVoteDTO> forumVotes)
        {
			this.idForumPost = idForumPost;
			this.idSubcategory = idSubcategory;
			this.idPerson = idPerson;
			this.parent_post = parent_post;
			this.title = title;
			this.content_forum = content_forum;
			this.date = date;
			this.ip = ip;
			this.forumPosts1 = forumPosts1;
			this.forumPost1 = forumPost1;
			this.forumSubcategory = forumSubcategory;
			this.person = person;
			this.forumVotes = forumVotes;
        }
    }
}
