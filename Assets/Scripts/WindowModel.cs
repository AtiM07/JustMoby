using System.Collections.Generic;

/// <summary>
/// Данные окна
/// </summary>
public class WindowModel
{
    public string Header { get; set; }
    public string Description { get; set; }
    public List<Object> Objects { get; set; }
    public decimal Price { get; set; }
    public decimal Sale { get; set; }
    public string IconName { get; set; }
}

/// <summary>
/// Предмет из массива для окна
/// </summary>
public class Object
{
    public string Name;
    public int Count;
}