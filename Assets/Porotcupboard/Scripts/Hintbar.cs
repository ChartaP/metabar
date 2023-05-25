using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hintbar : MonoBehaviour
{

    public GameObject[] recipehint;
    public GameObject[] cocktailhint;
    //string textData;
    private int hintcnt;
    public Text textUI;
    // Start is called before the first frame update
    void Start()
    {
        
        //textData = "PussCafe_menu";
        hintcnt = 0;
        string textData = PlayerPrefs.GetString("textData");
        textUI.text = textData;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hintbarbtn()
    {
        hintcnt +=1;

        string textData = PlayerPrefs.GetString("textData");
        if(textData == "PussCafe_menu")
        {
        if(hintcnt%2 != 0){recipehint[0].SetActive(true); cocktailhint[0].SetActive(true); }
         else{recipehint[0].SetActive(false); cocktailhint[0].SetActive(false);}
        }

        if(textData == "PB-52_menu")
        {
        if(hintcnt%2 != 0){recipehint[0].SetActive(true); cocktailhint[1].SetActive(true); }
         else{recipehint[0].SetActive(false); cocktailhint[1].SetActive(false);}
        }

        if(textData == "BlackRussian_menu")
        {
        if(hintcnt%2 != 0){recipehint[3].SetActive(true); cocktailhint[2].SetActive(true); }
         else{recipehint[3].SetActive(false); cocktailhint[2].SetActive(false);}
        }

        if(textData == "Brandy Alexander_menu")
        {
        if(hintcnt%2 != 0){recipehint[1].SetActive(true); cocktailhint[3].SetActive(true); }
         else{recipehint[1].SetActive(false); cocktailhint[3].SetActive(false);}
        }

        if(textData == "Daiquiri_menu")
        {
        if(hintcnt%2 != 0){recipehint[1].SetActive(true); cocktailhint[4].SetActive(true); }
         else{recipehint[1].SetActive(false); cocktailhint[4].SetActive(false);}
        }
        if(textData == "Dry Martini_menu")
        {
        if(hintcnt%2 != 0){recipehint[2].SetActive(true); cocktailhint[5].SetActive(true); }
         else{recipehint[2].SetActive(false); cocktailhint[5].SetActive(false);}
        }
        if(textData == "June Bug_menu")
        {
        if(hintcnt%2 != 0){recipehint[1].SetActive(true); cocktailhint[6].SetActive(true); }
         else{recipehint[1].SetActive(false); cocktailhint[6].SetActive(false);}
        }
        if(textData == "Manhattan_menu")
        {
        if(hintcnt%2 != 0){recipehint[2].SetActive(true); cocktailhint[7].SetActive(true); }
         else{recipehint[2].SetActive(false); cocktailhint[7].SetActive(false);}
        }
        if(textData == "Margarita_menu")
        {
        if(hintcnt%2 != 0){recipehint[1].SetActive(true); cocktailhint[8].SetActive(true); }
         else{recipehint[1].SetActive(false); cocktailhint[8].SetActive(false);}
        }
        if(textData == "New York_menu")
        {
        if(hintcnt%2 != 0){recipehint[1].SetActive(true); cocktailhint[9].SetActive(true); }
         else{recipehint[1].SetActive(false); cocktailhint[9].SetActive(false);}
        }
        if(textData == "Old Fasfhioned_menu")
        {
        if(hintcnt%2 != 0){recipehint[3].SetActive(true); cocktailhint[10].SetActive(true); }
         else{recipehint[3].SetActive(false); cocktailhint[10].SetActive(false);}
        }
        if(textData == "Rusty Nail_menu")
        {
        if(hintcnt%2 != 0){recipehint[3].SetActive(true); cocktailhint[11].SetActive(true); }
         else{recipehint[3].SetActive(false); cocktailhint[11].SetActive(false);}
        }
        if(textData == "Singapore Sling_menu")
        {
        if(hintcnt%2 != 0){recipehint[3].SetActive(true); cocktailhint[12].SetActive(true); }
         else{recipehint[3].SetActive(false); cocktailhint[12].SetActive(false);}
        }
        if(textData == "Whiskey Sour_menu")
        {
        if(hintcnt%2 != 0){recipehint[3].SetActive(true); cocktailhint[13].SetActive(true); }
         else{recipehint[3].SetActive(false); cocktailhint[13].SetActive(false);}
        }
       
        

       


    }
}
