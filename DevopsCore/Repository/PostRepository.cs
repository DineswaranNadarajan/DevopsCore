using DevopsCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace DevopsCore.Repository
{
    public class PostRepository : IPostRepository
    {
        public List<PostModel> GetPostData()
        {
            var postValues = new List<PostModel> {
 new PostModel(){ iId =001, Name = "Demo User 1"},
 new PostModel(){ iId =002, Name = "Demo User 2"},
 new PostModel(){ iId =003, Name = "Demo User 3"},
 };
            return postValues;
        }
    }
}