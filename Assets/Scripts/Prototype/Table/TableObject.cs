using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TableObjectType
{
    Ice,
    Jigger,
    Barspoon,
    Tool,
    Glass,
    Drink,
    Shaker
}

public class TableObject : ProtoClickObject
{
    [SerializeField]
    protected Vector2 firstPoint = Vector2.zero;
    [SerializeField]
    protected Vector2 lastPoint = Vector2.zero;
    [SerializeField]
    private float dragDistance = 1;

    [SerializeField]
    protected List<GameObject> colObjects = new List<GameObject>();

    protected IEnumerator myDrag;

    [SerializeField]
    private TableObjectType type;

    public TableObjectType Type { get { return type; } }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void OnClick()
    {
        base.OnClick();
        //Debug.Log("On Click");
    }

    protected virtual void OnDrop()
    {
        //Debug.Log("On Drop");
    }

    protected virtual void OnColEnter()
    {

    }

    protected override void OnEnter()
    {
        base.OnEnter();
        
    }

    protected override void OnExit()
    {
        base.OnExit();
    }



    override protected IEnumerator WaitClick()
    {
        while (true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                myDrag = Dragging();
                StartCoroutine(myDrag);
                //Debug.Log("WaitClick Stop");
                StopCoroutine(myWait);
                yield break;
            }
            yield return null;
        }
    }

    protected IEnumerator Dragging()
    {
        Vector3 posOrgn = transform.localPosition;
        firstPoint = GetMousePosition();

        while (true)
        {
            lastPoint = GetMousePosition();
            transform.localPosition = posOrgn + (Vector3)(lastPoint - firstPoint);
            //Debug.Log("Is Dragging");
            if (Input.GetMouseButtonUp(0))
            {
                float dis = Vector2.Distance(firstPoint, lastPoint);
                if (dis > dragDistance)
                {
                    OnDrop();  
                }
                else
                {
                    OnClick();
                }
                //Debug.Log("Dragging Stop");
                transform.localPosition = posOrgn;
                StopCoroutine(myDrag);
                yield break;
            }
            yield return null;
        }
    }

    protected void OnCollisionEnter2D(Collision2D collision)
    {
        OnColEnter();
        colObjects.Add(collision.gameObject);
    }

    protected void OnCollisionStay2D(Collision2D collision)
    {
        
    }

    protected void OnCollisionExit2D(Collision2D collision)
    {
        colObjects.Remove(collision.gameObject);
    }

    public bool IsInColObjByTag(string tag)
    {
        foreach(GameObject obj in colObjects)
        {
            if(obj.tag == tag)
            {
                return true;
            }
        }
        return false;
    }

    public GameObject FindObjByTagFromColObj(string tag)
    {

        foreach (GameObject obj in colObjects)
        {
            if (obj.tag == tag)
            {
                return obj ;
            }
        }
        return null;
    }
}
