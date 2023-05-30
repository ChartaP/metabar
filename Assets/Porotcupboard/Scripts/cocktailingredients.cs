using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//using System.Collections.Generic;

public class cocktailingredients : MonoBehaviour
{
    public GameObject notcheck; //잘못된 레시피 선택 시 뜨는 텍스트창
    public GameObject cocktailingredientslObject;// 컵보드에 있는 칵테일 재료들( 활성화,비활성화 조절 )
    public GameObject[] AlcoholObject; // 알콜 재료 객체 배열
    public GameObject[] NonAlcoholObject; //논알콜 재료 객체 배열
    public GameObject[] CocktaillGlassObject; //칵테일 잔 재료 객체 배열
    public GameObject[] ToolObject; //칵테일 도구 재료 객체 배열
   // public int cocktailMnum;
   

    private int cocktailcheckcount = 0; //비활성,활성화를 조절하기 위한 카운트



    void Start()
    {
        cocktailingredientslObject.SetActive(false);
    }
    

    public void OnButtonClick()
    {
        cocktailcheckcount += 1;  //컵보드 천장에 있는 스크롤 UI에 있는 재료형 버튼 누를 시 카운트 +1

        if (cocktailcheckcount % 2 != 0) // 카운트가 홀수면 하단 컵보드바에 있는 해당버튼과 같은 종류인 칵테일 재료 활성화
        {
            cocktailingredientslObject.SetActive(true);
        }
        else //카운트가 짝수면 하단 컵보드바에 있는 해당버튼과 같은 종류인 칵테일 재료 비활성화
        {
            cocktailingredientslObject.SetActive(false);
        }
        
    }

