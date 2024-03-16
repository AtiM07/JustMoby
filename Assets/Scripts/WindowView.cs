using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class WindowView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Header;
    [SerializeField] private TextMeshProUGUI Description;
    [SerializeField] private TextMeshProUGUI Price;
    [SerializeField] private TextMeshProUGUI Sale;

    public UnityEvent Init;

    private void Start()
    {
        var model = GameManager.Instance.Model;
        Header.text = model.Header;
        Description.text = model.Description;
        Price.text = model.Price.ToString();
        Sale.text = model.Sale.ToString();
        Init.Invoke();
    }
}