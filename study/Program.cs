using System;
using System.Collections.Generic;
using static System.Console;
namespace study
{
    class Program
    {

        static void Main(string[] args)
        {




            #region  .NET 6.0 新特性
            #region  初始化索引及内容
            //var messages = new Dictionary<int, string>
            //{
            //    [404] = "Page not Found",
            //    [302] = "Page moved, but left a forwarding address.",
            //    [500] = "The web server can't come out to play today."
            //};
            #endregion
            #region name of
            //Console.WriteLine(nameof(System.String));
            //int j = 5;
            //Console.WriteLine(nameof(j));
            //List<string> names = new List<string>();
            //Console.WriteLine(nameof(names));
            #endregion
            #region  异常筛选
            //try
            //{
            //    string s = null;
            //    Console.WriteLine(s.Length);

            //}
            //catch (Exception e) when (LogException(e))
            //{
            //}
            //Console.WriteLine("Exception must have been handled");
            #endregion
            #region  ?. 
            //string s = null;
            //int? ls = s?.Length;
            //int? ls1 = 2 + ls;
            //Console.WriteLine(s?.Length);
            //char? c = s?[0];
            //Console.WriteLine(c.HasValue);
            //Write(c.Value);
            #endregion
            #region 人类
            //Person person = new Person("1", "9", "3");

            //WriteLine("The name, in all caps: " + person.AllCaps());
            //WriteLine("The name: " + person);
            #endregion
            #region   银行类
            //var account = new BankAccount("<name>", 1000);
            //Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

            //account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            //Console.WriteLine(account.Balance);
            //account.MakeDepoist(100, DateTime.Now, "Friend paid me back");
            //Console.WriteLine(account.Balance);

            //try
            //{
            //    var invalidAccount = new BankAccount("invalid", -55);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught creating account with negative balance");
            //    Console.WriteLine(e.ToString());
            //}

            //// Test for a negative balance.
            //try
            //{
            //    account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
            //}
            //catch (InvalidOperationException e)
            //{
            //    Console.WriteLine("Exception caught trying to overdraw");
            //    Console.WriteLine(e.ToString());
            //}

            //Console.WriteLine(account.GetAccountHistory());
            #endregion
            #endregion 
        }
        //异常返回判断方法
        private static bool LogException(Exception e)
        {
            Console.WriteLine($"\tIn the log routine. Caught {e.GetType()}");
            Console.WriteLine($"\tMessage: {e.Message}");
            return true ;
        }
    }
}


