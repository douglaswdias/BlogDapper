using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.CategoryScreens
{
  public static class ListCategoryScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Listar Categorias");
      Console.WriteLine("----------------------------------------");
      List();
      Console.WriteLine("----------------------------------------\n");
      Console.WriteLine("Pressione uma tecla para voltar");
      Console.ReadKey();
      MenuCategoryScreen.Load();
    }

    public static void List()
    {
      var repository = new Repository<Category>(Database.Connection);
      var categories = repository.Get();

      foreach (var category in categories)
      {
        Console.WriteLine($"{category.Id} - {category.Name} ({category.Slug})");
      }
    }
  }
}