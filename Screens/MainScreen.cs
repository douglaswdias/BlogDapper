using System.Net.Mime;
using Blog.Screens.TagScreens;

namespace Blog.Screens
{
  public class MainScreen
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
      Console.WriteLine("5 - Gestão de Perfil/Usuário");
      Console.WriteLine("6 - Gestão de Post/Tag");
      Console.WriteLine("7 - Relatórios");
      Console.WriteLine("0 - SAIR");
      Console.WriteLine("----------------------------------------\n");
      var option = short.Parse(Console.ReadLine()!);

      switch (option)
      {
        case 0:
          Environment.Exit(0);
          break;
        case 4:
          MenuTagScreen.Load();
          break;
        default: Load(); break;
      }
    }
  }
}