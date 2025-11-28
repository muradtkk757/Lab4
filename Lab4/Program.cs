#region Quiz 1
//namespace Lab4
//{
////    public class Program
////    {
////        static void Main()
////        {
////            Student student = new Student { };
////            student.Name = Console.ReadLine();
////            student.age = int.Parse(Console.ReadLine()!);


////            Console.WriteLine("Ad: " + student.Name);
////            Console.WriteLine("Yash: " + student.age);
////        }
////    }
////}
#endregion

#region Quiz 2
//namespace Lab4
//{
//    public class Program
//    {
//        static void Main()
//        {

//            BankAccount account = new BankAccount();
//            Console.WriteLine("Balance : " + account.GetBalance());
//            account.Deposit(30);
//            Console.WriteLine("------");
//            Console.WriteLine("Balance : " + account.GetBalance()!);
//        }
//    }
//}
#endregion

#region Quiz  3
//namespace Lab4
//{
//    class Program
//    {
//        static void Main()
//        {
//            MathTools m = new MathTools();

//            Console.Write("Birinci Ededi daxil edin: ");
//            int a = int.Parse(Console.ReadLine()!);

//            Console.Write("İkinci Ededi daxil edin: ");
//            int b = int.Parse(Console.ReadLine()!);

//            Console.WriteLine("Add: " + m.Add(a, b));
//            Console.WriteLine("Subtract" + m.Subtract(a, b));
//            Console.WriteLine("Multiply: " + m.Multiply(a, b));
//        }
//    }
//}
#endregion

#region Quiz  4
//namespace Lab4
//{
//    class Program
//    {
//        static void Main()
//        {

//            Book myBook = new Book();

//            Console.WriteLine("Title:");
//            myBook.Title = (Console.ReadLine()!);
//            Console.WriteLine("Author name:");
//            myBook.Author = (Console.ReadLine()!);
//            Console.WriteLine("Pages:");
//            myBook.Pages = int.Parse(Console.ReadLine()!);



//            Console.WriteLine("Title:" + myBook.Title);
//            Console.WriteLine("Author:" + myBook.Author);
//            Console.WriteLine("Pages:" + myBook.Pages);
//        }
//    }
//}
#endregion

#region Quiz  5
//namespace Lab4
//{
//class Program
//{
//    static void Main()
//    {
//        User user = new User();

//        Console.Write("Enter password: ");
//        string pass = Console.ReadLine();

//        user.Password = pass;

//        Console.WriteLine("Current password value: " + user.Password);
//    }
//}
//}
#endregion

#region Quiz  6
//namespace Lab4
//{
//public class Program
//  {
//  static void Main(string[] args)
//      {
//        Product p = new Product();
//        p.AddStock(50);
//        p.Sell(20);
//        Console.WriteLine(p.Stock);
//       }
//  }
//}
#endregion

#region Quiz 7
//namespace Lab4
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int x = 5;
//            Helper.Increase(ref x);
//            Console.WriteLine(x);
//        }
//    }
//}
#endregion

#region Quiz 8
//namespace Lab4
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int r;
//            bool ok = Divider.TryDivide(10, 2, out r);

//            if (ok)
//                Console.WriteLine(r);
//            else
//                Console.WriteLine("Cannot divide");
//        }
//    }
//}
#endregion