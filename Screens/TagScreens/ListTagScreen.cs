using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.TagScreens
{
  public static class ListTagScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Lista de Tags");
      Console.WriteLine("----------------------------------------");
      List();
      Console.WriteLine("----------------------------------------\n");
      Console.WriteLine("Pressione uma tecla para voltar");
      Console.ReadKey();
      MenuTagScreen.Load();
    }

    static void List()
    {
      var repository = new Repository<Tag>(Database.Connection);
      var tags = repository.Get();

      foreach(var tag in tags)
      {
        Console.WriteLine($"{tag.Id} - {tag.Name} ({tag.Slug})");
      }
    }
  }
}