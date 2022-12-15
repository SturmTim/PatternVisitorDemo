namespace ElementLib;

public interface Visitor
{
    void VisitA(ElementA element);
    void VisitB(ElementB element);
}