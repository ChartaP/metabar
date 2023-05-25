using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���־��� Glass�� ������Ʈ
/// </summary>
public class MakeGlass : Glass
{
    /// <summary>
    /// �÷��� �޼���
    /// </summary>
    /// <param name="drop"></param>
    public void Float(Drop drop)
    {
        if (Amount <= capacity)
        {
            if (liquidList.Count > 0)
            {
                if (liquidList[liquidList.Count -1].IsFloatable(drop.Name))
                {
                    //�÷��� ����
                    liquidList.Add(new Liquid(0.5f, drop.Name));
                }
                else
                {
                    //�÷��� �Ұ���
                    liquidList[liquidList.Count - 1].AddDrink(0.5f, drop.Name);
                }
            }
            else
            {
                liquidList.Add(new Liquid(0.5f, drop.Name));
            }
            SetDrinkSprite();
        }
        GameObject.Destroy(drop.gameObject);
    }
    /// <summary>
    /// ���� �޼���
    /// </summary>
    /// <param name="drop"></param>
    public void Build(Drop drop)
    {
        if (Amount <= capacity)
        {
            if(liquidList.Count > 0)
            {
                liquidList[liquidList.Count - 1].AddDrink(0.5f, drop.Name);
            }
            else
            {
                liquidList.Add(new Liquid(0.5f, drop.Name));
            }
            SetDrinkSprite();
        }
        GameObject.Destroy(drop.gameObject);
    }
}


