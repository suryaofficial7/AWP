using System;
class ExampleForEach
{
    public static void Main()
    {
        string[] str = { "Surya", "TAMIL", "சூர்யா" , "ಸೂರ್ಯ" , "സൂര്യ" , "सूर्य" , "苏里亚" };
        foreach (String s in str)
        {
            Console.WriteLine(s);
        }
        Console.ReadKey();
    }
}
