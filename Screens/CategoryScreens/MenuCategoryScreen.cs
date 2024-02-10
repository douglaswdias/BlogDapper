namespace Blog.Screens.CategoryScreens
{
  public static class MenuCategoryScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Gestão de Categorias");
      Console.WriteLine("----------------------------------------");
      Console.WriteLine("Selecione uma opção abaixo");
      Console.WriteLine("----------------------------------------");
      Console.WriteLine("1 - Listar Categorias");
      Console.WriteLine("2 - Criar nova Categoria");
      Console.WriteLine("3 - Atualizar Categoria");
      Console.WriteLine("4 - Excluir Categoria");
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
          ListCategoryScreen.Load();
          break;
        case 2:
          CreateCategoryScreen.Load();
          break;
        case 3:
          UpdateCategoryScreen.Load();
          break;
        case 4:
          DeleteCategoryScreen.Load();
          break;
        case 5:
          MainScreen.Load();
          break;
        default: Load(); break;
      }
    }
  }
}