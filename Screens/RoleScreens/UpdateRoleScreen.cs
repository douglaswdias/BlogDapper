using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.RoleScreens
{
  public static class UpdateRoleScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Atualizar Perfil");
      Console.WriteLine("----------------------------------------");
      Console.Write("Id: ");
      var id = Console.ReadLine();
      Console.Write("Nome: ");
      var name = Console.ReadLine();
      Console.Write("Slug: ");
      var slug = Console.ReadLine();
      Update(new Role
      {
        Id = int.Parse(id),
        Name = name,
        Slug =slug
      });
      Console.WriteLine("Pressione uma tecla para voltar");
      Console.ReadKey();
      MenuRoleScreen.Load();
    }

    public static void Update(Role role)
    {
      try
      {
        var repository = new Repository<Role>(Database.Connection);
        repository.Update(role);
        Console.WriteLine("Perfil Atualizado");
      }
      catch(Exception ex)
      {
        Console.WriteLine("Erro ao Atualizar Perfil");
        Console.WriteLine(ex.Message);
      }
    }
  }
}