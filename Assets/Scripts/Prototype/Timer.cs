using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private TMPro.TMP_Text text;
    
    public void SetTime(int time)
    {
        int m = time / 60;
        int s = time % 60;
        string tstr = (m<10) ? "0"+m.ToString() : m.ToString();
        tstr += ":";
        tstr += (s < 10) ? "0" + s.ToString() : s.ToString();

        text.text = tstr;
    }

}
