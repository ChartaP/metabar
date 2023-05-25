using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.Port;

/// <summary>
/// Table씬에서 사용할 Glass
/// </summary>
[RequireComponent(typeof(Glass))]
public class TableGlass : TableObject
{
    
    
    protected override void OnClick()
    {
        base.OnClick();

    }

    protected override void OnDrop()
    {
        base.OnDrop();
        if (IsInColObjByTag("Coaster"))
        {
            TableCoaster coaster = FindObjByTagFromColObj("Coaster").GetComponent<TableCoaster>();
            coaster.GlassPlace(gameObject);
            posOrgn = coaster.GlassPos;
        }
    }
}
