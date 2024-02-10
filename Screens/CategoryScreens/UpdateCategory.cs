using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.CategoryScreens
{
  public static class UpdateCategoryScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Atualizar Categoria");
      Console.WriteLine("----------------------------------------");
      Console.Write("Id da Categoria a ser atualizada: ");
      var id = Console.ReadLine();
      Console.Write("Nome: ");
      var name = Console.ReadLine();
      Console.Write("Slug: ");
      var slug = Console.ReadLine();
      Update(new Category
      {
        Id = int.Parse(id),
        Name = name,
        Slug = slug
      });
      Console.WriteLine("Pressione uma tecla para voltar");
      Console.ReadKey();
      MenuCategoryScreen.Load();
    }

    public static void Update(Category category)
    {
      try
      {
        var repository = new Repository<Category>(Database.Connection);
        repository.Update(category);
        Console.WriteLine("Categoria Atualizada");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Erro ao atualizar Categoria");
        Console.WriteLine(ex.Message);
      }
    }
  }
}