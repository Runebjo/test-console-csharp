using System.Numerics;

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

  public void GenericMath()
  {
    Console.WriteLine("Testing Generic Math....");

    var result = GenericMathExample.Add(2, 3);
    Console.WriteLine(result);

    var result2 = GenericMathExample.Add(new BigInteger(2), new BigInteger(3));
    Console.WriteLine(result2);

    var floatNumber = 2.0f;
    var result3 = GenericMathExample.Add(2.0, floatNumber);
    Console.WriteLine(result3);

    Console.WriteLine();
  }

  public void ListPatterns()
  {
    Console.WriteLine("Testing List Patterns....");

    int[] numbers = [1, 2, 3];
    if (numbers is [1, 2, 3])
    {
      Console.WriteLine($"Match! {string.Join(',', numbers)}");
    }

    string[] names = ["John", "Doe"];
    if (names is ["John", "Wayne"])
    {
      Console.WriteLine($"Match! {string.Join(',', names)}");
    }
    else
    {
      Console.WriteLine($"No Match! {string.Join(',', names)}");
    }

    Console.WriteLine();
  }
}