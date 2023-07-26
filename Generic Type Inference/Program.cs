using System;

//ref link:https://www.youtube.com/watch?v=sS2JmK3tYLc&list=PLRwVmtr-pp05ETzLYQ8kv1cI5v9ddT8er&index=8
//

class MyClass<T>
{
    public MyClass(T arg)
    {
        
    }
}

class MainClass
{
    static void P<T>(T item) { Console.WriteLine(item); }
    static void Main()
    {
        MyClass<int> m = new MyClass<int>(5);
        P(5);
        P("Kulpot");
        //P<string>("Kulpot");  //explicit
        P("potKul");
    }
}