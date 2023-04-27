using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timecount : MonoBehaviour
{
    public GameObject timeoverImage;
    public float timeLeft = 420.0f; // 7�� Ÿ�̸Ӹ� �����մϴ�.
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
        timeoverImage.SetActive(false);
        float savedTime = PlayerPrefs.GetFloat("TimeLeft"); // ����� Ÿ�̸� ���� �ҷ��ɴϴ�.
        if (savedTime > 0)
        {
            timeLeft = savedTime; // �ҷ��� Ÿ�̸� ���� ����մϴ�.
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime; // Ÿ�̸� ���� ���ҽ�ŵ�ϴ�.
        } // �ð��� ���ҽ�ŵ�ϴ�.
        minutes = Mathf.FloorToInt(timeLeft / 60.0f); // ���� ����մϴ�.
        seconds = Mathf.FloorToInt(timeLeft % 60.0f); // �ʸ� ����մϴ�.

        
        timer.text = "Time:" + string.Format("{0:00}:{1:00}", minutes, seconds);
        if (timeLeft < 0)
        {
            // Ÿ�̸Ӹ� ����ϴ�.
            timeLeft = 0;
            timeoverImage.SetActive(true);

        }
        PlayerPrefs.SetFloat("TimeLeft", timeLeft);
    }

}
