using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class buttonctrl2 : MonoBehaviour
{
    public Text inputtext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Button()
    {
        // �ؽ�Ʈ�� �����ϰ� ���� ������ ����
        PlayerPrefs.SetString("TextData", inputtext.text);
        SceneManager.LoadScene(2);
    }
    public void Button2()
    {
        // �ؽ�Ʈ�� �����ϰ� ���� ������ ����
        PlayerPrefs.SetString("TextData", inputtext.text);
        SceneManager.LoadScene(20);
        Debug.Log(inputtext);
    }



}
