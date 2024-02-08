using System.Net.Mime;
using Blog.Screens.PostScreens;
using Blog.Screens.RoleScreens;
using Blog.Screens.TagScreens;

namespace Blog.Screens
{
  public static class MainScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Meu Blog");
      Console.WriteLine("----------------------------------------");
      Console.WriteLine("Escolha uma opção");
      Console.WriteLine("----------------------------------------");
      Console.WriteLine("1 - Gestão de Usuários");
      Console.WriteLine("2 - Gestão de Perfil");
      Console.WriteLine("3 - Gestão de Categorias");
      Console.WriteLine("4 - Gestão de Tags");
      Console.WriteLine("5 - Gestão de Post");
      Console.WriteLine("0 - SAIR");
      Console.WriteLine("----------------------------------------\n");
      var option = short.Parse(Console.ReadLine());

      switch (option)
      {
        case 0:
          Environment.Exit(0);
          break;
        case 1:
          Load();
          break;
        case 2:
          MenuRoleScreen.Load();
          break;
        case 3:
          Load();
          break;
        case 4:
          MenuTagScreen.Load();
          break;
        case 5:
          MenuPostScreen.Load();
          break;
        default: Load(); break;
      }
    }
  }
}