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
        // ù ��° ������ ������ �ؽ�Ʈ�� �����ͼ� ǥ��
        string textData = PlayerPrefs.GetString("TextData");
        textUI.text = textData;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
