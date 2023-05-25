using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timecount : MonoBehaviour
{
    public GameObject timeoverImage;
    public GameObject[] button;
    public float timeLeft=0.0f; // 7분 타이머를 설정.
    public Text timer;
    int minutes;
    int seconds;
    // Start is called before the first frame update
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        
        timeoverImage.SetActive(false); //시작시 시간초과 UI 비활성화
        float savedTime = PlayerPrefs.GetFloat("Time"); // 저장된 타이머 값 불러오기
        if (savedTime > 0)
        {
            timeLeft = savedTime; // 불러온 타이머 값을 사용
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime; // 타이머 값을 감소
        } // 시간을 감소시킵니다.
        minutes = Mathf.FloorToInt(timeLeft / 60.0f); // 분을 계산
        seconds = Mathf.FloorToInt(timeLeft % 60.0f); // 초를 계산

        
        timer.text = "Time:" + string.Format("{0:00}:{1:00}", minutes, seconds);
        if (timeLeft < 0)
        {
            // 타이머를 멈춤
            timeLeft = 0;
            timeoverImage.SetActive(true); // 타이머가 끝나면 UI 활성화
            for(int i=0; i<button.Length;i++)
            {
                button[i].SetActive(false);
            }

        }
        PlayerPrefs.SetFloat("Time", timeLeft);
        
    }

}
