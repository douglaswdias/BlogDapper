using Blog.Models;
using Blog.Repository;

namespace Blog.Screens.PostScreens
{
  public static class CreatePostScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Novo Post Screen");
      Console.WriteLine("----------------------------------------");
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

      Create(new Post
      {
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

    public static void Create(Post post)
    {
      try
      {
        var repository = new Repository<Post>(Database.Connection);
        repository.Create(post);
        Console.WriteLine("Post Criado");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Erro ao criar Post");
        Console.WriteLine(ex.Message);
      }
    }
  }
}