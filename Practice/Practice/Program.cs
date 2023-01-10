


using Practice;
using Practice.Controllers;
using System.Reflection;

#region Indexer

//Book book1 = new Book() { Id = 1, Name = "Leyli ve Mecnun" };
//Book book2 = new Book() { Id = 2, Name = "Xemse" };


//Library library = new();
//library[0] = book1;
//library[1] = book2;
//Console.WriteLine(library[0].Name);
//Console.WriteLine(library[1].Name);

#endregion

#region Reflection

//Assembly assembly = Assembly.GetExecutingAssembly();

//foreach (var item in assembly.GetTypes())
//{
//    foreach (var item1 in item.GetMembers())
//    {
//        Console.WriteLine(item1);
//    }
//}

#endregion



AccountControllers account =new AccountControllers();
account.Register();