using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.CategoryScreens
{
  public static class CreateCategoryScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Nova Categoria");
      Console.WriteLine("----------------------------------------");
      Console.Write("Nome: ");
      var name = Console.ReadLine();
      Console.Write("Slug: ");
      var slug = Console.ReadLine();
      Create(new Category
      {
        Name = name,
        Slug = slug
      });
      Console.WriteLine("Pressione uma tecla para voltar");
      Console.ReadKey();
      MenuCategoryScreen.Load();
    }

    public static void Create(Category category)
    {
      try
      {
        var repository = new Repository<Category>(Database.Connection);
        repository.Create(category);
        Console.WriteLine("Categoria Cadastrada");
      }
      catch(Exception ex)
      {
        Console.WriteLine("Erro ao cadastrar Categoria");
        Console.WriteLine(ex.Message);
      }
    }
  }
}