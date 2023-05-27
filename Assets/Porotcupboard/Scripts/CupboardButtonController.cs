using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CupboardButtonController : MonoBehaviour
{    
    //씬 전환 스크립트

  
    
    void start()
    {
      

    }

    public void CupbordpracticeRestartScene()
    {
        SceneManager.LoadScene("ProtoCupboard_practice"); //씬 재시작 // 타임 아웃 후 뜨는 UI 창을 누르면 재시작하는 스크립트 //임의0번
    }
    public void CupbordRestartScene()
    {
        SceneManager.LoadScene("ProtoCupboard"); //씬 재시작 // 타임 아웃 후 뜨는 UI 창을 누르면 재시작하는 스크립트 //임의0번
    }

    public void CupboardBeforScene()
    {
        SceneManager.LoadScene(0); // 컵보드 바의 이전씬으로 이동 //임의 0번
    }
     public void CupboardHomeScene()
    {
        SceneManager.LoadScene(0); // 메인 메뉴로 이동 //임의 0번
    }

    
}
