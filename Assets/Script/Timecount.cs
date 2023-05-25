using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timecount : MonoBehaviour
{
    public GameObject timeoverImage;
    public GameObject[] button;
    public float timeLeft=0.0f; // 7�� Ÿ�̸Ӹ� ����.
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
        
        timeoverImage.SetActive(false); //���۽� �ð��ʰ� UI ��Ȱ��ȭ
        float savedTime = PlayerPrefs.GetFloat("Time"); // ����� Ÿ�̸� �� �ҷ�����
        if (savedTime > 0)
        {
            timeLeft = savedTime; // �ҷ��� Ÿ�̸� ���� ���
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime; // Ÿ�̸� ���� ����
        } // �ð��� ���ҽ�ŵ�ϴ�.
        minutes = Mathf.FloorToInt(timeLeft / 60.0f); // ���� ���
        seconds = Mathf.FloorToInt(timeLeft % 60.0f); // �ʸ� ���

        
        timer.text = "Time:" + string.Format("{0:00}:{1:00}", minutes, seconds);
        if (timeLeft < 0)
        {
            // Ÿ�̸Ӹ� ����
            timeLeft = 0;
            timeoverImage.SetActive(true); // Ÿ�̸Ӱ� ������ UI Ȱ��ȭ
            for(int i=0; i<button.Length;i++)
            {
                button[i].SetActive(false);
            }

        }
        PlayerPrefs.SetFloat("Time", timeLeft);
        
    }

}
