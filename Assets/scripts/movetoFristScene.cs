using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movetoFristScene : MonoBehaviour
{

    public void SceneChange()
    {
        SceneManager.LoadScene("FristScene");
    }
}