    public void CocktailingredientsCheck()
    {

        // 각 배열에 입력된 재료들 중 Pousse Cafe 레시피에 해당된 재료만 활성화 되면 "Pousse Cafe"이름을 저장
        if (AlcoholObject[11].activeSelf && AlcoholObject[3].activeSelf 
            && NonAlcoholObject[1].activeSelf && CocktaillGlassObject[7].activeSelf
&& ToolObject[14].activeSelf             && (ToolObject[5].activeSelf || ToolObject[6].activeSelf || ToolObject[7].activeSelf) && ToolObject[9].activeSelf)
        {
            //Debug.Log("Pousse Cafe");
            //SaveSelectedCocktail("Pousse Cafe"); //해당 칵테일 이름 저장
              CocktailMaking(); // 다음 조주 씬으로 이동
        }
         // 각 배열에 입력된 재료들 중 Manhattan 레시피에 해당된 재료만 활성화 되면 "Manhattan"이름을 저장
        else if (AlcoholObject[8].activeSelf && AlcoholObject[11].activeSelf
            && AlcoholObject[32].activeSelf && NonAlcoholObject[20].activeSelf
            && CocktaillGlassObject[6].activeSelf && ToolObject[14].activeSelf&&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf && ToolObject[2].activeSelf  && (ToolObject[5].activeSelf || ToolObject[6].activeSelf || ToolObject[7].activeSelf) && ToolObject[9].activeSelf)
        {
            //Debug.Log("Manhattan");
            //SaveSelectedCocktail("Manhattan"); //해당 칵테일 이름 저장
              CocktailMaking();// 다음 조주 씬으로 이동
        }
         // 각 배열에 입력된 재료들 중 Dry Martini 레시피에 해당된 재료만 활성화 되면 "Dry Martini"이름을 저장
        else if (AlcoholObject[1].activeSelf && AlcoholObject[12].activeSelf
            && NonAlcoholObject[18].activeSelf && CocktaillGlassObject[6].activeSelf
&& ToolObject[14].activeSelf            &&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf && ToolObject[2].activeSelf  && (ToolObject[5].activeSelf || ToolObject[6].activeSelf || ToolObject[7].activeSelf) && ToolObject[9].activeSelf)
        {
            //Debug.Log("Dry Martini");
            //SaveSelectedCocktail("Dry Martini"); //해당 칵테일 이름 저장
              CocktailMaking();// 다음 조주 씬으로 이동
        }
        else if (AlcoholObject[8].activeSelf && AlcoholObject[32].activeSelf
            && NonAlcoholObject[17].activeSelf && NonAlcoholObject[12].activeSelf
            && NonAlcoholObject[20].activeSelf && NonAlcoholObject[22].activeSelf
            && CocktaillGlassObject[2].activeSelf
&& ToolObject[14].activeSelf            &&ToolObject[10].activeSelf && ToolObject[11].activeSelf 
        && (ToolObject[5].activeSelf || ToolObject[6].activeSelf || ToolObject[7].activeSelf) && ToolObject[9].activeSelf
)
        {
            
            //SaveSelectedCocktail("Old Fashioned"); //해당 칵테일 이름 저장
              CocktailMaking();// 다음 조주 씬으로 이동
        }
        else if (AlcoholObject[3].activeSelf && AlcoholObject[15].activeSelf
            && NonAlcoholObject[9].activeSelf &&/*넛트파우더로 변경*/ NonAlcoholObject[0].activeSelf && CocktaillGlassObject[6].activeSelf
&& ToolObject[14].activeSelf            &&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf  && ToolObject[9].activeSelf 
         && (ToolObject[0].activeSelf || ToolObject[1].activeSelf))
        {
            //넛트 파우더 추가
            //SaveSelectedCocktail("Brandy Aiexander"); //해당 칵테일 이름 저장
              CocktailMaking();// 다음 조주 씬으로 이동
        }
        else if (AlcoholObject[1].activeSelf && AlcoholObject[33].activeSelf
            && NonAlcoholObject[4].activeSelf && NonAlcoholObject[17].activeSelf && NonAlcoholObject[12].activeSelf 
            && CocktaillGlassObject[16].activeSelf&& ToolObject[14].activeSelf &&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf  && ToolObject[9].activeSelf 
         && (ToolObject[0].activeSelf || ToolObject[1].activeSelf) && (ToolObject[5].activeSelf || ToolObject[6].activeSelf || ToolObject[7].activeSelf))
        {
            
            //SaveSelectedCocktail("Singapore Sling"); //해당 칵테일 이름 저장
              CocktailMaking();// 다음 조주 씬으로 이동
        }
        else if (AlcoholObject[0].activeSelf && AlcoholObject[14].activeSelf
            &&CocktaillGlassObject[2].activeSelf &&ToolObject[10].activeSelf && ToolObject[11].activeSelf 
        && (ToolObject[5].activeSelf || ToolObject[6].activeSelf || ToolObject[7].activeSelf) && ToolObject[9].activeSelf)
        {
            
            //SaveSelectedCocktail("Black Russian"); //해당 칵테일 이름 저장
              CocktailMaking();// 다음 조주 씬으로 이동
        }
        else if (AlcoholObject[2].activeSelf && (AlcoholObject[27].activeSelf ||AlcoholObject[17].activeSelf)
            && NonAlcoholObject[11].activeSelf && NonAlcoholObject[16].activeSelf && CocktaillGlassObject[6].activeSelf
&& ToolObject[14].activeSelf            &&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf  && ToolObject[9].activeSelf 
         && (ToolObject[0].activeSelf || ToolObject[1].activeSelf)
)
        {
            
            //SaveSelectedCocktail("Mararita"); //해당 칵테일 이름 저장
            CocktailMaking();// 다음 조주 씬으로 이동
        }
        else if (AlcoholObject[9].activeSelf && AlcoholObject[18].activeSelf
            && CocktaillGlassObject[2].activeSelf && ToolObject[14].activeSelf&&ToolObject[10].activeSelf && ToolObject[11].activeSelf 
        && (ToolObject[5].activeSelf || ToolObject[6].activeSelf || ToolObject[7].activeSelf) && ToolObject[9].activeSelf)
        {
            
            //SaveSelectedCocktail("Rusty Nail"); //해당 칵테일 이름 저장
              CocktailMaking();// 다음 조주 씬으로 이동
        }
        else if (AlcoholObject[8].activeSelf && NonAlcoholObject[4].activeSelf
            && NonAlcoholObject[17].activeSelf && NonAlcoholObject[12].activeSelf
            && NonAlcoholObject[19].activeSelf && NonAlcoholObject[20].activeSelf
             && CocktaillGlassObject[14].activeSelf&& ToolObject[14].activeSelf &&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf  && ToolObject[9].activeSelf 
         && (ToolObject[0].activeSelf || ToolObject[1].activeSelf) && (ToolObject[5].activeSelf || ToolObject[6].activeSelf || ToolObject[7].activeSelf))
        {
            
            //SaveSelectedCocktail("Whiskey Sour"); //해당 칵테일 이름 저장
              CocktailMaking();// 다음 조주 씬으로 이동
        }
        else if (AlcoholObject[8].activeSelf && NonAlcoholObject[11].activeSelf
            && NonAlcoholObject[17].activeSelf && NonAlcoholObject[1].activeSelf
            && NonAlcoholObject[19].activeSelf && CocktaillGlassObject[6].activeSelf && ToolObject[14].activeSelf &&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf  && ToolObject[9].activeSelf 
         && (ToolObject[0].activeSelf || ToolObject[1].activeSelf))
        {
            
            //SaveSelectedCocktail("New York"); //해당 칵테일 이름 저장
              CocktailMaking();// 다음 조주 씬으로 이동
        }
        else if (AlcoholObject[6].activeSelf && NonAlcoholObject[11].activeSelf
            && NonAlcoholObject[17].activeSelf && CocktaillGlassObject[6].activeSelf && ToolObject[14].activeSelf &&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf  && ToolObject[9].activeSelf 
         && (ToolObject[0].activeSelf || ToolObject[1].activeSelf))
        {
            
            //SaveSelectedCocktail("Daiquirl"); //해당 칵테일 이름 저장
              CocktailMaking();// 다음 조주 씬으로 이동
        }
        else if (AlcoholObject[14].activeSelf && AlcoholObject[20].activeSelf && AlcoholObject[21].activeSelf
            &&  CocktaillGlassObject[8].activeSelf && (ToolObject[5].activeSelf || ToolObject[6].activeSelf || ToolObject[7].activeSelf) && ToolObject[9].activeSelf)
        {
            
            //SaveSelectedCocktail("Cocktail_B52"); //해당 칵테일 이름 저장
              CocktailMaking();// 다음 조주 씬으로 이동
        }
        else if (AlcoholObject[23].activeSelf && AlcoholObject[19].activeSelf && /*바나나리큐르*/AlcoholObject[0].activeSelf
            && NonAlcoholObject[10].activeSelf && NonAlcoholObject[0].activeSelf 
            && NonAlcoholObject[20].activeSelf && NonAlcoholObject[21].activeSelf 
            && CocktaillGlassObject[4].activeSelf && ToolObject[14].activeSelf&&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf  && ToolObject[9].activeSelf 
         && (ToolObject[0].activeSelf || ToolObject[1].activeSelf) )
        {
            
            //SaveSelectedCocktail("Jun Bug"); //해당 칵테일 이름 저장
              CocktailMaking();// 다음 조주 씬으로 이동
        }
        else if (AlcoholObject[7].activeSelf && NonAlcoholObject[11].activeSelf
            && NonAlcoholObject[2].activeSelf && CocktaillGlassObject[6].activeSelf && ToolObject[14].activeSelf
            &&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf  && ToolObject[9].activeSelf 
         && (ToolObject[0].activeSelf || ToolObject[1].activeSelf))
        {
            
            //SaveSelectedCocktail("Bacardi Cocktail"); //해당 칵테일 이름 저장
              CocktailMaking();// 다음 조주 씬으로 이동
        }
        else if (AlcoholObject[6].activeSelf && NonAlcoholObject[11].activeSelf
            && NonAlcoholObject[13].activeSelf && NonAlcoholObject[19].activeSelf 
            && CocktaillGlassObject[3].activeSelf && ToolObject[14].activeSelf&&ToolObject[10].activeSelf && ToolObject[11].activeSelf 
        && (ToolObject[5].activeSelf || ToolObject[6].activeSelf || ToolObject[7].activeSelf) && ToolObject[9].activeSelf)
        {
            
            //SaveSelectedCocktail("Cuba Libre"); //해당 칵테일 이름 저장
              CocktailMaking();// 다음 조주 씬으로 이동
        }
        else if (AlcoholObject[11].activeSelf && AlcoholObject[16].activeSelf
            && NonAlcoholObject[9].activeSelf && CocktaillGlassObject[11].activeSelf&& ToolObject[14].activeSelf &&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf  && ToolObject[9].activeSelf 
         && (ToolObject[0].activeSelf || ToolObject[1].activeSelf))
        {
            
            //SaveSelectedCocktail("Grasshopper"); //해당 칵테일 이름 저장
              CocktailMaking();// 다음 조주 씬으로 이동
        }
        else if (AlcoholObject[0].activeSelf && NonAlcoholObject[8].activeSelf
            && NonAlcoholObject[6].activeSelf
            &&(/*라임*/NonAlcoholObject[11].activeSelf || NonAlcoholObject[19].activeSelf) 
            && CocktaillGlassObject[3].activeSelf && ToolObject[14].activeSelf&&ToolObject[10].activeSelf && ToolObject[11].activeSelf 
        && (ToolObject[5].activeSelf || ToolObject[6].activeSelf || ToolObject[7].activeSelf) && ToolObject[9].activeSelf)
        {
            
            //SaveSelectedCocktail("Seabreeze"); //해당 칵테일 이름 저장
              CocktailMaking();// 다음 조주 씬으로 이동
        }
        else if (AlcoholObject[0].activeSelf && AlcoholObject[25].activeSelf
            && NonAlcoholObject[11].activeSelf && NonAlcoholObject[23].activeSelf
            && CocktaillGlassObject[6].activeSelf && ToolObject[14].activeSelf&&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf  && ToolObject[9].activeSelf 
         && (ToolObject[0].activeSelf || ToolObject[1].activeSelf))
        {
            
            //SaveSelectedCocktail("Apple Martini"); //해당 칵테일 이름 저장
                      CocktailMaking();// 다음 조주 씬으로 이동
        }
        else if (AlcoholObject[1].activeSelf && AlcoholObject[13].activeSelf && AlcoholObject[26].activeSelf
            && NonAlcoholObject[19].activeSelf && CocktaillGlassObject[2].activeSelf && ToolObject[14].activeSelf&&ToolObject[10].activeSelf && ToolObject[11].activeSelf 
        && (ToolObject[5].activeSelf || ToolObject[6].activeSelf || ToolObject[7].activeSelf) && ToolObject[9].activeSelf)
        {
            
            //SaveSelectedCocktail("Negroni"); //해당 칵테일 이름 저장
              CocktailMaking();// 다음 조주 씬으로 이동
        }
        else if (AlcoholObject[1].activeSelf && AlcoholObject[0].activeSelf && AlcoholObject[6].activeSelf
            && AlcoholObject[17].activeSelf && AlcoholObject[2].activeSelf && NonAlcoholObject[0].activeSelf
            && NonAlcoholObject[13].activeSelf && (NonAlcoholObject[19].activeSelf || NonAlcoholObject[19].activeSelf)
             && CocktaillGlassObject[4].activeSelf && ToolObject[14].activeSelf&&ToolObject[10].activeSelf && ToolObject[11].activeSelf 
        && (ToolObject[5].activeSelf || ToolObject[6].activeSelf || ToolObject[7].activeSelf) && ToolObject[9].activeSelf)
        {
            
            //SaveSelectedCocktail("LongIslandIcedTea"); //해당 칵테일 이름 저장
                         CocktailMaking();// 다음 조주 씬으로 이동
        }
        else if (AlcoholObject[3].activeSelf && AlcoholObject[17].activeSelf
            && NonAlcoholObject[4].activeSelf && CocktaillGlassObject[6].activeSelf && ToolObject[14].activeSelf&&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf  && ToolObject[9].activeSelf 
         && (ToolObject[0].activeSelf || ToolObject[1].activeSelf))
        {
            
            //SaveSelectedCocktail("Sidecar"); //해당 칵테일 이름 저장
                         CocktailMaking();// 다음 조주 씬으로 이동
        }
        else if (AlcoholObject[6].activeSelf && AlcoholObject[17].activeSelf
            && NonAlcoholObject[10].activeSelf && NonAlcoholObject[11].activeSelf 
            && NonAlcoholObject[5].activeSelf && NonAlcoholObject[1].activeSelf 
            && NonAlcoholObject[20].activeSelf && NonAlcoholObject[22].activeSelf 
            && CocktaillGlassObject[16].activeSelf&& ToolObject[14].activeSelf
             && ToolObject[11].activeSelf && ToolObject[12].activeSelf && ToolObject[9].activeSelf)
        {
            
            //SaveSelectedCocktail("MaiTai"); //해당 칵테일 이름 저장
                         CocktailMaking();// 다음 조주 씬으로 이동
        }
        else if (AlcoholObject[6].activeSelf && NonAlcoholObject[10].activeSelf
            && NonAlcoholObject[3].activeSelf && NonAlcoholObject[20].activeSelf
            && NonAlcoholObject[21].activeSelf && CocktaillGlassObject[16].activeSelf&& ToolObject[14].activeSelf
            && ToolObject[11].activeSelf && ToolObject[12].activeSelf && ToolObject[9].activeSelf )
        {
            
            //SaveSelectedCocktail("PinaColada"); //해당 칵테일 이름 저장
                      CocktailMaking();// 다음 조주 씬으로 이동
        }
        else if (AlcoholObject[0].activeSelf && AlcoholObject[17].activeSelf
            && NonAlcoholObject[11].activeSelf && NonAlcoholObject[8].activeSelf && CocktaillGlassObject[0].activeSelf
&& ToolObject[14].activeSelf            &&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf  && ToolObject[9].activeSelf 
         && (ToolObject[0].activeSelf || ToolObject[1].activeSelf))
        {
            
            //SaveSelectedCocktail("Cosmopolitan"); //해당 칵테일 이름 저장
                      CocktailMaking();// 다음 조주 씬으로 이동
        }
        else if (AlcoholObject[0].activeSelf && NonAlcoholObject[11].activeSelf
            && NonAlcoholObject[15].activeSelf && CocktaillGlassObject[3].activeSelf && ToolObject[14].activeSelf&&ToolObject[10].activeSelf && ToolObject[11].activeSelf 
        && (ToolObject[5].activeSelf || ToolObject[6].activeSelf || ToolObject[7].activeSelf) && ToolObject[9].activeSelf)
        {
            
            //SaveSelectedCocktail("MoscowMule"); //해당 칵테일 이름 저장
                      CocktailMaking();// 다음 조주 씬으로 이동
        }
        else if (AlcoholObject[3].activeSelf && AlcoholObject[2].activeSelf
            && NonAlcoholObject[4].activeSelf && NonAlcoholObject[5].activeSelf && CocktaillGlassObject[6].activeSelf && ToolObject[14].activeSelf &&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf  && ToolObject[9].activeSelf 
         && (ToolObject[0].activeSelf || ToolObject[1].activeSelf) )
        {
            
            //SaveSelectedCocktail("Apricot"); //해당 칵테일 이름 저장
                      CocktailMaking();// 다음 조주 씬으로 이동
        }
        else if (AlcoholObject[3].activeSelf && AlcoholObject[29].activeSelf && AlcoholObject[17].activeSelf
            && NonAlcoholObject[4].activeSelf && CocktaillGlassObject[6].activeSelf && ToolObject[14].activeSelf&&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf  && ToolObject[9].activeSelf 
         && (ToolObject[0].activeSelf || ToolObject[1].activeSelf))
        {
            
            //SaveSelectedCocktail("Honeymoon"); //해당 칵테일 이름 저장
                      CocktailMaking();// 다음 조주 씬으로 이동
        }
        else if (AlcoholObject[6].activeSelf && AlcoholObject[30].activeSelf && AlcoholObject[19].activeSelf
            && NonAlcoholObject[10].activeSelf && CocktaillGlassObject[16].activeSelf&& ToolObject[14].activeSelf
             && ToolObject[11].activeSelf && ToolObject[12].activeSelf && ToolObject[9].activeSelf)
        {
            
            //SaveSelectedCocktail("BlueHawaiian"); //해당 칵테일 이름 저장
                         CocktailMaking();// 다음 조주 씬으로 이동
        }
        else if (AlcoholObject[31].activeSelf //&& AlcoholObject[0].activeSelf
            && NonAlcoholObject[19].activeSelf && CocktaillGlassObject[9].activeSelf
&& ToolObject[14].activeSelf            &&ToolObject[10].activeSelf && ToolObject[11].activeSelf 
        && (ToolObject[5].activeSelf || ToolObject[6].activeSelf || ToolObject[7].activeSelf) && ToolObject[9].activeSelf)
        {
            
            //SaveSelectedCocktail("Kir"); //해당 칵테일 이름 저장
                       CocktailMaking();// 다음 조주 씬으로 이동
        }
        else if (AlcoholObject[2].activeSelf && NonAlcoholObject[1].activeSelf
            && NonAlcoholObject[5].activeSelf && CocktaillGlassObject[16].activeSelf&& ToolObject[14].activeSelf
            &&ToolObject[10].activeSelf && ToolObject[11].activeSelf 
        && (ToolObject[5].activeSelf || ToolObject[6].activeSelf || ToolObject[7].activeSelf) && ToolObject[9].activeSelf)
        {
            
            //SaveSelectedCocktail("TequilaSunrise"); //해당 칵테일 이름 저장
                         CocktailMaking();// 다음 조주 씬으로 이동
        }
        else if (AlcoholObject[36].activeSelf && AlcoholObject[29].activeSelf && AlcoholObject[31].activeSelf
            && NonAlcoholObject[0].activeSelf && NonAlcoholObject[19].activeSelf && CocktaillGlassObject[6].activeSelf && ToolObject[14].activeSelf&&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf  && ToolObject[9].activeSelf 
         && (ToolObject[0].activeSelf || ToolObject[1].activeSelf))
        {
            
            //SaveSelectedCocktail("Healing"); //해당 칵테일 이름 저장
                      CocktailMaking();// 다음 조주 씬으로 이동
        }
        else if (AlcoholObject[38].activeSelf && AlcoholObject[10].activeSelf
            && NonAlcoholObject[7].activeSelf && NonAlcoholObject[1].activeSelf && CocktaillGlassObject[6].activeSelf && ToolObject[14].activeSelf&&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf  && ToolObject[9].activeSelf 
         && (ToolObject[0].activeSelf || ToolObject[1].activeSelf))
        {
            
            //SaveSelectedCocktail("Jindo"); //해당 칵테일 이름 저장
                      CocktailMaking();// 다음 조주 씬으로 이동
        }
        else if (AlcoholObject[37].activeSelf && AlcoholObject[17].activeSelf && AlcoholObject[25].activeSelf
            && NonAlcoholObject[11].activeSelf && NonAlcoholObject[23].activeSelf  && CocktaillGlassObject[6].activeSelf && ToolObject[14].activeSelf&&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf  && ToolObject[9].activeSelf 
         && (ToolObject[0].activeSelf || ToolObject[1].activeSelf))
        {
            
            //SaveSelectedCocktail("PuppyLove"); //해당 칵테일 이름 저장
                      CocktailMaking();// 다음 조주 씬으로 이동
        }
        else if (AlcoholObject[39].activeSelf && AlcoholObject[14].activeSelf && AlcoholObject[25].activeSelf
            && NonAlcoholObject[11].activeSelf && CocktaillGlassObject[6].activeSelf && ToolObject[14].activeSelf&&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf  && ToolObject[9].activeSelf 
         && (ToolObject[0].activeSelf || ToolObject[1].activeSelf))
        {
            
            //SaveSelectedCocktail("Geumsan"); //해당 칵테일 이름 저장
                      CocktailMaking();// 다음 조주 씬으로 이동
        }
        else if (AlcoholObject[40].activeSelf && AlcoholObject[17].activeSelf 
            && NonAlcoholObject[15].activeSelf && CocktaillGlassObject[12].activeSelf&& ToolObject[14].activeSelf
            &&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf && ToolObject[2].activeSelf  && (ToolObject[5].activeSelf || ToolObject[6].activeSelf || ToolObject[7].activeSelf) && ToolObject[9].activeSelf)
        {
            
            //SaveSelectedCocktail("Gochang"); //해당 칵테일 이름 저장
                      CocktailMaking();// 다음 조주 씬으로 이동
        }
        else if (AlcoholObject[1].activeSelf && NonAlcoholObject[12].activeSelf && NonAlcoholObject[17].activeSelf
            && NonAlcoholObject[4].activeSelf && NonAlcoholObject[19].activeSelf && CocktaillGlassObject[3].activeSelf
&& ToolObject[14].activeSelf            &&ToolObject[10].activeSelf && ToolObject[11].activeSelf && ToolObject[13].activeSelf  && ToolObject[9].activeSelf 
         && (ToolObject[0].activeSelf || ToolObject[1].activeSelf) && (ToolObject[5].activeSelf || ToolObject[6].activeSelf || ToolObject[7].activeSelf))
        {
            
           // SaveSelectedCocktail("GinFizz"); //해당 칵테일 이름 저장
                      CocktailMaking();// 다음 조주 씬으로 이동
        }
        else if (NonAlcoholObject[19].activeSelf && NonAlcoholObject[17].activeSelf
            && NonAlcoholObject[12].activeSelf && CocktaillGlassObject[3].activeSelf&& ToolObject[14].activeSelf&ToolObject[10].activeSelf && ToolObject[11].activeSelf 
        && (ToolObject[5].activeSelf || ToolObject[6].activeSelf || ToolObject[7].activeSelf) && ToolObject[9].activeSelf)
        {
            
            //SaveSelectedCocktail("FreshLemonSquash"); //해당 칵테일 이름 저장
                      CocktailMaking();// 다음 조주 씬으로 이동
        }
        else if (NonAlcoholObject[5].activeSelf && NonAlcoholObject[8].activeSelf && NonAlcoholObject[1].activeSelf && NonAlcoholObject[4].activeSelf
            && NonAlcoholObject[10].activeSelf && NonAlcoholObject[6].activeSelf && CocktaillGlassObject[0].activeSelf
&& ToolObject[14].activeSelf             && ToolObject[11].activeSelf && ToolObject[12].activeSelf && ToolObject[9].activeSelf)
        {
            
            //SaveSelectedCocktail("VurginFruitPunch"); //해당 칵테일 이름 저장
                      CocktailMaking();// 다음 조주 씬으로 이동
        }
        
        else
        {
            notcheck.SetActive(true);// 틀린 레시피 제조 시 "다시 선택" 텍스트 활성화
            Invoke("notcheck1", 0.7f); //0.7초 후 비활성화
        }


    }

    /*public void SaveSelectedCocktail(string cocktailName)
    {
        PlayerPrefs.SetString("SelectedCocktail", cocktailName); // 선택된 칵테일 이름 저장
    }*/

    public void CocktailMaking()
    {
        nextbtnM();
        SceneManager.LoadScene(2); // 로드씬 2(조주씬 임의 번호)로 이동
        
    }


    private void notcheck1()
    {
        notcheck.SetActive(false); //"다시 선택" 비활성화
    }


public void nextbtnM()// 번호 넘기기
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
    

    SceneManager.LoadScene(2);
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
