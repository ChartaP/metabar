using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WriteTestSceneMove : MonoBehaviour
{
    // Start is called before the first frame update

    public void ClickBtnTest()
    {
        PlayerPrefs.SetInt("writemode", 1); // 1 is realtest
        SceneManager.LoadScene("ProtoWriteTest");
    }
}
