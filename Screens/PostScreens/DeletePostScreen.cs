using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.PostScreens
{
  public static class DeletePostScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Excluir Post");
      Console.WriteLine("----------------------------------------");
      Console.Write("Id do Post a ser Apagado: ");
      var id = Console.ReadLine();
      Delete(int.Parse(id));
      Console.WriteLine("Pressione uma tecla para voltar");
      Console.ReadKey();
      MenuPostScreen.Load();
    }

    static void Delete(int id)
    {
      try
      {
        var repository = new Repository<Post>(Database.Connection);
        repository.Delete(id);
        Console.WriteLine("Poste Excluido");
      }
      catch(Exception ex)
      {
        Console.WriteLine("Erro ao apagar Post");
        Console.WriteLine(ex.Message);
      }

    }
  }
}