using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cocktailingnext : MonoBehaviour
{


    public int cocktailMnum; // 칵테일 오브젝트의 식별자(ID)

    public void nextbtnM()
    {
        

        
    }
   
    public void SelectedCocktailMID(string cocktailMnum)
    {
        PlayerPrefs.SetString("SelectedCocktailMID", cocktailMnum); // 선택된 칵테일 이름 저장
    }
    
}
