namespace Blog.Screens.PostScreens
{
  public static class MenuPostScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Gestão de Posts");
      Console.WriteLine("----------------------------------------");
      Console.WriteLine("Selecione uma opção abaixo");
      Console.WriteLine("----------------------------------------");
      Console.WriteLine("1 - Listar Posts");
      Console.WriteLine("2 - Criar novo Post");
      Console.WriteLine("3 - Atualizar Post");
      Console.WriteLine("4 - Excluir Post");
      Console.WriteLine("5 - Voltar para Menu");
      Console.WriteLine("0 - SAIR");
      Console.WriteLine("----------------------------------------\n");
      var option = short.Parse(Console.ReadLine()!);

      switch(option)
      {
        case 0:
          Environment.Exit(0);
          break;
        case 1:
          ListPostScreen.Load();
          break;
        case 2:
          CreatePostScreen.Load();
          break;
        case 3:
          UpdatePostScreen.Load();
          break;
        case 4:
          DeletePostScreen.Load();
          break;
        case 5:
          MainScreen.Load();
          break;
        default: Load(); break;
      }
    }
  }
}