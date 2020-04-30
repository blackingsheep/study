using System;
using System.Collections.Generic;
using static System.Console;
namespace study
{
    class Program
    {

        static void Main(string[] args)
        {
            //事件
            EventExample.Usage();


            #region  其他类成员
            //构造函数
            MyList<string> list1 = new MyList<string>();
            MyList<string> list2 = new MyList<string>(10);
            //属性
            MyList<string> names = new MyList<string>();
            names.Capacity = 100;   // Invokes set accessor
            int i = names.Count;    // Invokes get accessor
            int j = names.Capacity; // Invokes get accessor
            //索引器
            MyList<string> names1 = new MyList<string>();
            names1.Add("Liz");
            names1.Add("Martha");
            names1.Add("Beth");
            for (int k = 0; i < names1.Count; k++)
            {
                string s = names1[i];
                names1[k] = s.ToUpper();
            }
            //事件
            //    class EventExample
            //{
            //    static int changeCount;
            //    static void ListChanged(object sender, EventArgs e)
            //    {
            //        changeCount++;
            //    }
            //    public static void Usage()
            //    {
            //        MyList<string> names = new MyList<string>();
            //        names.Changed += new EventHandler(ListChanged);
            //        names.Add("Liz");
            //        names.Add("Martha");
            //        names.Add("Beth");
            //        Console.WriteLine(changeCount);     // Outputs "3"
            //    }
            //}
            //运算符
            MyList<int> a = new MyList<int>();
            a.Add(1);
            a.Add(2);
            MyList<int> b = new MyList<int>();
            b.Add(1);
            b.Add(2);
            Console.WriteLine(a == b);  // Outputs "True"
            b.Add(3);
            Console.WriteLine(a == b);  // Outputs "False"
            #endregion



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


