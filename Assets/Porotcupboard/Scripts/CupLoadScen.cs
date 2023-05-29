using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupLoadScen : MonoBehaviour
{
    // Start is called before the first frame update
   

    void Start()
    {

         LoadSelectedObjects();
        
         
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadSelectedObjects()//재료 넘어 가져옴
{
    int selectedAlcoholObjectsCount = PlayerPrefs.GetInt("SelectedAlcoholObjectsCount");
    int selectedNonAlcoholObjectsCount = PlayerPrefs.GetInt("SelectedNonAlcoholObjectsCount");
    int selectedCocktaillGlassObjectsCount = PlayerPrefs.GetInt("SelectedCocktaillGlassObjectsCount");
    int selectedToolObjectsCount = PlayerPrefs.GetInt("SelectedToolObjectsCount");
   

    List<int> selectedAlcoholObjectIndices = new List<int>();
    List<int> selectedNonAlcoholObjectIndices = new List<int>();
    List<int> selectedCocktaillGlassObjectIndices = new List<int>();
    List<int> selectedToolObjectIndices = new List<int>();
    
    for (int i = 0; i < selectedAlcoholObjectsCount; i++)
    {
        int AlcoholobjectIndex = PlayerPrefs.GetInt("SelectedAlcoholObjectIndex" + i);
        selectedAlcoholObjectIndices.Add(AlcoholobjectIndex);
         Debug.Log("Alcohol : "+AlcoholobjectIndex);
    }
    for (int i = 0; i < selectedNonAlcoholObjectsCount; i++)
    {
        int NonAlcoholobjectIndex = PlayerPrefs.GetInt("SelectedNonAlcoholObjectIndex" + i);
        selectedNonAlcoholObjectIndices.Add(NonAlcoholobjectIndex);
         Debug.Log("NonAlcohol : "+NonAlcoholobjectIndex);
    }
    for (int i = 0; i < selectedCocktaillGlassObjectsCount; i++)
    {
        int CocktaillGlassobjectIndex = PlayerPrefs.GetInt("SelectedCocktaillGlassObjectIndex" + i);
        selectedCocktaillGlassObjectIndices.Add(CocktaillGlassobjectIndex);
         Debug.Log("CocktaillGlass : "+CocktaillGlassobjectIndex);
    }
    for (int i = 0; i < selectedToolObjectsCount; i++)
    {
        int ToolobjectIndex = PlayerPrefs.GetInt("SelectedToolObjectIndex" + i);
        selectedToolObjectIndices.Add(ToolobjectIndex);
         Debug.Log("Tool : "+ToolobjectIndex);
    }
    

    // 이후에 선택된 오브젝트 인덱스를 활용할 수 있습니다.
    // 예를 들어, 해당 인덱스를 사용하여 오브젝트를 활성화하거나 처리할 수 있습니다.
}

}
