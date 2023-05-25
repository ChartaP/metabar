using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeReset : MonoBehaviour
{
    public Timecount timer;
    // Start is called before the first frame update
    void Start()
    {
        float savedTime = PlayerPrefs.GetFloat("Time"); // 저장된 타이머 값을 불러오기
        if (savedTime > 0)
        {
            timer.timeLeft = savedTime; // 불러온 타이머 값을 사용
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Timereset()
    {
        // 메인으로 나갈때 시간을 초기화 하기위해 키값 삭제
        PlayerPrefs.DeleteAll();
        timer.timeLeft *= 0.0f;
    }
}
