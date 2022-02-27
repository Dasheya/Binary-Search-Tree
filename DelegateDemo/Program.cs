// See https://aka.ms/new-console-template for more information
using DelegateDemo;
using static DelegateDemo.Sample;

Console.WriteLine("Hello, World!");
Console.WriteLine("Delegate Demo");
operation1 obj = new operation1(Sample.Addition);
//Console.WriteLine("Addition is = {0}", obj.Invoke(23, 27));
MulticastDelegate1.ImplementDelegate();
Console.ReadKey();

