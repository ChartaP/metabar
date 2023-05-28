using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimerScene : MonoBehaviour
{

    public Timecount timer;// Timer Ŭ������ �ν��Ͻ��� �����ϱ� ���� ����
    private Text timerText;
    int minutes;
    int seconds;
    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<Text>(); // �ڽ��� UI Text ������Ʈ�� ����
        float savedTime = PlayerPrefs.GetFloat("Time"); // ����� Ÿ�̸� ���� �ҷ�����
        if (savedTime > 0)
        {
            timer.timeLeft = savedTime; // �ҷ��� Ÿ�̸� ���� ���
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (timer.timeLeft > 0)
        {
            timer.timeLeft -= Time.deltaTime; // Ÿ�̸� ���� ����
        }
        minutes = Mathf.FloorToInt(timer.timeLeft/ 60.0f); // ���� ���
        seconds = Mathf.FloorToInt(timer.timeLeft % 60.0f); // �ʸ� ���
        if (timer != null)
        {
            timerText.text = "Time: " + string.Format("{0:00}:{1:00}", minutes, seconds); ; // Ÿ�̸� ���� UI Text�� ǥ��
        }
        PlayerPrefs.SetFloat("Time",timer.timeLeft);
     
    }
}

