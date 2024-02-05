using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.TagScreens
{
  public static class CreateTagScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Nova Tag");
      Console.WriteLine("----------------------------------------");
      Console.Write("Nome: ");
      var name = Console.ReadLine();
      Console.Write("Slug: ");
      var slug = Console.ReadLine();
      Create(new Tag
      {
        Name = name,
        Slug = slug
      });
      Console.WriteLine("Pressione uma tecla para voltar");
      Console.ReadKey();
      MenuTagScreen.Load();
    }

    public static void Create(Tag tag)
    {
      try
      {
        var repository = new Repository<Tag>(Database.Connection);
        repository.Create(tag);
        Console.WriteLine("Tag Cadastrada");
      }
      catch(Exception ex)
      {
        Console.WriteLine("Erro ao cadastrar Tag");	
        Console.WriteLine(ex.Message);
      }
    }
  }
}