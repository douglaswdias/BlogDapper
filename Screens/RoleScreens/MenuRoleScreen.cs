namespace Blog.Screens.RoleScreens
{
  public static class MenuRoleScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Gestão de Perfil");
      Console.WriteLine("----------------------------------------");
      Console.WriteLine("Escolha uma opção");
      Console.WriteLine("----------------------------------------");
      Console.WriteLine("1 - Listar Perfis");
      Console.WriteLine("2 - Cadastrar Novo Perfil");
      Console.WriteLine("3 - Atualizar Perfil");
      Console.WriteLine("4 - Excluir Perfil");
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
          ListRoleScreen.Load();
          break;
        case 2:
          CreateRoleScreen.Load();
          break;
        case 3:
          UpdateRoleScreen.Load();
          break;
        case 4:
          DeleteRoleScreen.Load();
          break;
        case 5:
          MainScreen.Load();
          break;
        default: Load(); break;
      }
    }
  }
}