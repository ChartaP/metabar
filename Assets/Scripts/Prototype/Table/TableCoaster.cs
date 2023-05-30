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
    /// 占쌘쏙옙占쏙옙 占쏙옙占쏙옙 占쏙옙占쏙옙占쏙옙트占쏙옙 占쌍댐옙占쏙옙?
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

    public GameObject PlacedGlass
    {
        get { return this.placedGlass; }
    }

    /// <summary>
    /// 占쌘쏙옙占쏙옙 占쏙옙占쏙옙 占시띰옙占쏙옙占?占쌜띰옙占쏙옙 占쏙옙치
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
