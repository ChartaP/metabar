using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cocktailingredients : MonoBehaviour
{
    public GameObject notcheck; //잘못된 레시피 선택 시 뜨는 텍스트창
    public GameObject cocktailingredientslObject;// 컵보드에 있는 칵테일 재료들( 활성화,비활성화 조절 )
    public GameObject[] AlcoholObject; // 알콜 재료 객체 배열
    public GameObject[] NonAlcoholObject; //논알콜 재료 객체 배열
    public GameObject[] CocktaillGlassObject; //칵테일 잔 재료 객체 배열
    public GameObject[] ToolObject; //칵테일 도구 재료 객체 배열

    private int cocktailcheckcount = 0; //비활성,활성화를 조절하기 위한 카운트



    void Start()
    {
        cocktailingredientslObject.SetActive(false); // 첫 시작시 컵보드 칵테일 재료들 비활성화

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
            && NonAlcoholObject[1].activeSelf && CocktaillGlassObject[7].activeSelf)
        {
            //Debug.Log("Pousse Cafe");
            SaveSelectedCocktail("Pousse Cafe"); //해당 칵테일 이름 저장
            CocktailMaking(); // 다음 조주 씬으로 이동
        }
         // 각 배열에 입력된 재료들 중 Manhattan 레시피에 해당된 재료만 활성화 되면 "Manhattan"이름을 저장
        else if (AlcoholObject[8].activeSelf && AlcoholObject[11].activeSelf
            && AlcoholObject[32].activeSelf && NonAlcoholObject[20].activeSelf
            && CocktaillGlassObject[6].activeSelf)
        {
            //Debug.Log("Manhattan");
            SaveSelectedCocktail("Manhattan"); //해당 칵테일 이름 저장
            CocktailMaking();// 다음 조주 씬으로 이동
        }
         // 각 배열에 입력된 재료들 중 Dry Martini 레시피에 해당된 재료만 활성화 되면 "Dry Martini"이름을 저장
        else if (AlcoholObject[1].activeSelf && AlcoholObject[12].activeSelf
            && NonAlcoholObject[18].activeSelf && CocktaillGlassObject[6].activeSelf)
        {
            //Debug.Log("Dry Martini");
            SaveSelectedCocktail("Dry Martini"); //해당 칵테일 이름 저장
            CocktailMaking();// 다음 조주 씬으로 이동
        }
        else
        {
            notcheck.SetActive(true);// 틀린 레시피 제조 시 "다시 선택" 텍스트 활성화
            Invoke("notcheck1", 0.5f); //0.5초 후 비활성화
        }
    }

    public void SaveSelectedCocktail(string cocktailName)
    {
        PlayerPrefs.SetString("SelectedCocktail", cocktailName); // 선택된 칵테일 이름 저장
    }

    public void CocktailMaking()
    {
       
        SceneManager.LoadScene(2); // 로드씬 2로 이동
    }


    private void notcheck1()
    {
        notcheck.SetActive(false); //"다시 선택" 비활성화
    }
}
