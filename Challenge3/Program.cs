
using Challenge3;

var obj1 = new { a = new { b = new { c = "d" } } };
var obj2 = new { x = new { y = new { z = "a" } } };

    string key1 = "a/b/c";
    string key2 = "x/y/z";
    
    var value1 = GetValueByKey.GetValueByKeymathod(obj1, key1);
    var value2 = GetValueByKey.GetValueByKeymathod(obj2, key2);

    Console.WriteLine("Value 1: " + value1);
    Console.WriteLine("Value 2: " + value2);
