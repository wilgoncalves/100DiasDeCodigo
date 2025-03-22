using System.Collections.Generic;

// Conjuntos: HashSet<T> e SortedSet<T>

// HashSet: não admite repetições e elementos não possuem posição.
HashSet<string> set = new HashSet<string>();

set.Add("TV");
set.Add("Notebook");
set.Add("Tablet");

Console.WriteLine(set.Contains("Notebook"));

foreach (string item in set)
{
    Console.WriteLine(item);
}

// SortedSet: os elementos são armazenados ordenadamente conforme implementação IComparer<T>.
SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

// Union
SortedSet<int> c = new SortedSet<int>(a);
c.UnionWith(b);
PrintCollection(c);

// Intersection
SortedSet<int> d = new SortedSet<int>(a);
d.IntersectWith(b);
PrintCollection(d);

// Difference
SortedSet<int> e = new SortedSet<int>(a);
e.ExceptWith(b);
PrintCollection(e);

static void PrintCollection<T>(IEnumerable<T> collection)
{
    foreach (T item in collection)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}


