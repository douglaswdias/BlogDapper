namespace Blog.Screens.UserScreens
{
  public static class MenuUserScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Gestão de Usuários");
      Console.WriteLine("----------------------------------------");
      Console.WriteLine("Selecione uma opção abaixo");
      Console.WriteLine("----------------------------------------");
      Console.WriteLine("1 - Listar Usuários");
      Console.WriteLine("2 - Criar novo Usuário");
      Console.WriteLine("3 - Atualizar Usuário");
      Console.WriteLine("4 - Excluir Usuário");
      Console.WriteLine("5 - Voltar para Menu");
      Console.WriteLine("0 - SAIR");
      Console.WriteLine("----------------------------------------\n");
      var option = short.Parse(Console.ReadLine());

      switch (option)
      {
        case 0:
          Environment.Exit(0);
          break;
        case 1:
          ListUserScreen.Load();
          break;
        case 2:
          CreateUserScreen.Load();
          break;
        case 3:
          UpdateUserScreen.Load();
          break;
        case 4:
          DeleteUserScreen.Load();
          break;
        case 5:
          MainScreen.Load();
          break;
        default: Load(); break;
      }
    }
  }
}