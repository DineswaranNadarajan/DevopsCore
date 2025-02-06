using DevopsCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace DevopsCore.Repository
{
    public interface IPostRepository
    {
        List<PostModel> GetPostData();
    }
}