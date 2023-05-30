using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovetoTest : MonoBehaviour
{
    // Start is called before the first frame update

    public void ClickBtnTest()
    {
        PlayerPrefs.SetInt("writemode", 0); // 0 is test
        SceneManager.LoadScene("ProtoWriteTest");
    }
}
