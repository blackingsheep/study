using System;
using System.Collections.Generic;
using static System.Console;
namespace study
{
    //此项目计划严格按照MSDN的顺序编写 
    class Program
    {
        #region 数据定义
        private static DailyTemperature[] data = new DailyTemperature[]
{
    new DailyTemperature(HighTemp: 57, LowTemp: 30),
    new DailyTemperature(60, 35),
    new DailyTemperature(63, 33),
    new DailyTemperature(68, 29),
    new DailyTemperature(72, 47),
    new DailyTemperature(75, 55),
    new DailyTemperature(77, 55),
    new DailyTemperature(72, 58),
    new DailyTemperature(70, 47),
    new DailyTemperature(77, 59),
    new DailyTemperature(85, 65),
    new DailyTemperature(87, 65),
    new DailyTemperature(85, 72),
    new DailyTemperature(83, 68),
    new DailyTemperature(77, 65),
    new DailyTemperature(72, 58),
    new DailyTemperature(77, 55),
    new DailyTemperature(76, 53),
    new DailyTemperature(80, 60),
    new DailyTemperature(85, 66)
};
        #endregion
        static void Main(string[] args)
        {
            #region 入门
            #region  其他类成员
            ////构造函数
            //MyList<string> list1 = new MyList<string>();
            //MyList<string> list2 = new MyList<string>(10);
            ////属性
            //MyList<string> names = new MyList<string>();
            //names.Capacity = 100;   // Invokes set accessor
            //int i = names.Count;    // Invokes get accessor
            //int j = names.Capacity; // Invokes get accessor
            ////索引器
            //MyList<string> names1 = new MyList<string>();
            //names1.Add("Liz");
            //names1.Add("Martha");
            //names1.Add("Beth");
            //for (int k = 0; i < names1.Count; k++)
            //{
            //    string s = names1[i];
            //    names1[k] = s.ToUpper();
            //}
            ////运算符
            //MyList<int> a = new MyList<int>();
            //a.Add(1);
            //a.Add(2);
            //MyList<int> b = new MyList<int>();
            //b.Add(1);
            //b.Add(2);
            //Console.WriteLine(a == b);  // Outputs "True"
            //b.Add(3);
            //Console.WriteLine(a == b);  // Outputs "False"
            ////事件
            //EventExample.Usage();
            #endregion

            #endregion
            #region 教程

            #region 类简介,面对对象的编程——银行类测试

            //var giftCard = new GiftCardAccount("gift card", 100, 50);
            //giftCard.MakeWithdrawal(20, DateTime.Now, "get expensive coffee");
            //giftCard.MakeWithdrawal(50, DateTime.Now, "buy groceries");
            //giftCard.PerformMonthEndTransactions();
            //// can make additional deposits:
            //giftCard.MakeDeposit(27.50m, DateTime.Now, "add some additional spending money");
            //Console.WriteLine(giftCard.GetAccountHistory());

            //var savings = new InterestEarningAccount("savings account", 10000);
            //savings.MakeDeposit(750, DateTime.Now, "save some money");
            //savings.MakeDeposit(1250, DateTime.Now, "Add more savings");
            //savings.MakeWithdrawal(250, DateTime.Now, "Needed to pay monthly bills");
            //savings.PerformMonthEndTransactions();
            //Console.WriteLine(savings.GetAccountHistory());


            //var account = new BankAccount("zdy", 10000);
            //Console.WriteLine($"account {account.Number} was create" +
            //    $" for {account.Owner} with {account.Balance} initial balance.");
            //account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            //Console.WriteLine(account.Balance);
            //account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            //Console.WriteLine(account.Balance);
            //// Test that the initial balances must be positive.
            //try
            //{
            //    var invalidAccount = new BankAccount("invalid", -55);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught creating account with negative balance");
            //    Console.WriteLine(e.ToString());
            //}

            //Console.WriteLine(account.GetAccountHistory());



            #endregion
            #region 浏览记录类型
            //foreach (var item in data)
            //    Console.WriteLine(item);
            //var heatingDegreeDays = new HeatingDegreeDays(65, data);
            //Console.WriteLine(heatingDegreeDays);

            //var coolingDegreeDays = new CoolingDegreeDays(65, data);
            //Console.WriteLine(coolingDegreeDays);
            //// Growing degree days measure warming to determine plant growing rates
            //var growingDegreeDays = coolingDegreeDays with { BaseTemperature = 41 };
            //Console.WriteLine(growingDegreeDays);
            //// showing moving accumulation of 5 days using range syntax
            //List<CoolingDegreeDays> movingAccumulation = new();
            //int rangeSize = (data.Length > 5) ? 5 : data.Length;
            //for (int start = 0; start < data.Length - rangeSize; start++)
            //{
            //    var fiveDayTotal = growingDegreeDays with { TempRecords = data[start..(start + rangeSize)] };
            //    movingAccumulation.Add(fiveDayTotal);
            //}
            //Console.WriteLine();
            //Console.WriteLine("Total degree days in the last five days");
            //foreach (var item in movingAccumulation)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 探索顶级语句
            //免去一个文件中的 方法，类，命名空间信息，类似于直接在方法中写代码
            //理论只在写小控制台测试程序时有空，实际毫无用处
            #endregion
            #region 探索对象中的模式

            #endregion
            #endregion
            #region 新增功能
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
            #endregion
            #region 概念
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


