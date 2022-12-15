namespace ElementLib;

public class ElementB : Element
{
    public int OperationB()
    {
        Console.WriteLine("   ElementB::OperationB");
        return Random.Shared.Next(10);
    }

    public override void Accept(Visitor visitor)
    {
        visitor.VisitB(this);
    }
}