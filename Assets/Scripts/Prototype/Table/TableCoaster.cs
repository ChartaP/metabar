using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableCoaster : MonoBehaviour
{
    [SerializeField]
    private Vector3 glassPos = Vector3.zero;

    [SerializeField]
    private GameObject placedGlass = null;

    /// <summary>
    /// 코스터 위에 오브젝트가 있는지?
    /// </summary>
    public bool IsPlaced
    {
        get
        {
            return placedGlass != null;
        }
    }

    public void GlassPlace(GameObject placedGlass)
    {
        this.placedGlass = placedGlass;
    }

    /// <summary>
    /// 코스터 위에 올라오는 글라스의 위치
    /// </summary>
    public Vector3 GlassPos
    {
        get { return glassPos; }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected void OnDestroy()
    {
        Save();
    }

    private void Save()
    {
        if(IsPlaced)
        {
            PlayerPrefs.SetInt("CoasterGlassID", placedGlass.GetComponent<Glass>().getID());
            Debug.Log(placedGlass.GetComponent<Glass>().getID());
        }
    }

}
