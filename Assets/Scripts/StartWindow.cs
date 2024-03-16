using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StartWindow : MonoBehaviour
{
    [SerializeField] private Button StartButton;
    [SerializeField] private TextMeshProUGUI CountObject;

    private void Start()
    {
        StartButton.onClick.AddListener(OpenWindow);
    }

    private void OpenWindow()
    {
        //заглушка для открытия окна. заполнить рандомными значениями
        int.TryParse(CountObject.text, out var count);

        var model = count > 5
            ? new WindowModel()
            {
                Header = "Энергетический набор",
                Description = "Этот набор для IT-пециалиста спасет любого понурого работника сферы информационных систем и технологий. Всего пара кружек кофе и ваш работник будет в ресурсе и в потоке!",
                IconName = "зарядка",
                Objects = new List<Object>
                {
                    new Object { Name = "кофе", Count = 30 },
                    new Object { Name = "кофе", Count = 40 },
                    new Object { Name = "кофе", Count = 50 }
                },
                Price = 24,
                Sale = 14
            }
            : new WindowModel()
            {
                Header = "Стартовый набор айтишника",
                Description = "Необходимый набор предметов для человека со статусом в ВК \"Войти в айти\". Темные круги и недосып в подарок!",
                IconName = "набор",
                Objects = new List<Object>
                {
                    new Object { Name = "кофе", Count = 100 },
                    new Object { Name = "очки", Count = 60 },
                    new Object { Name = "клавиатура", Count = 20 },
                    new Object { Name = "деньги", Count = 1 }
                },
                Price = 65,
                Sale = 26
            };

        GameManager.Instance.SetModelParameter(model);
        GameManager.Instance.InstanceWindow();
    }
}