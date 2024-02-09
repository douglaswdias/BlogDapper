using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.UserScreens
{
  public static class UpdateUserScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Atualizar Usuário");
      Console.WriteLine("----------------------------------------");
      Console.Write("Id: ");
      var id = Console.ReadLine();
      Console.Write("Nome: ");
      var name = Console.ReadLine();
      Console.Write("Email: ");
      var email = Console.ReadLine();
      Console.Write("Senha: ");
      var passwordHash = Console.ReadLine();
      Console.Write("Bio: ");
      var bio = Console.ReadLine();
      Console.Write("Imagem: ");
      var image = Console.ReadLine();
      Console.Write("Slug: ");
      var slug = Console.ReadLine();
      Update(new User
      {
        Id = int.Parse(id),
        Name = name,
        Email = email,
        PasswordHash = passwordHash,
        Bio = bio,
        Image = image,
        Slug = slug
      });
      Console.WriteLine("Pressione uma tecla para voltar");
      Console.ReadKey();
      MenuUserScreen.Load();
    }

    public static void Update(User user)
    {
      try
      {
        var repository = new Repository<User>(Database.Connection);
        repository.Update(user);
        Console.WriteLine("Usuario Atualizado");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Erro ao atualizar Usuario");
        Console.WriteLine(ex.Message);
      }
    }
  }
}