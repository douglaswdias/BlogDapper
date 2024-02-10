using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.CategoryScreens
{
  public static class DeleteCategoryScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Excluir Categoria");
      Console.WriteLine("----------------------------------------");
      Console.Write("Id da Categoria a ser excluída: ");
      var id = Console.ReadLine();
      Delete(int.Parse(id));
      Console.WriteLine("Pressione uma tecla para voltar");
      Console.ReadKey();
      MenuCategoryScreen.Load();
    }

    public static void Delete(int id)
    {
      try
      {
        var repository = new Repository<Category>(Database.Connection);
        repository.Delete(id);
        Console.WriteLine("Categoria Excluida");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Erro ao excluir Categoria");
        Console.WriteLine(ex.Message);
      }
    }
  }
}