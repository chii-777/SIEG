﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace SIEG_API.Models
{
    public partial class ForumReply
    {
        public ForumReply()
        {
            ForumReply2 = new HashSet<ForumReply2>();
        }

        public int ForumReplyId { get; set; }
        public int ForumArticleId { get; set; }
        public int MemberId { get; set; }
        public int Floor { get; set; }
        public string ForumReplyContent { get; set; }
        public string Img { get; set; }
        public DateTime AddTime { get; set; }
        public bool? ValIdity { get; set; }
        public int LikeCount { get; set; }

        public virtual ForumArticle ForumArticle { get; set; }
        public virtual Member Member { get; set; }
        public virtual ICollection<ForumReply2> ForumReply2 { get; set; }
    }
}