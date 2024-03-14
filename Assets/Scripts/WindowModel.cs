using System.Collections.Generic;
using UnityEngine.Events;

public class WindowModel
{
    private string Header { get; set; }
    private string Description { get; set; }
    private Dictionary<string, int> Objects { get; set; }
    private decimal Price { get; set; }
    private decimal Sale { get; set; }
    private string IconName { get; set; }

    public UnityEvent onButtonClick;
    
    public WindowModel(string header, string description, Dictionary<string, int> objects, decimal price, decimal sale, string iconName)
    {
        Header = header;
        Description = description;
        Objects = objects;
        Price = price;
        Sale = sale;
        IconName = iconName;
    }
}
