using System;
using System.Collections.Generic;

class Groceries {
    static void Main() {
        List<string> items = new List<string>() {
            "Milk",
            "Eggs",
            "Bread",
            "Butter",
            "Rice"
        };

        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}
