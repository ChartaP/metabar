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
    /// �ڽ��� ���� ������Ʈ�� �ִ���?
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
    /// �ڽ��� ���� �ö���� �۶��� ��ġ
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
