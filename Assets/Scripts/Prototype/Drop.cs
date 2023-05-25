using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �ַ� �̸� ������
/// </summary>
public enum DrinkName
{
    Vodka,
    Gin,
    BrandyCognac,
    CALVADOS,
    FineCALVADOS,
    Rum,
    BacardiRum,
    BourbonWhisky,
    ScotchWhisky,
    CremeDeMentheWhite,
    CremeDeMentheGreen,
    DryVermouth,
    SweetVermouth,
    Kahlua,
    CremeDeCacaoBrown,
    CremeDeCacaoWhite,
    TripleSec,
    Drambuie,
    MALIBU,
    BaileysIrishCream,
    GrandMarnier,
    CremeDeBanana,
    Midori,
    Melon,
    ApplePucker,
    Campari,
    Cointreau,
    ApricotFlavoredBrandy,
    BenedictineDOM,
    BlueCuracao,
    CremeDeCassis,
    AngosturaBitters,
    CherryFlavoredBrandy,
    SloeGin,
    Galliano,
    GamHongRo,
    AndongSoju,
    JindoHongju,
    GeumsanInsamju,
    SunwoonsanBokbunjaWine,
    Chardonnay,
    SauvignonBlanc,
    SweetAndSour,
    GrenadineSyrup,
    RaspberrSyrup,
    PinaColadaMix,
    LemonJuice,
    OrangeJuice,
    GrapefruitJuice,
    WhiteGrapeJuice,
    CranberryJuice,
    LightMilk,
    PineappleJuice,
    LimeJuice,
    SodaWater,
    Cola,
    Sprite,
    GingerAle,
    Salt,
    PowderedSugar


}
/// <summary>
/// �ַ� Ÿ�� ������
/// ������,ȥ����,������,������,�ֽ�,�÷�,�ͽ�,���̷�
/// </summary>
public enum DrinkType
{
    Distilled,
    Compounded,
    Traditional,
    Fermented,
    Juice,
    Syrup,
    Mix,
    Seasoning
}

/// <summary>
/// ����� ������Ʈ
/// </summary>
public class Drop : MonoBehaviour
{
    /// <summary>
    /// �ַ��� �̸�
    /// </summary>
    [SerializeField]
    DrinkName name = DrinkName.Vodka;
    /// <summary>
    /// �ַ��� Ÿ��
    /// </summary>
    [SerializeField]
    DrinkType type = DrinkType.Distilled;

    [SerializeField]
    Color color = new Color(0, 0, 0);

    [SerializeField]
    SpriteRenderer spriteRen = null;

    /// <summary>
    /// �ַ��� ����
    /// </summary>
    [SerializeField]
    int proof = 0;

    /// <summary>
    /// �ַ��� ����
    /// </summary>
    [SerializeField]
    int weight = 0;

    /// <summary>
    /// �ַ��� �̸� ��ȯ
    /// </summary>
    public DrinkName Name { get { return name; } }
    /// <summary>
    /// �ַ��� Ÿ�� ��ȯ
    /// </summary>
    public DrinkType Type { get { return type; } }
    /// <summary>
    /// �ַ��� ���� ��ȯ
    /// </summary>
    public int Proof
    {
        get { return proof; }
    }
    /// <summary>
    /// �ַ��� ���� ��ȯ
    /// </summary>
    public int Weight { get { return weight; } }

    /// <summary>
    /// ����� �ʵ� �ʱ�ȭ �޼���
    /// </summary>
    /// <param name="name">������� �ַ� �̸�</param>
    public void Init(DrinkName name)
    {
        this.name = name;
        this.type = WhatIsDrinkType(name);
        this.color = GameResMng.Instance.GetDrinkColorByDrinkName(name);
        spriteRen.color = this.color;
    }

    /// <summary>
    /// �ַ� �̸����� Ÿ�� �˻�
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public DrinkType WhatIsDrinkType(DrinkName name)
    {
        if (name >= DrinkName.Vodka && name <= DrinkName.ScotchWhisky)
        {
            return DrinkType.Distilled;
        }
        else if (name >= DrinkName.CremeDeMentheWhite && name <= DrinkName.Galliano)
        {
            return DrinkType.Compounded;
        }
        else if (name >= DrinkName.GamHongRo && name <= DrinkName.SunwoonsanBokbunjaWine)
        {
            return DrinkType.Traditional;
        }
        else if (name >= DrinkName.Chardonnay && name <= DrinkName.SauvignonBlanc)
        {
            return DrinkType.Fermented;
        }
        else if (name >= DrinkName.SweetAndSour && name <= DrinkName.RaspberrSyrup)
        {
            return DrinkType.Syrup;
        }
        else if (name == DrinkName.PinaColadaMix)
        {
            return DrinkType.Mix;
        }
        else if (name >= DrinkName.LemonJuice && name <= DrinkName.GingerAle)
        {
            return DrinkType.Juice;
        }
        else if (name >= DrinkName.Salt && name <= DrinkName.PowderedSugar)
        {
            return DrinkType.Seasoning;
        }
        return DrinkType.Distilled;
    }

    /// <summary>
    /// �ַ� �̸����� ���� �˻�
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public int WhatIsProof(DrinkName name)
    {
        return 0;
    }

    /// <summary>
    /// �ַ� �̸����� ���� �˻�
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public int WhatIsWeight(DrinkName name)
    {
        return 0;
    }



}
