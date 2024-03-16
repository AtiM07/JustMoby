using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ObjectElement : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _countText;
    [SerializeField] private Image _image;

    public void Init(Sprite image)
    {
        if (image)
            _image.sprite = image;
    }

    public void ChangeCollect(int count) => _countText.text = count.ToString();
}