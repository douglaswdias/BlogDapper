using Blog;
using Blog.Screens;

Database.Connection.Open();

MainScreen.Load();

Console.ReadKey();
Database.Connection.Close();
