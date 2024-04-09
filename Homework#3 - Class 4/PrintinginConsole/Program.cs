using PrintinginConsole;
using System.Collections.Generic;

PrintInConsole.Print("This is an app for printing in console");
PrintInConsole.Print(78);
PrintInConsole.Print(5.49);

var listExample = new List<int> { 8, 12, 36, 83, 23, 67 };
var queue = new Queue<string>();
queue.Enqueue("First");
queue.Enqueue("Second");
queue.Enqueue("Third");
var dictionary = new Dictionary<string, int> { { "prv", 22 }, { "vtor", 23 }, { "tret", 24 } };

PrintInConsole.PrintCollection(listExample);
PrintInConsole.PrintCollection(queue);
PrintInConsole.PrintCollection(dictionary);