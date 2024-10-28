using System.Numerics;

public class GenericMathExample
{
  public static T Add<T>(T a, T b) where T : INumber<T>
  {
    return a + b;
  }

  public static int Add2(int a, int b)
  {
    return a + b;
  }
}