using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.RoleScreens
{
  public static class DeleteRoleScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Excluir Perfil");
      Console.WriteLine("----------------------------------------");
      Console.WriteLine("Id: ");
      var id = Console.ReadLine();
      Delete(int.Parse(id));
      Console.WriteLine("Pressione uma tecla para voltar");
      Console.ReadKey();
      MenuRoleScreen.Load();
    }

    public static void Delete(int id)
    {
      try
      {
        var repository = new Repository<Role>(Database.Connection);
        repository.Delete(id);
        Console.WriteLine("Perfiil Excuido");
      }
      catch(Exception ex)
      {
        Console.WriteLine("Erro ao Excluir Perfil");
        Console.WriteLine(ex.Message);
      }
    }
  }
}