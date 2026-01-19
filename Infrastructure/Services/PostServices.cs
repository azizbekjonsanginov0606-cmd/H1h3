using Domain.Models;
namespace Infrastructure.Services;

public class PostServices
{
    List<Post> posts = new();

    public void AddPost(Post post){

        posts.Add(post);
    }
    public List<Post> GetPosts()
    {
        return posts;
    }

    public void UpdatePost(Post post)
    {
        foreach(Post p in posts)
        {
            if(p.Id == post.Id)
            {
                p.Title = post.Title;
                p.Description = post.Description;
                p.VoteAmount = post.VoteAmount;
                p.CreatedAt = post.CreatedAt;
            }
        }
    }

    public void DeletePost(int id){
        foreach(Post p in posts)
        {
            if(p.Id == id)
            {
                posts.Remove(p);
                break;
            }
        }
    }
}
