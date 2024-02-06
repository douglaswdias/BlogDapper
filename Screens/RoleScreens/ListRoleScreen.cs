using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.RoleScreens
{
  public static class ListRoleScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Lista Perfis");
      Console.WriteLine("----------------------------------------");
      List();
      Console.WriteLine("----------------------------------------\n");
      Console.WriteLine("Pressione uma tecla para voltar");
      Console.ReadKey();
      MenuRoleScreen.Load();
    }

    static void List()
    {
      var repository = new Repository<Role>(Database.Connection);
      var roles = repository.Get();

      foreach(var role in roles)
      {
        Console.WriteLine($"{role.Id} - {role.Name} ({role.Slug})");
      }
    }
  }
}