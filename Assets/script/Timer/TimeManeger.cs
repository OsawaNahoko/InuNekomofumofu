using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManeger : MonoBehaviour
{
    public float now   = 10f;
    string TimeCount;
    public GameObject ClearWindow;

    public Text TimerText;

    void Start()
    {
        TimerText = TimerText.GetComponent<Text>();
    }

    void FixedUpdate()
    {
        if(now >= 0f)
        {
            now -= Time.deltaTime;
            
        // もし now が 0 未満に下がっていたら、0 に固定する
        if (now < 0f)
        {
            now = 0f;
            ClearWindow.SetActive(true);
        }
            TimeCount = now.ToString("F2");
            TimerText.text = TimeCount;
        }
    
    }
}
