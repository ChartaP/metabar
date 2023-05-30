using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;
using static UnityEngine.GridBrushBase;
using UnityEngine.SceneManagement;

public class ProtoTable : MonoBehaviour
{
    [SerializeField]
    private GameObject[] tools;
    [SerializeField]
    private GameObject[] glasses;
    [SerializeField]
    private GameObject[] alcohols;
    [SerializeField]
    private GameObject[] nonAlcoholics;


    [SerializeField]
    private bool isUsingPre = false;

    [SerializeField]
    private Vector3[] toolPos;
    [SerializeField]
    private Vector3[] glassPos;
    [SerializeField]
    private Vector3[] drinkPos;

    [SerializeField]
    private ToolName[] preTools;

    [SerializeField]
    private GlassName[] preGlasses;

    [SerializeField]
    private DrinkName[] preDrinks;

    [SerializeField]
    private Transform ToastPoint;

    [SerializeField]
    private GameObject ToastMsg;

    private  List<int> selectedAlcoholObjectIndices = new List<int>();
    private List<int> selectedNonAlcoholObjectIndices = new List<int>();
    private List<int> selectedCocktaillGlassObjectIndices = new List<int>();
    private List<int> selectedToolObjectIndices = new List<int>();


    [SerializeField]
    private TableCoaster coaster = null;

    [SerializeField]
    private int timeLimit = 420;

    [SerializeField]
    private Timer timer = null;


    private void Load()
    {
        if(PlayerPrefs.HasKey("TimerCount"))
            timeLimit = PlayerPrefs.GetInt("TimerCount");
        if (isUsingPre)
        {
            
        }
        else
        {
            int selectedAlcoholObjectsCount = PlayerPrefs.GetInt("SelectedAlcoholObjectsCount");
            int selectedNonAlcoholObjectsCount = PlayerPrefs.GetInt("SelectedNonAlcoholObjectsCount");
            int selectedCocktaillGlassObjectsCount = PlayerPrefs.GetInt("SelectedCocktaillGlassObjectsCount");
            int selectedToolObjectsCount = PlayerPrefs.GetInt("SelectedToolObjectsCount");
            Debug.Log("alCount:"+ selectedAlcoholObjectsCount+ "nonCount:" + selectedNonAlcoholObjectsCount + "glCount:" + selectedCocktaillGlassObjectsCount + "toCount:" + selectedToolObjectsCount);
            for (int i = 0; i < selectedAlcoholObjectsCount; i++)
            {
                int AlcoholobjectIndex = PlayerPrefs.GetInt("SelectedAlcoholObjectIndex" + i);
                selectedAlcoholObjectIndices.Add(AlcoholobjectIndex);
                Debug.Log("Alcohol : " + AlcoholobjectIndex);

            }
            for (int i = 0; i < selectedNonAlcoholObjectsCount; i++)
            {
                int NonAlcoholobjectIndex = PlayerPrefs.GetInt("SelectedNonAlcoholObjectIndex" + i);
                selectedNonAlcoholObjectIndices.Add(NonAlcoholobjectIndex);
                Debug.Log("NonAlcohol : " + NonAlcoholobjectIndex);
            }
            for (int i = 0; i < selectedCocktaillGlassObjectsCount; i++)
            {
                int CocktaillGlassobjectIndex = PlayerPrefs.GetInt("SelectedCocktaillGlassObjectIndex" + i);
                if (PlayerPrefs.GetInt("BlackRussiansuccese") == 1 && CocktaillGlassobjectIndex == 2)
                {
                    selectedCocktaillGlassObjectIndices.Add(19);
                    continue;
                }
                if (PlayerPrefs.GetInt("PousseCafesuccese") == 1 && CocktaillGlassobjectIndex == 7)
                {
                    selectedCocktaillGlassObjectIndices.Add(19);
                    continue;
                }
                if (PlayerPrefs.GetInt("B52succese") == 1 && CocktaillGlassobjectIndex == 8)
                {
                    selectedCocktaillGlassObjectIndices.Add(19);
                    continue;
                }

                selectedCocktaillGlassObjectIndices.Add(CocktaillGlassobjectIndex);
                Debug.Log("CocktaillGlass : " + CocktaillGlassobjectIndex);
            }
            for (int i = 0; i < selectedToolObjectsCount; i++)
            {
                int ToolobjectIndex = PlayerPrefs.GetInt("SelectedToolObjectIndex" + i);
                selectedToolObjectIndices.Add(ToolobjectIndex);
                Debug.Log("Tool : " + ToolobjectIndex);
            }
        }
    }

