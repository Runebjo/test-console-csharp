public class CSharp11Features
{
  public void RawStringLiterals()
  {
    // Raw String iterals
    var json = """
    {
      "name":"John"
    }
    """;

    Console.WriteLine(json);
    Console.WriteLine();
  }
}