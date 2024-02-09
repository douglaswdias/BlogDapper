using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.UserScreens
{
  public static class CreateUserScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Criar novo usuário");
      Console.WriteLine("----------------------------------------");
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
      Create(new User
      {
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

    public static void Create(User user)
    {
      try
      {
        var repository = new Repository<User>(Database.Connection);
        repository.Create(user);
        Console.WriteLine("Usuario Cadastrado");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Erro ao cadastrar Usuario");
        Console.WriteLine(ex.Message);
      }
    }
  }
}