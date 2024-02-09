using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.UserScreens
{
  public static class ListUserScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Listar Usuários");
      Console.WriteLine("----------------------------------------");
      List();
      Console.WriteLine("----------------------------------------\n");
      Console.WriteLine("Pressione uma tecla para voltar");
      Console.ReadKey();
      MenuUserScreen.Load();
    }

    public static void List()
    {
      var repository = new Repository<User>(Database.Connection);
      var users = repository.Get();

      foreach(var user in users)
      {
        Console.WriteLine($"{user.Id} - {user.Name} - ({user.Email})");
      }
    }
  }
}