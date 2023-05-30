using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//using System.Collections.Generic;

public class cocktailingredients : MonoBehaviour
{
    public GameObject notcheck; //?섎せ???덉떆???좏깮 ???⑤뒗 ?띿뒪?몄갹
    public GameObject cocktailingredientslObject;// 而듬낫?쒖뿉 ?덈뒗 移듯뀒???щ즺?? ?쒖꽦??鍮꾪솢?깊솕 議곗젅 )
    public GameObject[] AlcoholObject; // ?뚯퐳 ?щ즺 媛앹껜 諛곗뿴
    public GameObject[] NonAlcoholObject; //?쇱븣肄??щ즺 媛앹껜 諛곗뿴
    public GameObject[] CocktaillGlassObject; //移듯뀒?????щ즺 媛앹껜 諛곗뿴
    public GameObject[] ToolObject; //移듯뀒???꾧뎄 ?щ즺 媛앹껜 諛곗뿴
   // public int cocktailMnum;
   

    private int cocktailcheckcount = 0; //鍮꾪솢???쒖꽦?붾? 議곗젅?섍린 ?꾪븳 移댁슫??



    void Start()
    {
        cocktailingredientslObject.SetActive(false);
    }
    

    public void OnButtonClick()
    {
        cocktailcheckcount += 1;  //而듬낫??泥쒖옣???덈뒗 ?ㅽ겕濡?UI???덈뒗 ?щ즺??踰꾪듉 ?꾨? ??移댁슫??+1

        if (cocktailcheckcount % 2 != 0) // 移댁슫?멸? ??섎㈃ ?섎떒 而듬낫?쒕컮???덈뒗 ?대떦踰꾪듉怨?媛숈? 醫낅쪟??移듯뀒???щ즺 ?쒖꽦??
        {
            cocktailingredientslObject.SetActive(true);
        }
        else //移댁슫?멸? 吏앹닔硫??섎떒 而듬낫?쒕컮???덈뒗 ?대떦踰꾪듉怨?媛숈? 醫낅쪟??移듯뀒???щ즺 鍮꾪솢?깊솕
        {
            cocktailingredientslObject.SetActive(false);
        }
        
    }

