//using ElementLib;
//using VisitorLib;
using ElementLibWithoutVisitor;


List<Element> elements = CreateElements(10);
LoopWithoutVisitors();
//LoopWithVisitors();
Console.ReadLine();

List<Element> CreateElements(int nr)
{
  Console.WriteLine($"CreateElements: {nr} instances");
  var elements = new List<Element>();
  for (int i = 0; i < nr; i++)
  {
    string name = $"Ele_{i}";
    if (i % 2 == 0) elements.Add(new ElementA { Name = name });
    else elements.Add(new ElementB { Name = name });
  }
  return elements;
}

void LoopWithoutVisitors()
{
  int value = 0;
  foreach (var item in elements)
  {
    int val = item.OperationX();
    value += val;
  }
  Console.WriteLine($"OperationX: {value}");
  Console.WriteLine("---------------------------------------------");

  var names = new List<string>();
  foreach (var item in elements)
  {
    string s = item.OperationY();
    names.Add(s);
  }
  string result = string.Join(";", names);
  Console.WriteLine($"OperationY: {result}");
}

void LoopWithVisitors()
{
}

