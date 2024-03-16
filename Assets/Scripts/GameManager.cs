using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public WindowModel Model { get; private set; }
    
    [SerializeField] private GameObject WindowPanel;

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
}