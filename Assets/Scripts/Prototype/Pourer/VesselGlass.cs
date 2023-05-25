using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ��� ��� �۷��� ���� ������Ʈ
/// </summary>
[RequireComponent(typeof(Glass))]
public class VesselGlass : Vessel
{
    [SerializeField]
    private Glass glass;


    /// <summary>
    /// �÷��� �޼���
    /// </summary>
    /// <param name="drop"></param>
    public void Float(Drop drop)
    {
        if (glass.Amount <= glass.MaxCapacity)
        {
            if (glass.HasLiquid)
            {
                if (glass.IsFloatable(drop.Name))
                {
                    //�÷��� ����
                    glass.FloatingLiquid(0.5f, drop.Name);
                }
                else
                {
                    //�÷��� �Ұ���
                    glass.MixingLiquid(0.5f,drop.Name);
                }
            }
            else
            {
                glass.FloatingLiquid(0.5f, drop.Name);
            }
            glass.SetDrinkSprite();
        }
        GameObject.Destroy(drop.gameObject);
    }
    /// <summary>
    /// ���� �޼���
    /// </summary>
    /// <param name="drop"></param>
    public void Build(Drop drop)
    {
        if (glass.Amount <= glass.MaxCapacity)
        {
            if (glass.HasLiquid)
            {
                glass.MixingLiquid(0.5f, drop.Name);
            }
            else
            {
                glass.FloatingLiquid(0.5f, drop.Name);
            }
            glass.SetDrinkSprite();
        }
        GameObject.Destroy(drop.gameObject);
    }
}


