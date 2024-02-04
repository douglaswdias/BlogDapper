using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
  [Table("[Post]")]
  public class Post
  {
    public Post()
    {
        Tags = new List<Tag>();
    }
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public User AuthorId { get; set; }
    public string Title { get; set; }
    public string Summary { get; set; }
    public string Body { get; set; }
    public string Slug { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime LastUpdateDate { get; set; }
    public List<Tag> Tags { get; set; }
  }
}