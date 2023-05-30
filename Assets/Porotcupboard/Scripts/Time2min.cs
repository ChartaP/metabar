using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Time2min : MonoBehaviour
{
    public TextMeshProUGUI[] timeText; //타이머 텍스트  timeText[0] = min(text) , timeText[1] = sec(text)
    public float time = 120; //제한시간 2분
    private int min, sec; // 분,초
    private bool timestart=true;

    public GameObject gameout;//게임오버 화면
    public GameObject[] menue;//이전,홈 버튼
    public GameObject[] underbar;//천장스크롤 UI Cupboard Scroll View 

    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        timeText[0].text = "02";
        timeText[1].text = "00";

        underbar[0].SetActive(true);// Cupboard Scroll View UP 활성화
        underbar[1].SetActive(true);//Cupboard Scroll View Down 활성화
    }
    // Update is called once per frame
    void Update()
    {
        if(timestart == true) //컵보드바 화면이 실행되어 timestart가 true가 되면 타이머 시간이 흐름 
        {
            time -= Time.deltaTime; //타이머 감소
            min =(int)time/60; 
            sec=((int)time-min * 60)%60;
            gameout.SetActive(false); //타이머가 흐르는 동안에는 타임아웃 UI가 비활성화 되어있음

            if(sec>=60){
                min += 1;
                sec -= 60;
            }
            else{
                timeText[0].text = min.ToString();
                timeText[1].text = sec.ToString();
            }
        }
        
        if(time <= 0)
        {
             timestart = false; // 타이머가 0보다 작으면 즉 시간이 다되면 timestart가 비활성화되어 시간이 더 이상 흐르지 않고 0에서 멈춤
             gameout.SetActive(true); // 타임 아웃 UI 활성화
             menue[0].SetActive(true); //홈 버튼 UI 활성화
             menue[1].SetActive(true); // 이전 버튼 UI 활성화
             underbar[0].SetActive(false); // Cupboard Scroll View UP 비활성화
             underbar[1].SetActive(false); //Cupboard Scroll View Down 비활성화
             underbar[2].SetActive(false); //check 버튼(주조씬으로 넘어가는 버튼) 비활성화
             underbar[3].SetActive(false); // 타이머 비활성화
             audioSource.Play();
        }    
     }
    }

