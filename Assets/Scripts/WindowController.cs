using UnityEngine;

public class WindowController : MonoBehaviour
{
    private WindowModel Model { get; set; }
    private WindowView View { get; set; }
    
    public WindowController(WindowModel model, WindowView view)
    {
        Model = model;
        View = view;
        
        //подписка от ивена модел на метод во вью
    }
}
