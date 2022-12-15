namespace ElementLibWithoutVisitor;

public class ElementB : Element
{
  private readonly Random _random = new();

  public int OperationB()
  {
    Console.WriteLine("   ElementB::OperationB");
    return _random.Next(10);
  }

  public override int OperationX() => OperationB() * 3;
  public override string OperationY() => Name.ToUpper();
}
