using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObjectPanel : MonoBehaviour
{ 
        [SerializeField] private ObjectElement _elementPrefab;
        [SerializeField] private Sprite[] _itemsImages;

        private List<ObjectElement> _elements;
        private List<Object> Objects { get; set; }

        private void Awake()
        {
            Objects = GameManager.Instance.Model.Objects;
            Init(Objects);
        }

        private void Init(List<Object> elements)
        {
            _elements = new List<ObjectElement>();
            foreach (var element in elements)
            {
                var newElement = Instantiate(_elementPrefab, transform);
                _elements.Add(newElement);
                newElement.Init(GetIconImage(element.Name));
                newElement.ChangeCollect(element.Count);
            }
        }

        private Sprite GetIconImage(string nameElement) => _itemsImages.FirstOrDefault(itemsImage => itemsImage.name == nameElement);
    }