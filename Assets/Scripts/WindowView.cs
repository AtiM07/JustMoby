using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class WindowView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Header;
    [SerializeField] private TextMeshProUGUI Description;
    [SerializeField] private TextMeshProUGUI Price;
    [SerializeField] private TextMeshProUGUI RealPrice;
    [SerializeField] private TextMeshProUGUI Sale;
    [SerializeField] public Image MainIicon;
    [SerializeField] private Sprite[] _itemsImages;

    public UnityEvent Init;

    private void Start()
    {
        var model = GameManager.Instance.Model;
        Header.text = model.Header;
        Description.text = model.Description;
        SetPrice(RealPrice, GetRealPrice(model.Price, model.Sale));
        SetPrice(Price, model.Price);
        SetSale(model.Sale);
        SetMainIcon(model.IconName);
        Init.Invoke();
    }

    private void SetSale(decimal sale) => Sale.text = sale + "%";
    private void SetPrice(TextMeshProUGUI text, decimal price) => text.text = "$" + price;
    
    private decimal GetRealPrice(decimal price, decimal sale) => price*(1-sale/100);

    private void SetMainIcon(string nameElement)
    {
        MainIicon.sprite = _itemsImages.FirstOrDefault(x => x.name == nameElement);
    }
}