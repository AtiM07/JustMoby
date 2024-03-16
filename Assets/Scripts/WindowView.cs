using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ����� ��� ���� � �������
/// </summary>
public class WindowView : MonoBehaviour
{
    [SerializeField] private TMP_Text Header;
    [SerializeField] private TextMeshProUGUI Description;
    [SerializeField] private TextMeshProUGUI Price;
    [SerializeField] private TextMeshProUGUI RealPrice;
    [SerializeField] private TextMeshProUGUI Sale;
    [SerializeField] public Image MainIicon;
    [SerializeField] private Icons _itemsImages;
    
    [SerializeField] private Button BuyButton;

    private void Start()
    {
        var model = GameManager.Instance.Model;
        Header.text = model.Header;
        Description.text = model.Description;
        if (model.Sale > 0)
        {
            SetPrice(Price, model.Price);
            SetPrice(RealPrice, GetRealPrice(model.Price, model.Sale));
            SetSale(model.Sale);
        }
        else
        {
            SetPrice(RealPrice, model.Price);
            ClearSale();
        }
        
        SetMainIcon(model.IconName);
        
        BuyButton.onClick.AddListener(() =>
        {
            GameManager.Instance.InstanceInfoPanel("�� FaceID ���� ������� � ������ ����� 1000$. �������!");
            DestroyImmediate(gameObject);
        });
    }

    private void SetSale(decimal sale) => Sale.text = sale + "%";
    private void SetPrice(TextMeshProUGUI text, decimal price) => text.text = "$" + price;
    
    private decimal GetRealPrice(decimal price, decimal sale) => price*(1-sale/100);

    private void SetMainIcon(string nameElement)
    {
        MainIicon.sprite = _itemsImages.MainIconImes.FirstOrDefault(x => x.name == nameElement);
        MainIicon.gameObject.name = MainIicon.sprite!.name;
    }

    //�������� �� ��������� ������
    private void ClearSale()
    {
        Destroy(Sale.transform.parent.gameObject);
        Destroy(Price.gameObject);
        RealPrice.gameObject.transform.position = BuyButton.transform.position;
    }
}