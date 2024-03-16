using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Класс для окна с данными
/// </summary>
public class WindowView : MonoBehaviour
{
    [SerializeField] private TMP_Text Header;
    [SerializeField] private TextMeshProUGUI Description;
    [SerializeField] private TextMeshProUGUI Price;
    [SerializeField] private TextMeshProUGUI RealPrice;
    [SerializeField] private TextMeshProUGUI Sale;
    [SerializeField] public Image MainIicon;
    [SerializeField] private Sprite[] _itemsImages;
    
    [SerializeField] private Button BuyButton;

    private void Start()
    {
        var model = GameManager.Instance.Model;
        Header.text = model.Header;
        Description.text = model.Description;
        SetPrice(RealPrice, GetRealPrice(model.Price, model.Sale));
        SetPrice(Price, model.Price);
        SetSale(model.Sale);
        SetMainIcon(model.IconName);
        
        BuyButton.onClick.AddListener(() =>
        {
            GameManager.Instance.InstanceInfoPanel("По FaceID было списано с Вашего счета 1000$. Спасибо!");
            DestroyImmediate(gameObject);
        });
    }

    private void SetSale(decimal sale) => Sale.text = sale + "%";
    private void SetPrice(TextMeshProUGUI text, decimal price) => text.text = "$" + price;
    
    private decimal GetRealPrice(decimal price, decimal sale) => price*(1-sale/100);

    private void SetMainIcon(string nameElement)
    {
        MainIicon.sprite = _itemsImages.FirstOrDefault(x => x.name == nameElement);
    }
}