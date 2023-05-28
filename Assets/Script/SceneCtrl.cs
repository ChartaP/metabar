using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene("ProtoCounter2"); //조주 하는 씬으로 이동
     
    }
    public void ChangeScene2()
    {
        SceneManager.LoadScene(3); // 실전모드 시작전 씬으로 이동
    }
    public void ChangeScene3()
    {
        SceneManager.LoadScene(1); //실전모드 3개칵테일 이 나오는 씬으로 이동
    }
    public void ChangeScene4()
    {
        SceneManager.LoadScene("메인으로가는씬");
    }
    public void ChangeScene5()
    {
        SceneManager.LoadScene(7); //연습모드 3개 칵테일 나오는 씬으로 이동
    }
}
