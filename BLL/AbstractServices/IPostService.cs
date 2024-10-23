using BLL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.AbstractServices
{
    public interface IPostService
    {
        Task CreatePost(PostDto postDto); //post oluştur
        Task<List<PostDto>>GetAllPosts(); //bütün postları getir
        Task<List<PostDto>>GetAllUnApprovedPosts(); //onaylanmayan postları getir
        Task ApprovePost(int postId); //post onayla
        Task LikePost(int postId,int userId);//beğenile posttu tutar

    }
}
