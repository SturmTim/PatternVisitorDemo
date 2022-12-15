namespace ElementLib;

public abstract class Element
{
    public abstract void Accept(Visitor visitor);
    public string Name { get; set; }
}