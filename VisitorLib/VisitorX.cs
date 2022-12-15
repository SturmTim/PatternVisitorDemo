using ElementLib;

namespace VisitorLib;

public class VisitorX : Visitor
{
    public int Value { get; private set; } = 0;

    public void VisitA(ElementA element)
    {
        int val = element.Name.Length / 2;
        Value += val;
    }

    public void VisitB(ElementB element)
    {
        int val = element.OperationB() * 3;
        Value += val;
    }
}