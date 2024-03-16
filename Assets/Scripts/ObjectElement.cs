using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Экземпляр предмета
/// </summary>
public class ObjectElement : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _countText;
    [SerializeField] private Image _image;

    public void Init(Sprite image)
    {
        if (image)
        {
            _image.sprite = image;
            gameObject.name = image.name;
        }
    }

    public void ChangeCollect(int count) => _countText.text = count.ToString();
}