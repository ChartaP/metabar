using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimerScene : MonoBehaviour
{

    public Timecount timer;// Timer 클래스의 인스턴스를 참조하기 위한 변수
    private Text timerText;
    int minutes;
    int seconds;
    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<Text>(); // 자신의 UI Text 오브젝트를 참조
        float savedTime = PlayerPrefs.GetFloat("Time"); // 저장된 타이머 값을 불러오기
        if (savedTime > 0)
        {
            timer.timeLeft = savedTime; // 불러온 타이머 값을 사용
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (timer.timeLeft > 0)
        {
            timer.timeLeft -= Time.deltaTime; // 타이머 값을 감소
        }
        minutes = Mathf.FloorToInt(timer.timeLeft/ 60.0f); // 분을 계산
        seconds = Mathf.FloorToInt(timer.timeLeft % 60.0f); // 초를 계산
        if (timer != null)
        {
            timerText.text = "Time: " + string.Format("{0:00}:{1:00}", minutes, seconds); ; // 타이머 값을 UI Text에 표시
        }
        PlayerPrefs.SetFloat("Time",timer.timeLeft);
     
    }
}

