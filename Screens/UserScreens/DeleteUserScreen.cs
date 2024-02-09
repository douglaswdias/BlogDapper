using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.UserScreens
{
  public static class DeleteUserScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Excluir Usuário");
      Console.WriteLine("----------------------------------------");
      Console.Write("Id do Usuário a ser excluído: ");
      var id = Console.ReadLine();
      Delete(int.Parse(id));
      Console.WriteLine("Pressione uma tecla para voltar");
      Console.ReadKey();
      MenuUserScreen.Load();
    }

    public static void Delete(int id)
    {
      try
      {
        var repository = new Repository<User>(Database.Connection);
        repository.Delete(id);
        Console.WriteLine("Usuario Excluido");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Erro ao excluir Usuario");
        Console.WriteLine(ex.Message);
      }
    }
  }
}