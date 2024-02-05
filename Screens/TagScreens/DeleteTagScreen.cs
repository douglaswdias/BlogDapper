using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.TagScreens
{
  public static class DeleteTagScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Excluir Tag");
      Console.WriteLine("----------------------------------------");
      Console.Write("Id da Tag a ser Apagada: ");
      var id = Console.ReadLine();
      Delete(int.Parse(id));
      Console.WriteLine("Pressione uma tecla para voltar");
      Console.ReadKey();
      MenuTagScreen.Load();
    }

    public static void Delete(int id)
    {
      try
      {
        var repository = new Repository<Tag>(Database.Connection);
        repository.Delete(id);
        Console.WriteLine("Tag Excluida");
      }
      catch(Exception ex)
      {
        Console.WriteLine("Erro ao Excluir Tag");	
        Console.WriteLine(ex.Message);
      }
    }
  }
}