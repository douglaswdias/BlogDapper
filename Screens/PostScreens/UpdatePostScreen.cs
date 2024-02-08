using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.PostScreens
{
  public static class UpdatePostScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Atualizar Tag");
      Console.WriteLine("----------------------------------------");
      Console.Write("Id do Post a ser atualizado: ");
      var id = Console.ReadLine();
      Console.Write("Titulo do Post: ");
      var title = Console.ReadLine();
      Console.Write("Resumo: ");
      var summary = Console.ReadLine();
      Console.Write("Slug: ");
      var slug = Console.ReadLine();
      Console.Write("Id da Categoria: ");
      var categoryId = Console.ReadLine();
      Console.Write("Id do Autor: ");
      var authorId = Console.ReadLine();
      Console.Write("Corpo do Post: ");
      var body = Console.ReadLine();
      Update(new Post
      {
        Id = int.Parse(id),
        Title = title,
        Summary = summary,
        Slug = slug,
        CategoryId = int.Parse(categoryId),
        AuthorId = int.Parse(authorId),
        Body = body
      });
      Console.WriteLine("Pressione uma tecla para voltar");
      Console.ReadKey();
      MenuPostScreen.Load();
    }

    public static void Update(Post post)
    {
      try
      {
        var repository = new Repository<Post>(Database.Connection);
        repository.Update(post);
        Console.WriteLine("Post Atualizado");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Erro ao Atualizar");
        Console.WriteLine(ex.Message);
      }
    }
  }
}