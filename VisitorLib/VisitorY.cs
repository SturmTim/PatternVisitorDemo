using ElementLib;

namespace VisitorLib;

public class VisitorY : Visitor
{
    
    public List<string> Names = new();
    
    public void VisitA(ElementA element)
    {
        Names.Add($"__{element.OperationA()}__");
    }

    public void VisitB(ElementB element)
    {
        Names.Add(element.Name.ToUpper());
    }
}