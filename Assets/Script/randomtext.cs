using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class randomtext : MonoBehaviour
{
    public Text QuizText;
    private string[] QuizTextArray = { "������", "��", "�귣��","����Ű","����ī" };
    private int RandomNum;
    // Start is called before the first frame update
    void Start()
    {
        //0����5���� ����� �迭���� �����ϰ� �߻�
        RandomNum = Random.Range(0, 5);
        Debug.Log(RandomNum);
        QuizText.text = QuizTextArray[RandomNum];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
