using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_03_2022_Facebook.Models
{
    internal class Post
    {
        public string Text;
        public string SharedDate;
        public int LikeCount;
        public int CommentCount;
        Comment[] comments;
    }
}
