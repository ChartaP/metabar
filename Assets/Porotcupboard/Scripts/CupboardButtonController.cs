using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CupboardButtonController : MonoBehaviour
{    
    //???꾪솚 ?ㅽ겕由쏀듃

  
    
    void start()
    {
      

    }

    public void CupbordpracticeRestartScene()
    {
        SceneManager.LoadScene("ProtoCupboard_practice"); //???ъ떆??// ????꾩썐 ???⑤뒗 UI 李쎌쓣 ?꾨Ⅴ硫??ъ떆?묓븯???ㅽ겕由쏀듃 //?꾩쓽0踰?
    }
    public void CupbordRestartScene()
    {
        SceneManager.LoadScene("ProtoCupboard"); //???ъ떆??// ????꾩썐 ???⑤뒗 UI 李쎌쓣 ?꾨Ⅴ硫??ъ떆?묓븯???ㅽ겕由쏀듃 //?꾩쓽0踰?
    }

    public void CupboardBeforScene()
    {
        SceneManager.LoadScene(0); // 而듬낫??諛붿쓽 ?댁쟾?ъ쑝濡??대룞 //?꾩쓽 0踰?
    }
     public void CupboardHomeScene()
    {
        SceneManager.LoadScene(0); // 硫붿씤 硫붾돱濡??대룞 //?꾩쓽 0踰?
    }
}
