using System;
using System.Collections.Generic;
using System.Text;

namespace study
{
    class EventExample
    {
        static int changeCount;
        static void ListChanged(object sender, EventArgs e)
        {
            changeCount++;
        }
        public static void Usage()
        {
            MyList<string> names = new MyList<string>();
            names.Changed += new EventHandler(ListChanged);
            names.Add("Liz");
            names.Add("Martha");
            names.Add("Beth");
            Console.WriteLine(changeCount);     // Outputs "3"
        }
    }
}
