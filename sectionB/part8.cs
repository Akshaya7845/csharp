//aceess modifiers
//public
/*using System;

class Demo
{
    public string name = "Akshaya";
}

class Program
{
    static void Main(string[] args)
    {
        Demo d = new Demo();
        Console.WriteLine(d.name); 
    }
}
*/
//private
using System;

class Demo
{
    private string secret = "Hidden";
    public void Show()
    {
        Console.WriteLine(secret);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Demo d = new Demo();

        // access private field using a public method
        d.Show();  
    }
}