    public void CocktailingredientsCheck()
    {

        // 媛?諛곗뿴???낅젰???щ즺??以?Pousse Cafe ?덉떆?쇱뿉 ?대떦???щ즺留??쒖꽦???섎㈃ "Pousse Cafe"?대쫫?????
        if (AlcoholObject[11].activeSelf && AlcoholObject[3].activeSelf 
            && NonAlcoholObject[1].activeSelf && CocktaillGlassObject[7].activeSelf
&& ToolObject[14].activeSelf             && (ToolObject[5].activeSelf || ToolObject[6].activeSelf || ToolObject[7].activeSelf) && ToolObject[9].activeSelf)
        {
            //Debug.Log("Pousse Cafe");
            //SaveSelectedCocktail("Pousse Cafe"); //?대떦 移듯뀒???대쫫 ???
              CocktailMaking(); // ?ㅼ쓬 議곗＜ ?ъ쑝濡??대룞
        }
         // 媛?諛곗뿴???낅젰???щ즺??以?Manhattan ?덉떆?쇱뿉 ?대떦???щ즺留??쒖꽦???섎㈃ "Manhattan"?대쫫?????
        else if (AlcoholObject[8].activeSelf && AlcoholObject[11].activeSelf
            && AlcoholObject[32].activeSelf && NonAlcoholObject[20].activeSelf
            && CocktaillGlassObject[6].activeSelf && ToolObject[14].activeSelf&&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf && ToolObject[2].activeSelf  && (ToolObject[5].activeSelf || ToolObject[6].activeSelf || ToolObject[7].activeSelf) && ToolObject[9].activeSelf)
        {
            //Debug.Log("Manhattan");
            //SaveSelectedCocktail("Manhattan"); //?대떦 移듯뀒???대쫫 ???
              CocktailMaking();// ?ㅼ쓬 議곗＜ ?ъ쑝濡??대룞
        }
         // 媛?諛곗뿴???낅젰???щ즺??以?Dry Martini ?덉떆?쇱뿉 ?대떦???щ즺留??쒖꽦???섎㈃ "Dry Martini"?대쫫?????
        else if (AlcoholObject[1].activeSelf && AlcoholObject[12].activeSelf
            && NonAlcoholObject[18].activeSelf && CocktaillGlassObject[6].activeSelf
&& ToolObject[14].activeSelf            &&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf && ToolObject[2].activeSelf  && (ToolObject[5].activeSelf || ToolObject[6].activeSelf || ToolObject[7].activeSelf) && ToolObject[9].activeSelf)
        {
            //Debug.Log("Dry Martini");
            //SaveSelectedCocktail("Dry Martini"); //?대떦 移듯뀒???대쫫 ???
              CocktailMaking();// ?ㅼ쓬 議곗＜ ?ъ쑝濡??대룞
        }
        else if (AlcoholObject[8].activeSelf && AlcoholObject[32].activeSelf
            && NonAlcoholObject[17].activeSelf && NonAlcoholObject[12].activeSelf
            && NonAlcoholObject[20].activeSelf && NonAlcoholObject[22].activeSelf
            && CocktaillGlassObject[2].activeSelf
&& ToolObject[14].activeSelf            &&ToolObject[10].activeSelf && ToolObject[11].activeSelf 
        && (ToolObject[5].activeSelf || ToolObject[6].activeSelf || ToolObject[7].activeSelf) && ToolObject[9].activeSelf
)
        {
            
            //SaveSelectedCocktail("Old Fashioned"); //?대떦 移듯뀒???대쫫 ???
              CocktailMaking();// ?ㅼ쓬 議곗＜ ?ъ쑝濡??대룞
        }
        else if (AlcoholObject[3].activeSelf && AlcoholObject[15].activeSelf
            && NonAlcoholObject[9].activeSelf &&/*?쏇듃?뚯슦?붾줈 蹂寃?/ NonAlcoholObject[0].activeSelf && CocktaillGlassObject[6].activeSelf
&& ToolObject[14].activeSelf            &&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf  && ToolObject[9].activeSelf 
         && (ToolObject[0].activeSelf || ToolObject[1].activeSelf))
        {
            //?쏇듃 ?뚯슦??異붽?
            //SaveSelectedCocktail("Brandy Aiexander"); //?대떦 移듯뀒???대쫫 ???
              CocktailMaking();// ?ㅼ쓬 議곗＜ ?ъ쑝濡??대룞
        }
        else if (AlcoholObject[1].activeSelf && AlcoholObject[33].activeSelf
            && NonAlcoholObject[4].activeSelf && NonAlcoholObject[17].activeSelf && NonAlcoholObject[12].activeSelf 
            && CocktaillGlassObject[16].activeSelf&& ToolObject[14].activeSelf &&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf  && ToolObject[9].activeSelf 
         && (ToolObject[0].activeSelf || ToolObject[1].activeSelf) && (ToolObject[5].activeSelf || ToolObject[6].activeSelf || ToolObject[7].activeSelf))
        {
            
            //SaveSelectedCocktail("Singapore Sling"); //?대떦 移듯뀒???대쫫 ???
              CocktailMaking();// ?ㅼ쓬 議곗＜ ?ъ쑝濡??대룞
        }
        else if (AlcoholObject[0].activeSelf && AlcoholObject[14].activeSelf
            &&CocktaillGlassObject[2].activeSelf &&ToolObject[10].activeSelf && ToolObject[11].activeSelf 
        && (ToolObject[5].activeSelf || ToolObject[6].activeSelf || ToolObject[7].activeSelf) && ToolObject[9].activeSelf)
        {
            
            //SaveSelectedCocktail("Black Russian"); //?대떦 移듯뀒???대쫫 ???
              CocktailMaking();// ?ㅼ쓬 議곗＜ ?ъ쑝濡??대룞
        }
        else if (AlcoholObject[2].activeSelf && (AlcoholObject[27].activeSelf ||AlcoholObject[17].activeSelf)
            && NonAlcoholObject[11].activeSelf && NonAlcoholObject[16].activeSelf && CocktaillGlassObject[6].activeSelf
&& ToolObject[14].activeSelf            &&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf  && ToolObject[9].activeSelf 
         && (ToolObject[0].activeSelf || ToolObject[1].activeSelf)
)
        {
            
            //SaveSelectedCocktail("Mararita"); //?대떦 移듯뀒???대쫫 ???
            CocktailMaking();// ?ㅼ쓬 議곗＜ ?ъ쑝濡??대룞
        }
        else if (AlcoholObject[9].activeSelf && AlcoholObject[18].activeSelf
            && CocktaillGlassObject[2].activeSelf && ToolObject[14].activeSelf&&ToolObject[10].activeSelf && ToolObject[11].activeSelf 
        && (ToolObject[5].activeSelf || ToolObject[6].activeSelf || ToolObject[7].activeSelf) && ToolObject[9].activeSelf)
        {
            
            //SaveSelectedCocktail("Rusty Nail"); //?대떦 移듯뀒???대쫫 ???
              CocktailMaking();// ?ㅼ쓬 議곗＜ ?ъ쑝濡??대룞
        }
        else if (AlcoholObject[8].activeSelf && NonAlcoholObject[4].activeSelf
            && NonAlcoholObject[17].activeSelf && NonAlcoholObject[12].activeSelf
            && NonAlcoholObject[19].activeSelf && NonAlcoholObject[20].activeSelf
             && CocktaillGlassObject[14].activeSelf&& ToolObject[14].activeSelf &&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf  && ToolObject[9].activeSelf 
         && (ToolObject[0].activeSelf || ToolObject[1].activeSelf) && (ToolObject[5].activeSelf || ToolObject[6].activeSelf || ToolObject[7].activeSelf))
        {
            
            //SaveSelectedCocktail("Whiskey Sour"); //?대떦 移듯뀒???대쫫 ???
              CocktailMaking();// ?ㅼ쓬 議곗＜ ?ъ쑝濡??대룞
        }
        else if (AlcoholObject[8].activeSelf && NonAlcoholObject[11].activeSelf
            && NonAlcoholObject[17].activeSelf && NonAlcoholObject[1].activeSelf
            && NonAlcoholObject[19].activeSelf && CocktaillGlassObject[6].activeSelf && ToolObject[14].activeSelf &&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf  && ToolObject[9].activeSelf 
         && (ToolObject[0].activeSelf || ToolObject[1].activeSelf))
        {
            
            //SaveSelectedCocktail("New York"); //?대떦 移듯뀒???대쫫 ???
              CocktailMaking();// ?ㅼ쓬 議곗＜ ?ъ쑝濡??대룞
        }
        else if (AlcoholObject[6].activeSelf && NonAlcoholObject[11].activeSelf
            && NonAlcoholObject[17].activeSelf && CocktaillGlassObject[6].activeSelf && ToolObject[14].activeSelf &&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf  && ToolObject[9].activeSelf 
         && (ToolObject[0].activeSelf || ToolObject[1].activeSelf))
        {
            
            //SaveSelectedCocktail("Daiquirl"); //?대떦 移듯뀒???대쫫 ???
              CocktailMaking();// ?ㅼ쓬 議곗＜ ?ъ쑝濡??대룞
        }
        else if (AlcoholObject[14].activeSelf && AlcoholObject[20].activeSelf && AlcoholObject[21].activeSelf
            &&  CocktaillGlassObject[8].activeSelf && (ToolObject[5].activeSelf || ToolObject[6].activeSelf || ToolObject[7].activeSelf) && ToolObject[9].activeSelf)
        {
            
            //SaveSelectedCocktail("Cocktail_B52"); //?대떦 移듯뀒???대쫫 ???
              CocktailMaking();// ?ㅼ쓬 議곗＜ ?ъ쑝濡??대룞
        }
        else if (AlcoholObject[23].activeSelf && AlcoholObject[19].activeSelf && /*諛붾굹?섎━?먮Ⅴ*/AlcoholObject[0].activeSelf
            && NonAlcoholObject[10].activeSelf && NonAlcoholObject[0].activeSelf 
            && NonAlcoholObject[20].activeSelf && NonAlcoholObject[21].activeSelf 
            && CocktaillGlassObject[4].activeSelf && ToolObject[14].activeSelf&&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf  && ToolObject[9].activeSelf 
         && (ToolObject[0].activeSelf || ToolObject[1].activeSelf) )
        {
            
            //SaveSelectedCocktail("Jun Bug"); //?대떦 移듯뀒???대쫫 ???
              CocktailMaking();// ?ㅼ쓬 議곗＜ ?ъ쑝濡??대룞
        }
        else if (AlcoholObject[7].activeSelf && NonAlcoholObject[11].activeSelf
            && NonAlcoholObject[2].activeSelf && CocktaillGlassObject[6].activeSelf && ToolObject[14].activeSelf
            &&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf  && ToolObject[9].activeSelf 
         && (ToolObject[0].activeSelf || ToolObject[1].activeSelf))
        {
            
            //SaveSelectedCocktail("Bacardi Cocktail"); //?대떦 移듯뀒???대쫫 ???
              CocktailMaking();// ?ㅼ쓬 議곗＜ ?ъ쑝濡??대룞
        }
        else if (AlcoholObject[6].activeSelf && NonAlcoholObject[11].activeSelf
            && NonAlcoholObject[13].activeSelf && NonAlcoholObject[19].activeSelf 
            && CocktaillGlassObject[3].activeSelf && ToolObject[14].activeSelf&&ToolObject[10].activeSelf && ToolObject[11].activeSelf 
        && (ToolObject[5].activeSelf || ToolObject[6].activeSelf || ToolObject[7].activeSelf) && ToolObject[9].activeSelf)
        {
            
            //SaveSelectedCocktail("Cuba Libre"); //?대떦 移듯뀒???대쫫 ???
              CocktailMaking();// ?ㅼ쓬 議곗＜ ?ъ쑝濡??대룞
        }
        else if (AlcoholObject[11].activeSelf && AlcoholObject[16].activeSelf
            && NonAlcoholObject[9].activeSelf && CocktaillGlassObject[11].activeSelf&& ToolObject[14].activeSelf &&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf  && ToolObject[9].activeSelf 
         && (ToolObject[0].activeSelf || ToolObject[1].activeSelf))
        {
            
            //SaveSelectedCocktail("Grasshopper"); //?대떦 移듯뀒???대쫫 ???
              CocktailMaking();// ?ㅼ쓬 議곗＜ ?ъ쑝濡??대룞
        }
        else if (AlcoholObject[0].activeSelf && NonAlcoholObject[8].activeSelf
            && NonAlcoholObject[6].activeSelf
            &&(/*?쇱엫*/NonAlcoholObject[11].activeSelf || NonAlcoholObject[19].activeSelf) 
            && CocktaillGlassObject[3].activeSelf && ToolObject[14].activeSelf&&ToolObject[10].activeSelf && ToolObject[11].activeSelf 
        && (ToolObject[5].activeSelf || ToolObject[6].activeSelf || ToolObject[7].activeSelf) && ToolObject[9].activeSelf)
        {
            
            //SaveSelectedCocktail("Seabreeze"); //?대떦 移듯뀒???대쫫 ???
              CocktailMaking();// ?ㅼ쓬 議곗＜ ?ъ쑝濡??대룞
        }
        else if (AlcoholObject[0].activeSelf && AlcoholObject[25].activeSelf
            && NonAlcoholObject[11].activeSelf && NonAlcoholObject[23].activeSelf
            && CocktaillGlassObject[6].activeSelf && ToolObject[14].activeSelf&&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf  && ToolObject[9].activeSelf 
         && (ToolObject[0].activeSelf || ToolObject[1].activeSelf))
        {
            
            //SaveSelectedCocktail("Apple Martini"); //?대떦 移듯뀒???대쫫 ???
                      CocktailMaking();// ?ㅼ쓬 議곗＜ ?ъ쑝濡??대룞
        }
        else if (AlcoholObject[1].activeSelf && AlcoholObject[13].activeSelf && AlcoholObject[26].activeSelf
            && NonAlcoholObject[19].activeSelf && CocktaillGlassObject[2].activeSelf && ToolObject[14].activeSelf&&ToolObject[10].activeSelf && ToolObject[11].activeSelf 
        && (ToolObject[5].activeSelf || ToolObject[6].activeSelf || ToolObject[7].activeSelf) && ToolObject[9].activeSelf)
        {
            
            //SaveSelectedCocktail("Negroni"); //?대떦 移듯뀒???대쫫 ???
              CocktailMaking();// ?ㅼ쓬 議곗＜ ?ъ쑝濡??대룞
        }
        else if (AlcoholObject[1].activeSelf && AlcoholObject[0].activeSelf && AlcoholObject[6].activeSelf
            && AlcoholObject[17].activeSelf && AlcoholObject[2].activeSelf && NonAlcoholObject[0].activeSelf
            && NonAlcoholObject[13].activeSelf && (NonAlcoholObject[19].activeSelf || NonAlcoholObject[19].activeSelf)
             && CocktaillGlassObject[4].activeSelf && ToolObject[14].activeSelf&&ToolObject[10].activeSelf && ToolObject[11].activeSelf 
        && (ToolObject[5].activeSelf || ToolObject[6].activeSelf || ToolObject[7].activeSelf) && ToolObject[9].activeSelf)
        {
            
            //SaveSelectedCocktail("LongIslandIcedTea"); //?대떦 移듯뀒???대쫫 ???
                         CocktailMaking();// ?ㅼ쓬 議곗＜ ?ъ쑝濡??대룞
        }
        else if (AlcoholObject[3].activeSelf && AlcoholObject[17].activeSelf
            && NonAlcoholObject[4].activeSelf && CocktaillGlassObject[6].activeSelf && ToolObject[14].activeSelf&&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf  && ToolObject[9].activeSelf 
         && (ToolObject[0].activeSelf || ToolObject[1].activeSelf))
        {
            
            //SaveSelectedCocktail("Sidecar"); //?대떦 移듯뀒???대쫫 ???
                         CocktailMaking();// ?ㅼ쓬 議곗＜ ?ъ쑝濡??대룞
        }
        else if (AlcoholObject[6].activeSelf && AlcoholObject[17].activeSelf
            && NonAlcoholObject[10].activeSelf && NonAlcoholObject[11].activeSelf 
            && NonAlcoholObject[5].activeSelf && NonAlcoholObject[1].activeSelf 
            && NonAlcoholObject[20].activeSelf && NonAlcoholObject[22].activeSelf 
            && CocktaillGlassObject[16].activeSelf&& ToolObject[14].activeSelf
             && ToolObject[11].activeSelf && ToolObject[12].activeSelf && ToolObject[9].activeSelf)
        {
            
            //SaveSelectedCocktail("MaiTai"); //?대떦 移듯뀒???대쫫 ???
                         CocktailMaking();// ?ㅼ쓬 議곗＜ ?ъ쑝濡??대룞
        }
        else if (AlcoholObject[6].activeSelf && NonAlcoholObject[10].activeSelf
            && NonAlcoholObject[3].activeSelf && NonAlcoholObject[20].activeSelf
            && NonAlcoholObject[21].activeSelf && CocktaillGlassObject[16].activeSelf&& ToolObject[14].activeSelf
            && ToolObject[11].activeSelf && ToolObject[12].activeSelf && ToolObject[9].activeSelf )
        {
            
            //SaveSelectedCocktail("PinaColada"); //?대떦 移듯뀒???대쫫 ???
                      CocktailMaking();// ?ㅼ쓬 議곗＜ ?ъ쑝濡??대룞
        }
        else if (AlcoholObject[0].activeSelf && AlcoholObject[17].activeSelf
            && NonAlcoholObject[11].activeSelf && NonAlcoholObject[8].activeSelf && CocktaillGlassObject[0].activeSelf
&& ToolObject[14].activeSelf            &&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf  && ToolObject[9].activeSelf 
         && (ToolObject[0].activeSelf || ToolObject[1].activeSelf))
        {
            
            //SaveSelectedCocktail("Cosmopolitan"); //?대떦 移듯뀒???대쫫 ???
                      CocktailMaking();// ?ㅼ쓬 議곗＜ ?ъ쑝濡??대룞
        }
        else if (AlcoholObject[0].activeSelf && NonAlcoholObject[11].activeSelf
            && NonAlcoholObject[15].activeSelf && CocktaillGlassObject[3].activeSelf && ToolObject[14].activeSelf&&ToolObject[10].activeSelf && ToolObject[11].activeSelf 
        && (ToolObject[5].activeSelf || ToolObject[6].activeSelf || ToolObject[7].activeSelf) && ToolObject[9].activeSelf)
        {
            
            //SaveSelectedCocktail("MoscowMule"); //?대떦 移듯뀒???대쫫 ???
                      CocktailMaking();// ?ㅼ쓬 議곗＜ ?ъ쑝濡??대룞
        }
        else if (AlcoholObject[3].activeSelf && AlcoholObject[2].activeSelf
            && NonAlcoholObject[4].activeSelf && NonAlcoholObject[5].activeSelf && CocktaillGlassObject[6].activeSelf && ToolObject[14].activeSelf &&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf  && ToolObject[9].activeSelf 
         && (ToolObject[0].activeSelf || ToolObject[1].activeSelf) )
        {
            
            //SaveSelectedCocktail("Apricot"); //?대떦 移듯뀒???대쫫 ???
                      CocktailMaking();// ?ㅼ쓬 議곗＜ ?ъ쑝濡??대룞
        }
        else if (AlcoholObject[3].activeSelf && AlcoholObject[29].activeSelf && AlcoholObject[17].activeSelf
            && NonAlcoholObject[4].activeSelf && CocktaillGlassObject[6].activeSelf && ToolObject[14].activeSelf&&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf  && ToolObject[9].activeSelf 
         && (ToolObject[0].activeSelf || ToolObject[1].activeSelf))
        {
            
            //SaveSelectedCocktail("Honeymoon"); //?대떦 移듯뀒???대쫫 ???
                      CocktailMaking();// ?ㅼ쓬 議곗＜ ?ъ쑝濡??대룞
        }
        else if (AlcoholObject[6].activeSelf && AlcoholObject[30].activeSelf && AlcoholObject[19].activeSelf
            && NonAlcoholObject[10].activeSelf && CocktaillGlassObject[16].activeSelf&& ToolObject[14].activeSelf
             && ToolObject[11].activeSelf && ToolObject[12].activeSelf && ToolObject[9].activeSelf)
        {
            
            //SaveSelectedCocktail("BlueHawaiian"); //?대떦 移듯뀒???대쫫 ???
                         CocktailMaking();// ?ㅼ쓬 議곗＜ ?ъ쑝濡??대룞
        }
        else if (AlcoholObject[31].activeSelf //&& AlcoholObject[0].activeSelf
            && NonAlcoholObject[19].activeSelf && CocktaillGlassObject[9].activeSelf
&& ToolObject[14].activeSelf            &&ToolObject[10].activeSelf && ToolObject[11].activeSelf 
        && (ToolObject[5].activeSelf || ToolObject[6].activeSelf || ToolObject[7].activeSelf) && ToolObject[9].activeSelf)
        {
            
            //SaveSelectedCocktail("Kir"); //?대떦 移듯뀒???대쫫 ???
                       CocktailMaking();// ?ㅼ쓬 議곗＜ ?ъ쑝濡??대룞
        }
        else if (AlcoholObject[2].activeSelf && NonAlcoholObject[1].activeSelf
            && NonAlcoholObject[5].activeSelf && CocktaillGlassObject[16].activeSelf&& ToolObject[14].activeSelf
            &&ToolObject[10].activeSelf && ToolObject[11].activeSelf 
        && (ToolObject[5].activeSelf || ToolObject[6].activeSelf || ToolObject[7].activeSelf) && ToolObject[9].activeSelf)
        {
            
            //SaveSelectedCocktail("TequilaSunrise"); //?대떦 移듯뀒???대쫫 ???
                         CocktailMaking();// ?ㅼ쓬 議곗＜ ?ъ쑝濡??대룞
        }
        else if (AlcoholObject[36].activeSelf && AlcoholObject[29].activeSelf && AlcoholObject[31].activeSelf
            && NonAlcoholObject[0].activeSelf && NonAlcoholObject[19].activeSelf && CocktaillGlassObject[6].activeSelf && ToolObject[14].activeSelf&&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf  && ToolObject[9].activeSelf 
         && (ToolObject[0].activeSelf || ToolObject[1].activeSelf))
        {
            
            //SaveSelectedCocktail("Healing"); //?대떦 移듯뀒???대쫫 ???
                      CocktailMaking();// ?ㅼ쓬 議곗＜ ?ъ쑝濡??대룞
        }
        else if (AlcoholObject[38].activeSelf && AlcoholObject[10].activeSelf
            && NonAlcoholObject[7].activeSelf && NonAlcoholObject[1].activeSelf && CocktaillGlassObject[6].activeSelf && ToolObject[14].activeSelf&&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf  && ToolObject[9].activeSelf 
         && (ToolObject[0].activeSelf || ToolObject[1].activeSelf))
        {
            
            //SaveSelectedCocktail("Jindo"); //?대떦 移듯뀒???대쫫 ???
                      CocktailMaking();// ?ㅼ쓬 議곗＜ ?ъ쑝濡??대룞
        }
        else if (AlcoholObject[37].activeSelf && AlcoholObject[17].activeSelf && AlcoholObject[25].activeSelf
            && NonAlcoholObject[11].activeSelf && NonAlcoholObject[23].activeSelf  && CocktaillGlassObject[6].activeSelf && ToolObject[14].activeSelf&&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf  && ToolObject[9].activeSelf 
         && (ToolObject[0].activeSelf || ToolObject[1].activeSelf))
        {
            
            //SaveSelectedCocktail("PuppyLove"); //?대떦 移듯뀒???대쫫 ???
                      CocktailMaking();// ?ㅼ쓬 議곗＜ ?ъ쑝濡??대룞
        }
        else if (AlcoholObject[39].activeSelf && AlcoholObject[14].activeSelf && AlcoholObject[25].activeSelf
            && NonAlcoholObject[11].activeSelf && CocktaillGlassObject[6].activeSelf && ToolObject[14].activeSelf&&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf  && ToolObject[9].activeSelf 
         && (ToolObject[0].activeSelf || ToolObject[1].activeSelf))
        {
            
            //SaveSelectedCocktail("Geumsan"); //?대떦 移듯뀒???대쫫 ???
                      CocktailMaking();// ?ㅼ쓬 議곗＜ ?ъ쑝濡??대룞
        }
        else if (AlcoholObject[40].activeSelf && AlcoholObject[17].activeSelf 
            && NonAlcoholObject[15].activeSelf && CocktaillGlassObject[12].activeSelf&& ToolObject[14].activeSelf
            &&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf && ToolObject[2].activeSelf  && (ToolObject[5].activeSelf || ToolObject[6].activeSelf || ToolObject[7].activeSelf) && ToolObject[9].activeSelf)
        {
            
            //SaveSelectedCocktail("Gochang"); //?대떦 移듯뀒???대쫫 ???
                      CocktailMaking();// ?ㅼ쓬 議곗＜ ?ъ쑝濡??대룞
        }
        else if (AlcoholObject[1].activeSelf && NonAlcoholObject[12].activeSelf && NonAlcoholObject[17].activeSelf
            && NonAlcoholObject[4].activeSelf && NonAlcoholObject[19].activeSelf && CocktaillGlassObject[3].activeSelf
&& ToolObject[14].activeSelf            &&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf  && ToolObject[9].activeSelf 
         && (ToolObject[0].activeSelf || ToolObject[1].activeSelf) && (ToolObject[5].activeSelf || ToolObject[6].activeSelf || ToolObject[7].activeSelf))
        {
            
           // SaveSelectedCocktail("GinFizz"); //?대떦 移듯뀒???대쫫 ???
                      CocktailMaking();// ?ㅼ쓬 議곗＜ ?ъ쑝濡??대룞
        }
        else if (NonAlcoholObject[19].activeSelf && NonAlcoholObject[17].activeSelf
            && NonAlcoholObject[12].activeSelf && CocktaillGlassObject[3].activeSelf&& ToolObject[14].activeSelf&ToolObject[10].activeSelf && ToolObject[11].activeSelf 
        && (ToolObject[5].activeSelf || ToolObject[6].activeSelf || ToolObject[7].activeSelf) && ToolObject[9].activeSelf)
        {
            
            //SaveSelectedCocktail("FreshLemonSquash"); //?대떦 移듯뀒???대쫫 ???
                      CocktailMaking();// ?ㅼ쓬 議곗＜ ?ъ쑝濡??대룞
        }
        else if (NonAlcoholObject[5].activeSelf && NonAlcoholObject[8].activeSelf && NonAlcoholObject[1].activeSelf && NonAlcoholObject[4].activeSelf
            && NonAlcoholObject[10].activeSelf && NonAlcoholObject[6].activeSelf && CocktaillGlassObject[0].activeSelf
&& ToolObject[14].activeSelf             && ToolObject[11].activeSelf && ToolObject[12].activeSelf && ToolObject[9].activeSelf)
        {
            
            //SaveSelectedCocktail("VurginFruitPunch"); //?대떦 移듯뀒???대쫫 ???
                      CocktailMaking();// ?ㅼ쓬 議곗＜ ?ъ쑝濡??대룞
        }
        
        else
        {
            notcheck.SetActive(true);// ?由??덉떆???쒖“ ??"?ㅼ떆 ?좏깮" ?띿뒪???쒖꽦??
            Invoke("notcheck1", 0.7f); //0.7珥???鍮꾪솢?깊솕
        }


    }

