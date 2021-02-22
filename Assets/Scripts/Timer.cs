using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI countDownTimer;
    private float counter = 400;

    // Start is called before the first frame update
    void Start()
    {
        countDownTimer.text = $"{counter}";
    }
    public void runTimer()
    {
        counter -= Time.deltaTime;
        countDownTimer.text = $"{Mathf.Round(counter)}";
    }
}
