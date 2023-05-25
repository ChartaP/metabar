using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nextScenetext : MonoBehaviour
{
    public Text textUI;
    // Start is called before the first frame update
    void Start()
    {
        // 첫 번째 씬에서 저장한 텍스트를 가져와서 표시
        string textData = PlayerPrefs.GetString("TextData");
        textUI.text = textData;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
