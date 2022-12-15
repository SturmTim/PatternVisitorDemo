namespace ElementLib;

public class ElementA : Element
{
    public string OperationA()
    {
        Console.WriteLine("   ElementA::OperationA");
        return $"A_{Name}";
    }

    public override void Accept(Visitor visitor)
    {
        visitor.VisitA(this);
    }
}