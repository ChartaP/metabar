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
            //???´‚à•Ôß????πÎß∂?????é°???´‚à•???ÍπÖÌäÇ????´‚à•Ôß????πÎß∂?????é° ???´‚à•Ôß????πÎß∂?

        }
        else
        {
            //???´‚à•Ôß????πÎß∂?????é°???´‚à•???ÍπÖÌäÇ????´‚à•Ôß????πÎß∂?????é° ???´‚à•???Ê∫êÎÖæ???
            //PlayerPref???´‚à•Ôß????πÎß∂?????é° ???´‚à•Ôß????πÎß∂?????é°???´‚à•Ôß?????´‚à•Ôß????πÎß∂?????é°???´‚à•Ôß????πÎß∂?????é°
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
                Debug.Log("???´‚à•Ôß???Í±?????´‚à•Ôß????πÎß∂?????é°");
            }
        }
    }

    private void ToolSet()
    {
        Vector3 pos = transform.position;
        int i = 0;
        foreach (ToolName toolID in preTools) {
            pos = toolPos[i++];
            Instantiate(this.tools[(char)toolID], pos, Quaternion.identity, transform);

        }
    }

    private void GlassSet()
    {
        Vector3 pos = transform.position;
        int i = 0;
        foreach (GlassName glassID in preGlasses)
        {
            pos = glassPos[i];
            Instantiate(this.glasses[(char)glassID], pos, Quaternion.identity, transform).GetComponent<Glass>().SetID(i);
            i++;

        }
    }

    private void AlcoholSet()
    {
        Vector3 pos = transform.position;
        int i = 0;
        foreach (DrinkName alcoholID in preDrinks)
        {
            pos = drinkPos[i++];
            Instantiate(this.alcohols[(char)alcoholID], pos, Quaternion.identity, transform);
            

        }
    }

    private void NonAlcoholicSet()
    {
        Vector3 pos = transform.position;
        int i = 0;
        foreach (DrinkName nAlcoholicID in preDrinks)
        {

            Instantiate(this.nonAlcoholics[(char)nAlcoholicID], pos, Quaternion.identity, transform);
            pos += drinkPos[i++];

        }
    }

    public void Submit()
    {
        Glass glass = coaster.PlacedGlass.GetComponent<Glass>();
        Debug.Log(glass.ToString());

        Debug.Log(FindCocktailByGlassInfo(glass));
        if(FindCocktailByGlassInfo(glass) == CocktailName.BlackRussian )
        {
            PlayerPrefs.SetInt("succese1",1);
        }
        if (FindCocktailByGlassInfo(glass) == CocktailName.PousseCafe)
        {
            PlayerPrefs.SetInt("succese2", 1);
        }
        if (FindCocktailByGlassInfo(glass) == CocktailName.B52)
        {
            PlayerPrefs.SetInt("succese3", 1);
        }

        if(PlayerPrefs.HasKey("succese1")&& PlayerPrefs.HasKey("succese2")&& PlayerPrefs.HasKey("succese2"))
        {
            if(PlayerPrefs.GetInt("succese1") == 1 && PlayerPrefs.GetInt("succese2") == 1&& PlayerPrefs.GetInt("succese3") == 1)
            {
                SceneChange();
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

        Instantiate(ToastMsg, Vector2.zero,Quaternion.identity, ToastPoint).GetComponent<ToastText>().SetText("??Á≠åÏï∏?ΩÔß£? ????¥Í∂ò????àÌé≤.");

        return CocktailName.Null;
    }

    public bool IsRightCocktail(Glass glass)
    {
        return false;
    }
    public void SceneChange()
    {
        SceneManager.LoadScene("SuccessScene");
    }
}
