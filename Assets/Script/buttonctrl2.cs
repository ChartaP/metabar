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
        // 텍스트를 저장하고 다음 씬으로 전달
        PlayerPrefs.SetString("TextData", inputtext.text);
        SceneManager.LoadScene(2);
    }

}
