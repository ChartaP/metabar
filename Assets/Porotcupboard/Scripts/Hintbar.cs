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
        
        //textData = "AppleMartini_menu";
        hintcnt = 0;
       //string textData = PlayerPrefs.GetString("textData");
       //현빈님 씬 칵테일 고르는 씬에서 칵테일 이름 플레이어프리팹으로 받아와야함
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hintbarbtn()
    {
        hintcnt +=1;

        string textData = PlayerPrefs.GetString("Cocktailname");
        
        // 칵테일 선택씬 플레이어프리팹 받아옴
        if(textData == "PoussCafe_menu")//플레이어 프리팹에 해당되는 문자와 칵테일 문자 맞으면 힌트 버튼 누를 시에 해당 칵테일에 대한 힌트 활성화됨
        {
        if(hintcnt%2 != 0){recipehint[0].SetActive(true);recipehint[5].SetActive(true); cocktailhint[0].SetActive(true); }//카운트 홀수면 힌트 활성화(처음 누를때)
         else{recipehint[0].SetActive(false);recipehint[5].SetActive(false); cocktailhint[0].SetActive(false);}//짝수면 비활
        }

        if(textData == "PB-52_menu")
        {
        if(hintcnt%2 != 0){recipehint[0].SetActive(true);recipehint[5].SetActive(true); cocktailhint[1].SetActive(true); }
         else{recipehint[0].SetActive(false);recipehint[5].SetActive(false); cocktailhint[1].SetActive(false);}
        }

        if(textData == "BlackRussian_menu")
        {
        if(hintcnt%2 != 0){recipehint[3].SetActive(true);recipehint[5].SetActive(true); cocktailhint[2].SetActive(true); }
         else{recipehint[3].SetActive(false);recipehint[5].SetActive(false); cocktailhint[2].SetActive(false);}
        }

        if(textData == "Brandy Alexander_menu")
        {
        if(hintcnt%2 != 0){recipehint[1].SetActive(true);recipehint[6].SetActive(true); recipehint[5].SetActive(true); cocktailhint[3].SetActive(true); }
         else{recipehint[1].SetActive(false);recipehint[6].SetActive(false); recipehint[5].SetActive(false); cocktailhint[3].SetActive(false);}
        }

        if(textData == "Daiquiri_menu")
        {
        if(hintcnt%2 != 0){recipehint[1].SetActive(true);recipehint[6].SetActive(true); recipehint[5].SetActive(true); cocktailhint[4].SetActive(true); }
         else{recipehint[1].SetActive(false);recipehint[6].SetActive(false); recipehint[5].SetActive(false); cocktailhint[4].SetActive(false);}
        }
        if(textData == "Dry Martini_menu")
        {
        if(hintcnt%2 != 0){recipehint[2].SetActive(true);recipehint[5].SetActive(true); cocktailhint[5].SetActive(true); }
         else{recipehint[2].SetActive(false);recipehint[5].SetActive(false); cocktailhint[5].SetActive(false);}
        }
        if(textData == "June Bug_menu")
        {
        if(hintcnt%2 != 0){recipehint[1].SetActive(true);recipehint[6].SetActive(true); recipehint[5].SetActive(true); cocktailhint[6].SetActive(true); }
         else{recipehint[1].SetActive(false);recipehint[6].SetActive(false); recipehint[5].SetActive(false); cocktailhint[6].SetActive(false);}
        }
        if(textData == "Manhattan_menu")
        {
        if(hintcnt%2 != 0){recipehint[2].SetActive(true);recipehint[5].SetActive(true); cocktailhint[7].SetActive(true); }
         else{recipehint[2].SetActive(false);recipehint[5].SetActive(false); cocktailhint[7].SetActive(false);}
        }
        if(textData == "Margarita_menu")
        {
        if(hintcnt%2 != 0){recipehint[1].SetActive(true);recipehint[6].SetActive(true); recipehint[5].SetActive(true); cocktailhint[8].SetActive(true); }
         else{recipehint[1].SetActive(false);recipehint[6].SetActive(false); recipehint[5].SetActive(false); cocktailhint[8].SetActive(false);}
        }
        if(textData == "New York_menu")
        {
        if(hintcnt%2 != 0){recipehint[1].SetActive(true);recipehint[6].SetActive(true); recipehint[5].SetActive(true); cocktailhint[9].SetActive(true); }
         else{recipehint[1].SetActive(false);recipehint[6].SetActive(false); recipehint[5].SetActive(false); cocktailhint[9].SetActive(false);}
        }
        if(textData == "Old Fasfhioned_menu")
        {
        if(hintcnt%2 != 0){recipehint[3].SetActive(true);recipehint[5].SetActive(true); cocktailhint[10].SetActive(true); }
         else{recipehint[3].SetActive(false);recipehint[5].SetActive(false); cocktailhint[10].SetActive(false);}
        }
        if(textData == "Rusty Nail_menu")
        {
        if(hintcnt%2 != 0){recipehint[3].SetActive(true);recipehint[5].SetActive(true); cocktailhint[11].SetActive(true); }
         else{recipehint[3].SetActive(false);recipehint[5].SetActive(false); cocktailhint[11].SetActive(false);}
        }
        if(textData == "Singapore Sling_menu")
        {
        if(hintcnt%2 != 0){recipehint[3].SetActive(true);recipehint[5].SetActive(true); cocktailhint[12].SetActive(true); }
         else{recipehint[3].SetActive(false);recipehint[5].SetActive(false); cocktailhint[12].SetActive(false);}
        }
        if(textData == "Whiskey Sour_menu")
        {
        if(hintcnt%2 != 0){recipehint[3].SetActive(true);recipehint[5].SetActive(true); cocktailhint[13].SetActive(true); }
         else{recipehint[3].SetActive(false);recipehint[5].SetActive(false); cocktailhint[13].SetActive(false);}
        }
        if(textData == "AppleMartini_menu")
        {
        if(hintcnt%2 != 0){recipehint[1].SetActive(true);recipehint[6].SetActive(true); recipehint[5].SetActive(true); cocktailhint[14].SetActive(true); }
         else{recipehint[1].SetActive(false);recipehint[6].SetActive(false); recipehint[5].SetActive(false); cocktailhint[14].SetActive(false);}
        }
        if(textData == "ApricotCocktail_menu")
        {
        if(hintcnt%2 != 0){recipehint[1].SetActive(true);recipehint[6].SetActive(true); recipehint[5].SetActive(true); cocktailhint[15].SetActive(true); }
         else{recipehint[1].SetActive(false);recipehint[6].SetActive(false); recipehint[5].SetActive(false); cocktailhint[15].SetActive(false);}
        }
        if(textData == "BacaridCocktail_menu")
        {
        if(hintcnt%2 != 0){recipehint[1].SetActive(true);recipehint[6].SetActive(true); recipehint[5].SetActive(true); cocktailhint[16].SetActive(true); }
         else{recipehint[1].SetActive(false);recipehint[6].SetActive(false); recipehint[5].SetActive(false); cocktailhint[16].SetActive(false);}
        }
        if(textData == "BlueHawaiian_menu")
        {
        if(hintcnt%2 != 0){recipehint[4].SetActive(true);recipehint[5].SetActive(true); cocktailhint[17].SetActive(true); }
         else{recipehint[4].SetActive(false);recipehint[5].SetActive(false); cocktailhint[17].SetActive(false);}
        }
        if(textData == "Comsoplitan_menu")
        {
        if(hintcnt%2 != 0){recipehint[1].SetActive(true);recipehint[6].SetActive(true); recipehint[5].SetActive(true); cocktailhint[18].SetActive(true); }
         else{recipehint[1].SetActive(false);recipehint[6].SetActive(false); recipehint[5].SetActive(false); cocktailhint[18].SetActive(false);}
        }
        if(textData == "CubaLibre_menu")
        {
        if(hintcnt%2 != 0){recipehint[3].SetActive(true);recipehint[5].SetActive(true); cocktailhint[19].SetActive(true); }
         else{recipehint[3].SetActive(false);recipehint[5].SetActive(false); cocktailhint[19].SetActive(false);}
        }
        if(textData == "FreshLemonSquash_menu")
        {
        if(hintcnt%2 != 0){recipehint[3].SetActive(true);recipehint[5].SetActive(true); cocktailhint[20].SetActive(true); }
         else{recipehint[3].SetActive(false);recipehint[5].SetActive(false); cocktailhint[20].SetActive(false);}
        }
        if(textData == "Geumsan_menu")
        {
        if(hintcnt%2 != 0){recipehint[1].SetActive(true);recipehint[6].SetActive(true); recipehint[5].SetActive(true); cocktailhint[21].SetActive(true); }
         else{recipehint[1].SetActive(false);recipehint[6].SetActive(false); recipehint[5].SetActive(false); cocktailhint[21].SetActive(false);}
        }
        
        if(textData == "Gochang_menu")
        {
        if(hintcnt%2 != 0){recipehint[2].SetActive(true);recipehint[5].SetActive(true); cocktailhint[22].SetActive(true); }
         else{recipehint[2].SetActive(false);recipehint[5].SetActive(false); cocktailhint[22].SetActive(false);}
        }
        if(textData == "Grasshopper_menu")
        {
        if(hintcnt%2 != 0){recipehint[1].SetActive(true);recipehint[6].SetActive(true); recipehint[5].SetActive(true); cocktailhint[23].SetActive(true); }
         else{recipehint[1].SetActive(false);recipehint[6].SetActive(false); recipehint[5].SetActive(false); cocktailhint[23].SetActive(false);}
        }
        if(textData == "Healing_menu")
        {
        if(hintcnt%2 != 0){recipehint[1].SetActive(true);recipehint[6].SetActive(true); recipehint[5].SetActive(true); cocktailhint[24].SetActive(true); }
         else{recipehint[1].SetActive(false);recipehint[6].SetActive(false); recipehint[5].SetActive(false); cocktailhint[24].SetActive(false);}
        }
        if(textData == "Honeymoon_menu")
        {
        if(hintcnt%2 != 0){recipehint[1].SetActive(true);recipehint[6].SetActive(true); recipehint[5].SetActive(true); cocktailhint[25].SetActive(true); }
         else{recipehint[1].SetActive(false);recipehint[6].SetActive(false); recipehint[5].SetActive(false); cocktailhint[25].SetActive(false);}
        }
        if(textData == "Jindo_menu")
        {
        if(hintcnt%2 != 0){recipehint[1].SetActive(true);recipehint[6].SetActive(true); recipehint[5].SetActive(true); cocktailhint[26].SetActive(true); }
         else{recipehint[1].SetActive(false);recipehint[6].SetActive(false); recipehint[5].SetActive(false); cocktailhint[26].SetActive(false);}
        }
        if(textData == "kir_menu")
        {
        if(hintcnt%2 != 0){recipehint[3].SetActive(true);recipehint[5].SetActive(true); cocktailhint[27].SetActive(true); }
         else{recipehint[3].SetActive(false);recipehint[5].SetActive(false); cocktailhint[27].SetActive(false);}
        }
        if(textData == "LongisLandIcedTea_menu")
        {
        if(hintcnt%2 != 0){recipehint[3].SetActive(true);recipehint[5].SetActive(true); cocktailhint[28].SetActive(true); }
         else{recipehint[3].SetActive(false);recipehint[5].SetActive(false); cocktailhint[28].SetActive(false);}
        }
        if(textData == "Mai-Tal_menu")
        {
        if(hintcnt%2 != 0){recipehint[4].SetActive(true);recipehint[5].SetActive(true); cocktailhint[29].SetActive(true); }
         else{recipehint[4].SetActive(false);recipehint[5].SetActive(false); cocktailhint[29].SetActive(false);}
        }
        if(textData == "MoscowMule_menu")
        {
        if(hintcnt%2 != 0){recipehint[3].SetActive(true);recipehint[5].SetActive(true); cocktailhint[30].SetActive(true); }
         else{recipehint[3].SetActive(false);recipehint[5].SetActive(false); cocktailhint[30].SetActive(false);}
        }
        if(textData == "Negronl_menu")
        {
        if(hintcnt%2 != 0){recipehint[3].SetActive(true);recipehint[5].SetActive(true); cocktailhint[31].SetActive(true); }
         else{recipehint[3].SetActive(false);recipehint[5].SetActive(false); cocktailhint[31].SetActive(false);}
        }
        if(textData == "PlnaColada_menu")
        {
        if(hintcnt%2 != 0){recipehint[4].SetActive(true);recipehint[5].SetActive(true); cocktailhint[32].SetActive(true); }
         else{recipehint[4].SetActive(false);recipehint[5].SetActive(false); cocktailhint[32].SetActive(false);}
        }
        if(textData == "Seabreeze_menu")
        {
        if(hintcnt%2 != 0){recipehint[3].SetActive(true);recipehint[5].SetActive(true); cocktailhint[33].SetActive(true); }
         else{recipehint[3].SetActive(false);recipehint[5].SetActive(false); cocktailhint[33].SetActive(false);}
        }
        if(textData == "Sidecar_menu")
        {
        if(hintcnt%2 != 0){recipehint[1].SetActive(true);recipehint[6].SetActive(true); recipehint[5].SetActive(true); cocktailhint[34].SetActive(true); }
         else{recipehint[1].SetActive(false);recipehint[6].SetActive(false); recipehint[5].SetActive(false); cocktailhint[34].SetActive(false);}
        }
        if(textData == "Tequila SunriseFloat_menu")
        {
        if(hintcnt%2 != 0){recipehint[3].SetActive(true);recipehint[5].SetActive(true); cocktailhint[35].SetActive(true); }
         else{recipehint[3].SetActive(false);recipehint[5].SetActive(false); cocktailhint[35].SetActive(false);}
        }
        if(textData == "VriginFruitPunch_menu")
        {
        if(hintcnt%2 != 0){recipehint[4].SetActive(true);recipehint[5].SetActive(true); cocktailhint[36].SetActive(true); }
         else{recipehint[4].SetActive(false);recipehint[5].SetActive(false); cocktailhint[36].SetActive(false);}
        }
        if(textData == "GinFizz_menu")
        {
        if(hintcnt%2 != 0){recipehint[3].SetActive(true);recipehint[5].SetActive(true); cocktailhint[37].SetActive(true); }
         else{recipehint[3].SetActive(false);recipehint[5].SetActive(false); cocktailhint[37].SetActive(false);}
        }
        if(textData == "PuppyLove_menu")
        {
        if(hintcnt%2 != 0){recipehint[1].SetActive(true);recipehint[6].SetActive(true); recipehint[5].SetActive(true); cocktailhint[38].SetActive(true); }
         else{recipehint[1].SetActive(false);recipehint[6].SetActive(false); recipehint[5].SetActive(false); cocktailhint[38].SetActive(false);}
        }

       
        

       


    }
}
