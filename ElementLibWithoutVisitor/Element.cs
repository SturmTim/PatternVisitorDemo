namespace ElementLibWithoutVisitor;

public abstract class Element
{
  public string Name { get; set; } = null!;
  public abstract int OperationX();
  public abstract string OperationY();
}
