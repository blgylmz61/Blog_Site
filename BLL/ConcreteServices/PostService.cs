using AutoMapper;
using BLL.AbstractServices;
using BLL.Dtos;
using DAL.AbstractRepositories;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ConcreteServices
{
    public class PostService : IPostService
    {
        public readonly IRepository<Post> _postRepository;
        public readonly IMapper _mapper;
        private readonly IRepository<User> _userRepository;
        private readonly IRepository<PostLike> _postLikeRepository;

        public PostService(IRepository<Post> postRepository, IMapper mapper,IRepository<User> userRepository,IRepository<PostLike> postLikeRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
            _postLikeRepository = postLikeRepository;
            _postRepository = postRepository;
        }
        public async Task ApprovePost(int postId)
        {
            var postToBeApproved = await _postRepository.GetByIdAsync(postId);
            postToBeApproved.IsApproved = true;
            await _postRepository.UpdateAsync(postToBeApproved);
        }

        public async Task CreatePost(PostDto postDto)
        {
            var post=_mapper.Map<Post>(postDto);
            await _postRepository.AddAsync(post);
        }

        public async Task<List<PostDto>> GetAllPosts()
        {
           var posts =await _postRepository.GetAllAsync();
            posts = posts.Where(x => x.IsApproved);
            return _mapper.Map<List<PostDto>>(posts);
        }

        public async Task<List<PostDto>> GetAllUnApprovedPosts()
        {
            var unApprovedPosts=await _postRepository.GetAllAsync();
            //unApprovedPosts= unApprovedPosts.Where(x => x.IsApproved==false);
            return _mapper.Map<List<PostDto>>(unApprovedPosts);


        }

        public async Task LikePost(int postId, int userId)
        {
            var likePost = await _postRepository.GetByIdAsync(postId);
            var likeUser=await _userRepository.GetByIdAsync(userId);
            var like= _mapper.Map<PostLikeDto>(new PostLike());
            like.UserId = userId;
            like.PostId = postId;
            like.PostDto=_mapper.Map<PostDto>(likePost);
            like.UserDto = _mapper.Map<UserDto>(likeUser);

            var postLikes = await _postLikeRepository.GetAllAsync();
            var likedPosts = postLikes.FirstOrDefault(x=>x.UserId==userId && x.PostId==postId);
            if(likedPosts==null)
            {
                await _postLikeRepository.AddAsync(_mapper.Map<PostLike>(like));
                likePost.LikeCount++;
                await _postRepository.UpdateAsync(likePost);
            }
            else
            {
                await _postLikeRepository.DeleteAsync(likedPosts.Id);
                likePost.LikeCount--;
                await _postRepository.UpdateAsync(likePost);
            }

        }
    }
}
