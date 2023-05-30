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
    /// ? ìŒ˜?™ì˜™? ì™??? ì™?™å ?™ì˜™ ? ì™?™å ?™ì˜™? ì™?™íŠ¸? ì™??? ìŒ?ì˜™? ì™??
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
    /// ? ìŒ˜?™ì˜™? ì™??? ì™?™å ?™ì˜™ ? ì‹œ?°ì˜™? ì™?™å ?? ìŒœ?°ì˜™? ì™??? ì™?™ì¹˜
    /// </summary>
    public Vector3 GlassPos
    {
        get { return glassPos; }
    }

    public void SubmitGlass()
    {
        Destroy(placedGlass);
        placedGlass = null;
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
