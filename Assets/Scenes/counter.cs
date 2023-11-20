using UnityEngine;
using UnityEngine.UI;

public class CounterScript : MonoBehaviour
{
    public Text counterText;
    private int counter;

    public int initialCount = 10;

    void Start()
    {
        counter = initialCount;
        UpdateCounterText();

    }

    void UpdateCounterText()
    {
        counterText.text = "—четчик: " + counter.ToString();
    }

    void OnTriggerEnter(Collider obj)
    {
        if (obj.CompareTag("cube"))
        {
            counter--;
            UpdateCounterText();
        }
    }
}