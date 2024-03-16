using System.Collections.Generic;

public class WindowModel
{
    public string Header { get; set; }
    public string Description { get; set; }
    public List<Object> Objects { get; set; }
    public decimal Price { get; set; }
    public decimal Sale { get; set; }
    public string IconName { get; set; }
}

public class Object
{
    public string Name;
    public int Count;
}