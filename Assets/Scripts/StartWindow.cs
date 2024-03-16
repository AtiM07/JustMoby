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
        //�������� ��� �������� ����. ��������� ���������� ����������
        int.TryParse(CountObject.text, out var count);

        var model = count > 5
            ? new WindowModel()
            {
                Header = "�������������� �����",
                Description = "���� ����� ��� IT-���������� ������ ������ �������� ��������� ����� �������������� ������ � ����������. ����� ���� ������ ���� � ��� �������� ����� � ������� � � ������!",
                IconName = "�������",
                Objects = new List<Object>
                {
                    new Object { Name = "����", Count = 30 },
                    new Object { Name = "����", Count = 40 },
                    new Object { Name = "����", Count = 50 }
                },
                Price = 24,
                Sale = 14
            }
            : new WindowModel()
            {
                Header = "��������� ����� ���������",
                Description = "����������� ����� ��������� ��� �������� �� �������� � �� \"����� � ����\". ������ ����� � ������� � �������!",
                IconName = "�����",
                Objects = new List<Object>
                {
                    new Object { Name = "����", Count = 100 },
                    new Object { Name = "����", Count = 60 },
                    new Object { Name = "����������", Count = 20 },
                    new Object { Name = "������", Count = 1 }
                },
                Price = 65,
                Sale = 26
            };

        GameManager.Instance.SetModelParameter(model);
        GameManager.Instance.InstanceWindow();
    }
}