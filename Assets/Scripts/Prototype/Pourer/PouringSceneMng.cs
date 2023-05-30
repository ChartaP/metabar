using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TechniqueType
{
    Build,
    Float,
}

public enum VesselType
{
    //Cocktail,
    //Pilsner,
    OldFashioned,
    //ChampagneSaucer,
    //ChampagneFlute,
    //Collins,
    //Highball,
    //Sour,
    //WhiteWine,
    SherryWine,
    Liqueur,
    //MixingGlass,
    Jigger
}

public class PouringSceneMng : MonoBehaviour
{
    [SerializeField]
    private TechnicType technicType = TechnicType.Float;
    [SerializeField]
    private VesselType vesselType = VesselType.OldFashioned;

    [SerializeField]
    private Transform vesselPoint;
    [SerializeField]
    private Transform pourerPoint;

    [SerializeField]
    private GameObject pourerObject;
    [SerializeField]
    private GameObject vesselObject;

    [SerializeField]
    private GameObject[] vesselPrefabs;

    [SerializeField]
    private TMPro.TMP_Text drinkText;

    [SerializeField]
    private int timeLimit = 420;


    [SerializeField]
    private Timer timer = null;

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 500, 20), "This is some debug text");
    }

    void Load()
    {
        if (PlayerPrefs.HasKey("TimerCount"))
            timeLimit = PlayerPrefs.GetInt("TimerCount");

        int vesselid = PlayerPrefs.GetInt("CoasterGlassID");
        int loadVessel = PlayerPrefs.GetInt(vesselid+"VesselName");
        Debug.Log(loadVessel);
        vesselObject = Instantiate(vesselPrefabs[loadVessel], vesselPoint);
        vesselObject.GetComponent<Glass>().SetID(vesselid);
    }

    private void Save()
    {
        PlayerPrefs.SetInt("TimerCount", timeLimit);
    }

    protected void OnDestroy()
    {
        Save();
    }

    // Start is called before the first frame update
    void Awake()
    {
        Load();
    }

    private void Start()
    {

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
            if (timeLimit <= 0)
            {
                Debug.Log("�ð� ����");
            }
        }
    }
}