    private void Save()
    {
        PlayerPrefs.SetInt("TimerCount",timeLimit);
    }

    protected void OnDestroy()
    {
        Save();
    }

    // Start is called before the first frame update
    void Start()
    {
        Load();
        ToolSet();
        GlassSet();
        AlcoholSet();
        //NonAlcoholicSet();
        StartCoroutine(TimerCount());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            timeLimit -= 10;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            timeLimit += 10;
        }
    }

    private IEnumerator TimerCount()
    {
        timer.SetTime(timeLimit);
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLimit -= 1;
            timer.SetTime(timeLimit);
            if(timeLimit <= 0)
            {
                SceneChange("FailScene");
                Debug.Log("??ル∥六???걠????ル∥吏???⑹맶???됯뎡");
            }
        }
    }

    private void ToolSet()
    {
        Vector3 pos = transform.position;
        int i = 0;
        if (isUsingPre)
        {
            foreach (ToolName toolID in preTools)
            {
                pos = toolPos[i++];
                Instantiate(this.tools[(char)toolID], pos, Quaternion.identity, transform);
            }
        }
        else
        {
            foreach (int toolID in selectedToolObjectIndices)
            {
                pos = toolPos[i++];
                Instantiate(this.tools[toolID], pos, Quaternion.identity, transform);
            }
        }

    }

    private void GlassSet()
    {
        Vector3 pos = transform.position;
        int i = 0;

        if (isUsingPre)
        {
            foreach (GlassName glassID in preGlasses)
            {
                pos = glassPos[i];
                Instantiate(this.glasses[(char)glassID], pos, Quaternion.identity, transform).GetComponent<Glass>().SetID(i);
                i++;

            }
        }
        else
        {
            foreach (int glassID in selectedCocktaillGlassObjectIndices)
            {
                pos = glassPos[i];
                Instantiate(this.glasses[glassID], pos, Quaternion.identity, transform).GetComponent<Glass>().SetID(i);
                i++;
            }
        }
    }

    private void AlcoholSet()
    {
        Vector3 pos = transform.position;
        int i = 0;
        if (isUsingPre)
        {
            foreach (DrinkName alcoholID in preDrinks)
            {
                pos = drinkPos[i++];
                Instantiate(this.alcohols[(char)alcoholID], pos, Quaternion.identity, transform);
            }
        }
        else
        {
            foreach (int alcoholID in selectedAlcoholObjectIndices)
            {
                pos = drinkPos[i++];
                Instantiate(this.alcohols[alcoholID], pos, Quaternion.identity, transform);
            }
            foreach (int alcoholID in selectedNonAlcoholObjectIndices)
            {
                pos += drinkPos[i++];
                Instantiate(this.alcohols[alcoholID+43], pos, Quaternion.identity, transform);

            }
        }
    }

    private void NonAlcoholicSet()
    {
        Vector3 pos = transform.position;
        int i = 0;
        if (isUsingPre)
        {
            foreach (DrinkName nAlcoholicID in preDrinks)
            {

                Instantiate(this.nonAlcoholics[(char)nAlcoholicID], pos, Quaternion.identity, transform);
                pos += drinkPos[i++];

            }
        }
        else
        {
            foreach (int nAlcoholicID in selectedNonAlcoholObjectIndices)
            {

                Instantiate(this.nonAlcoholics[nAlcoholicID], pos, Quaternion.identity, transform);
                pos += drinkPos[i++];

            }
        }
    }

    public void Submit()
    {
        Glass glass = coaster.PlacedGlass.GetComponent<Glass>();
        Debug.Log(glass.ToString());

        Debug.Log(FindCocktailByGlassInfo(glass));
        if(FindCocktailByGlassInfo(glass) == CocktailName.BlackRussian )
        {
            PlayerPrefs.SetInt("BlackRussiansuccese", 1);
            coaster.SubmitGlass();
        }
        if (FindCocktailByGlassInfo(glass) == CocktailName.PousseCafe)
        {
            PlayerPrefs.SetInt("PousseCafesuccese", 1);
            coaster.SubmitGlass();
        }
        if (FindCocktailByGlassInfo(glass) == CocktailName.B52)
        {
            PlayerPrefs.SetInt("B52succese", 1);
            coaster.SubmitGlass();
        }

        if(PlayerPrefs.HasKey("BlackRussiansuccese") && PlayerPrefs.HasKey("PousseCafesuccese") && PlayerPrefs.HasKey("B52succese"))
        {
            Debug.Log(PlayerPrefs.GetInt("BlackRussiansuccese") + PlayerPrefs.GetInt("PousseCafesuccese") + PlayerPrefs.GetInt("B52succese"));
            if(PlayerPrefs.GetInt("BlackRussiansuccese") == 1 && PlayerPrefs.GetInt("PousseCafesuccese") == 1&& PlayerPrefs.GetInt("B52succese") == 1)
            {
                SceneChange("SuccessScene");
            }
        }
    }

    public CocktailName FindCocktailByGlassInfo(Glass glass)
    {
        //List<Liquid> liquids = glass.GetLiquids();
        List<DrinkName> tag0 = glass.GetLiquidTags(0);
        List<DrinkName> tag1 = glass.GetLiquidTags(1);
        List<DrinkName> tag2 = glass.GetLiquidTags(2);

        if(glass.GlassName == GlassName.OldFashioned)
        {
            if(tag0 != null && tag1 == null && tag2 == null)
            {
                if(tag0.Count == 2)
                {
                    if (tag0[0] == DrinkName.Vodka && tag0[1] == DrinkName.Kahlua)
                    {
                        return CocktailName.BlackRussian;
                    }
                }
            }
        }
        else if(glass.GlassName == GlassName.Liqueur)
        {
            if (tag0 != null && tag1 != null && tag2 != null)
            {
                if (tag0.Count == 1 && tag1.Count == 1 && tag2.Count == 1)
                {
                    if (tag0[0] == DrinkName.GrenadineSyrup && tag1[0] == DrinkName.CremeDeMentheGreen && tag2[0] == DrinkName.BrandyCognac)
                    {
                        return CocktailName.PousseCafe;
                    }
                }
            }
        }
        else if(glass.GlassName == GlassName.SherryWine)
        {
            if (tag0 != null && tag1 != null && tag2 != null)
            {
                if (tag0.Count == 1 && tag1.Count == 1 && tag2.Count == 1)
                {
                    if (tag0[0] == DrinkName.Kahlua && tag1[0] == DrinkName.BaileysIrishCream && tag2[0] == DrinkName.GrandMarnier)
                    {
                        return CocktailName.B52;
                    }
                }
            }
        }

        Instantiate(ToastMsg, Vector2.zero,Quaternion.identity, ToastPoint).GetComponent<ToastText>().SetText("조주법이 맞지 않습니다.");

        return CocktailName.Null;
    }

    public bool IsRightCocktail(Glass glass)
    {
        return false;
    }
    public void SceneChange(string name)
    {
        SceneManager.LoadScene(name);
    }
}
