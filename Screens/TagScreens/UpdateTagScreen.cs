using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.TagScreens
{
  public static class UpdateTagScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Atualizar Tag");
      Console.WriteLine("----------------------------------------");
      Console.Write("Id da Tag a ser atualizada: ");
      var id = Console.ReadLine();
      Console.Write("Nome: ");
      var name = Console.ReadLine();
      Console.Write("Slug: ");
      var slug = Console.ReadLine();
      Update(new Tag
      {
        Id = int.Parse(id),
        Name = name,
        Slug = slug
      });
      Console.WriteLine("Pressione uma tecla para voltar");
      Console.ReadKey();
      MenuTagScreen.Load();
    }

    public static void Update(Tag tag)
    {
      try
      {
        var repository = new Repository<Tag>(Database.Connection);
        repository.Update(tag);
        Console.WriteLine("Tag Atualizada");
      }
      catch(Exception ex)
      {
        Console.WriteLine("Erro ao atualizar Tag");	
        Console.WriteLine(ex.Message);
      }
    }
  }
}