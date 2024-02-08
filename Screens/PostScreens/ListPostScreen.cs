using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.PostScreens
{
  public static class ListPostScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Lista de Posts");
      Console.WriteLine("----------------------------------------");
      List();
      Console.WriteLine("----------------------------------------\n");
      Console.WriteLine("Pressione uma tecla para voltar");
      Console.ReadKey();
      MenuPostScreen.Load();
    }

    static void List()
    {
      var repository = new Repository<Post>(Database.Connection);
      var posts = repository.Get();

      foreach(var post in posts)
      {
        Console.WriteLine($"{post.Id} - {post.Title} - {post.Body}");
      }
    }
  }
}