using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hintbar : MonoBehaviour
{

    public GameObject[] recipehint;
    public GameObject[] cocktailhint;
    string TextData_Menu;
    private int hintcnt;
    // Start is called before the first frame update
    void Start()
    {
        //string TextData = PlayerPrefs.GetString("TextDataMenu");
        TextData_Menu = "PussCafe_menu";
        hintcnt = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hintbarbtn()
    {
        hintcnt +=1;
        if(TextData_Menu == "PussCafe_menu")
        {
        if(hintcnt%2 != 0){recipehint[0].SetActive(true); cocktailhint[0].SetActive(true); }
         else{recipehint[0].SetActive(false); cocktailhint[0].SetActive(false);}
        }

        if(TextData_Menu == "PB-52_menu")
        {
        if(hintcnt%2 != 0){recipehint[0].SetActive(true); cocktailhint[1].SetActive(true); }
         else{recipehint[0].SetActive(false); cocktailhint[1].SetActive(false);}
        }

        if(TextData_Menu == "BlackRussian_menu")
        {
        if(hintcnt%2 != 0){recipehint[3].SetActive(true); cocktailhint[2].SetActive(true); }
         else{recipehint[3].SetActive(false); cocktailhint[2].SetActive(false);}
        }

        if(TextData_Menu == "Brandy Alexander_menu")
        {
        if(hintcnt%2 != 0){recipehint[1].SetActive(true); cocktailhint[3].SetActive(true); }
         else{recipehint[1].SetActive(false); cocktailhint[3].SetActive(false);}
        }

        if(TextData_Menu == "Daiquiri_menu")
        {
        if(hintcnt%2 != 0){recipehint[1].SetActive(true); cocktailhint[4].SetActive(true); }
         else{recipehint[1].SetActive(false); cocktailhint[4].SetActive(false);}
        }
        if(TextData_Menu == "Dry Martini_menu")
        {
        if(hintcnt%2 != 0){recipehint[2].SetActive(true); cocktailhint[5].SetActive(true); }
         else{recipehint[2].SetActive(false); cocktailhint[5].SetActive(false);}
        }
        if(TextData_Menu == "June Bug_Shake_M_menu")
        {
        if(hintcnt%2 != 0){recipehint[1].SetActive(true); cocktailhint[6].SetActive(true); }
         else{recipehint[1].SetActive(false); cocktailhint[6].SetActive(false);}
        }
        if(TextData_Menu == "Manhattan_Stir_M")
        {
        if(hintcnt%2 != 0){recipehint[2].SetActive(true); cocktailhint[7].SetActive(true); }
         else{recipehint[2].SetActive(false); cocktailhint[7].SetActive(false);}
        }
        if(TextData_Menu == "Margarita_Shake_M")
        {
        if(hintcnt%2 != 0){recipehint[1].SetActive(true); cocktailhint[8].SetActive(true); }
         else{recipehint[1].SetActive(false); cocktailhint[8].SetActive(false);}
        }
        if(TextData_Menu == "New York_Shake_M")
        {
        if(hintcnt%2 != 0){recipehint[1].SetActive(true); cocktailhint[9].SetActive(true); }
         else{recipehint[1].SetActive(false); cocktailhint[9].SetActive(false);}
        }
        if(TextData_Menu == "Old Fasfhioned_Build_M")
        {
        if(hintcnt%2 != 0){recipehint[3].SetActive(true); cocktailhint[10].SetActive(true); }
         else{recipehint[3].SetActive(false); cocktailhint[10].SetActive(false);}
        }
        if(TextData_Menu == "Rusty Nail_Build_M")
        {
        if(hintcnt%2 != 0){recipehint[3].SetActive(true); cocktailhint[11].SetActive(true); }
         else{recipehint[3].SetActive(false); cocktailhint[11].SetActive(false);}
        }
        if(TextData_Menu == "Singapore Sling_ShakeBuild_M")
        {
        if(hintcnt%2 != 0){recipehint[3].SetActive(true); cocktailhint[12].SetActive(true); }
         else{recipehint[3].SetActive(false); cocktailhint[12].SetActive(false);}
        }
        if(TextData_Menu == "Whiskey Sour_ShakeBuild_M")
        {
        if(hintcnt%2 != 0){recipehint[3].SetActive(true); cocktailhint[13].SetActive(true); }
         else{recipehint[3].SetActive(false); cocktailhint[13].SetActive(false);}
        }
       
        

       


    }
}
