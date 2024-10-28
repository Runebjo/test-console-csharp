public class CSharp11Features
{
  public void RawStringLiterals()
  {
    Console.WriteLine("Testing Raw string literals....");

    var age = 43;
    // Raw String iterals
    var json = $$"""
    {
      "name":"John",
      "age": {{{age}}},
    }
    """;

    Console.WriteLine(json);
    Console.WriteLine();
  }

  public void RequiredMembers()
  {
    Console.WriteLine("Testing Required Members....");

    //var person = new Person(); This doesn't work. The required members must be set in the object initializater or attribute constructor.
    var person = new Person { Name = "John", Age = 43 };

    Console.WriteLine(person.Name);
    Console.WriteLine(person.Age);
    Console.WriteLine();
  }
}