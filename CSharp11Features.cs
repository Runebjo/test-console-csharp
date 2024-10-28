public class CSharp11Features
{
  public void RawStringLiterals()
  {
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
}