    /*public void SaveSelectedCocktail(string cocktailName)
    {
        PlayerPrefs.SetString("SelectedCocktail", cocktailName); // ?좏깮??移듯뀒???대쫫 ???
    }*/

    public void CocktailMaking()
    {
        nextbtnM();
        SceneManager.LoadScene("ProtoTable"); // 濡쒕뱶??2(議곗＜???꾩쓽 踰덊샇)濡??대룞
        
    }


    private void notcheck1()
    {
        notcheck.SetActive(false); //"?ㅼ떆 ?좏깮" 鍮꾪솢?깊솕
    }


public void nextbtnM()// 踰덊샇 ?섍린湲?
{
    List<int> selectedAlcoholObjectIndices = new List<int>();
    List<int> selectedNonAlcoholObjectIndices = new List<int>();
    List<int> selectedCocktaillGlassObjectIndices = new List<int>();
    List<int> selectedToolObjectIndices = new List<int>(); 

    for (int i = 0; i < AlcoholObject.Length; i++)
    {
        if (AlcoholObject[i].activeSelf)
        {
            selectedAlcoholObjectIndices.Add(i);
        }
    }
    for (int i = 0; i < NonAlcoholObject.Length; i++)
    {
        if (NonAlcoholObject[i].activeSelf)
        {
            selectedNonAlcoholObjectIndices.Add(i);
        }
    }
    for (int i = 0; i < CocktaillGlassObject.Length; i++)
    {
        if (CocktaillGlassObject[i].activeSelf)
        {
            selectedCocktaillGlassObjectIndices.Add(i);
        }
    }
    for (int i = 0; i < ToolObject.Length; i++)
    {
        if (ToolObject[i].activeSelf)
        {
            selectedToolObjectIndices.Add(i);
        }
    }

    SaveSelectedObjects(selectedAlcoholObjectIndices,selectedNonAlcoholObjectIndices,selectedCocktaillGlassObjectIndices,selectedToolObjectIndices);
    

    SceneManager.LoadScene("ProtoTable");
}

public void SaveSelectedObjects(List<int> selectedAlcoholObjectIndices,List<int> selectedNonAlcoholObjectIndices,List<int> selectedCocktaillGlassObjectIndices,List<int> selectedToolObjectIndices)
{
    PlayerPrefs.SetInt("SelectedAlcoholObjectsCount", selectedAlcoholObjectIndices.Count);

    for (int i = 0; i < selectedAlcoholObjectIndices.Count; i++)
    {
        PlayerPrefs.SetInt("SelectedAlcoholObjectIndex" + i, selectedAlcoholObjectIndices[i]);
    }



     PlayerPrefs.SetInt("SelectedNonAlcoholObjectsCount", selectedNonAlcoholObjectIndices.Count);

    for (int i = 0; i < selectedNonAlcoholObjectIndices.Count; i++)
    {
        PlayerPrefs.SetInt("SelectedNonAlcoholObjectIndex" + i, selectedNonAlcoholObjectIndices[i]);
    }

     PlayerPrefs.SetInt("SelectedCocktaillGlassObjectsCount", selectedCocktaillGlassObjectIndices.Count);

    for (int i = 0; i < selectedCocktaillGlassObjectIndices.Count; i++)
    {
        PlayerPrefs.SetInt("SelectedCocktaillGlassObjectIndex" + i, selectedCocktaillGlassObjectIndices[i]);
    }

    PlayerPrefs.SetInt("SelectedToolObjectsCount", selectedToolObjectIndices.Count);

    for (int i = 0; i < selectedToolObjectIndices.Count; i++)
    {
        PlayerPrefs.SetInt("SelectedToolObjectIndex" + i, selectedToolObjectIndices[i]);
    }

     

    
}








    public void AllClear()
    {
        for(int i=0 ; i < AlcoholObject.Length ; i ++ ){
            AlcoholObject[i].SetActive(false);
        }
        for(int i=0 ; i < NonAlcoholObject.Length ; i ++ ){
            NonAlcoholObject[i].SetActive(false);
        }
        for(int i=0 ; i < CocktaillGlassObject.Length ; i ++ ){
            CocktaillGlassObject[i].SetActive(false);
        }
        for(int i=0 ;i < ToolObject.Length ; i ++ ){
            ToolObject[i].SetActive(false);
        }

    }
}
