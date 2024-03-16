using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public WindowModel Model { get; private set; }
    
    [SerializeField] private GameObject WindowPanel;
    
    [SerializeField] private GameObject InfoPanel;

    private void Awake()
    {
        Instance = this;
        Model = new WindowModel();
    }

    public void SetModelParameter(WindowModel model)
    {
        Model = model;
    }

    public void InstanceWindow()
    {
        Instantiate(WindowPanel, Vector3.zero, Quaternion.identity, transform.parent);
    }
    
    public void InstanceInfoPanel(string message)
    {
        var gameObj = Instantiate(InfoPanel, Vector3.zero, Quaternion.identity, transform.parent);
        gameObj.GetComponent<InfoPanel>().SetMessage(message);
    }
}