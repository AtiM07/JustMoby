using System.Collections;
using TMPro;
using UnityEngine;

public class InfoPanel : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI MessageText;
    [SerializeField] private double EndTime = 10;

    public void SetMessage(string message) => MessageText.text = message;

    private void Start()
    {
        StartCoroutine(StartTimer());
    }
    
    private IEnumerator StartTimer()
    {
        while (EndTime > 0)
        {
            EndTime -= Time.deltaTime;
            yield return null;
        }
        Destroy(gameObject);
    }
}
