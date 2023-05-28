using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restartbutton : MonoBehaviour
{
    public Timecount timer;
    // Start is called before the first frame update
    void Start()
    {
        float savedTime = PlayerPrefs.GetFloat("Time"); // 저장된 타이머 값을 불러오기.
        if (savedTime > 0)
        {
            timer.timeLeft = savedTime; // 불러온 타이머 값 사용.
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene(3);//메인으로 가는씬
       
    }
    public void Timereset()
    {
        // 실전 모드에서 reset버튼을 누르면 저장된 키값과 시간을 초기화합니다.
        PlayerPrefs.DeleteAll();
        timer.timeLeft *= 0.0f;
        
    }

}
