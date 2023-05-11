using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeReset : MonoBehaviour
{
    public Timecount timer;
    // Start is called before the first frame update
    void Start()
    {
        float savedTime = PlayerPrefs.GetFloat("Time"); // ����� Ÿ�̸� ���� �ҷ��ɴϴ�.
        if (savedTime > 0)
        {
            timer.timeLeft = savedTime; // �ҷ��� Ÿ�̸� ���� ����մϴ�.
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Timereset()
    {
        PlayerPrefs.DeleteAll();
        timer.timeLeft *= 0.0f;
        Debug.Log("1");
    }
}
