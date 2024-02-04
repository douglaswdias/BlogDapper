using System.Diagnostics;

namespace Blog.Screens.TagScreens
{
  public static class MenuTagScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Gestão de Tags");
      Console.WriteLine("----------------------------------------");
      Console.WriteLine("Selecione uma opção abaixo");
      Console.WriteLine("----------------------------------------");
      Console.WriteLine("1 - Listar Tags");
      Console.WriteLine("2 - Cadastrar nova Tag");
      Console.WriteLine("3 - Atualizar Tag");
      Console.WriteLine("4 - Excluir Tag");
      Console.WriteLine("----------------------------------------\n");
      var option = short.Parse(Console.ReadLine()!);

      switch(option)
      {
        case 1:
          ListTagScreen.Load();
          break;
        case 2:
          CreateTagScreen.Load();
          break;
        case 3:
          UpdateTagScreen.Load();
          break;
        case 4:
          DeleteTagScreen.Load();
          break;
        Default: Load(); break;
      }
    }
  }
}