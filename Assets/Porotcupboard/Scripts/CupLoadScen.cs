using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupLoadScen : MonoBehaviour
{
    // Start is called before the first frame update
   

    void Start()
    {
        string selectedCocktail = PlayerPrefs.GetString("SelectedCocktail"); //"SelectedCocktail" 키로 저장된 칵테일 이름을 가져오기
        Debug.Log(selectedCocktail); //디버그로 가져왔는지 확인
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
