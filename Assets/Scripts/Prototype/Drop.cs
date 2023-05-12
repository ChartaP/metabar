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
    private DrinkName drinkName = DrinkName.Vodka;
    /// <summary>
    /// �ַ��� Ÿ��
    /// </summary>
    [SerializeField]
    private DrinkType type = DrinkType.Distilled;

    [SerializeField]
    private Color color = new Color(0, 0, 0);

    [SerializeField]
    private SpriteRenderer spriteRen = null;

    /// <summary>
    /// �ַ��� ����
    /// </summary>
    [SerializeField]
    private int proof = 0;

    /// <summary>
    /// �ַ��� ����
    /// </summary>
    [SerializeField]
    private int weight = 0;

    /// <summary>
    /// �ַ��� �̸� ��ȯ
    /// </summary>
    public DrinkName Name { get { return drinkName; } }
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
    public void Init(DrinkName drinkName)
    {
        this.drinkName = drinkName;
        this.type = WhatIsDrinkType(drinkName);
        this.color = GameResMng.Instance.GetDrinkColorByDrinkName(drinkName);
        spriteRen.color = this.color;
    }

    /// <summary>
    /// �ַ� �̸����� Ÿ�� �˻�
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public DrinkType WhatIsDrinkType(DrinkName drinkName)
    {
        if (drinkName >= DrinkName.Vodka && drinkName <= DrinkName.ScotchWhisky)
        {
            return DrinkType.Distilled;
        }
        else if (drinkName >= DrinkName.CremeDeMentheWhite && drinkName <= DrinkName.Galliano)
        {
            return DrinkType.Compounded;
        }
        else if (drinkName >= DrinkName.GamHongRo && drinkName <= DrinkName.SunwoonsanBokbunjaWine)
        {
            return DrinkType.Traditional;
        }
        else if (drinkName >= DrinkName.Chardonnay && drinkName <= DrinkName.SauvignonBlanc)
        {
            return DrinkType.Fermented;
        }
        else if (drinkName >= DrinkName.SweetAndSour && drinkName <= DrinkName.RaspberrSyrup)
        {
            return DrinkType.Syrup;
        }
        else if (drinkName == DrinkName.PinaColadaMix)
        {
            return DrinkType.Mix;
        }
        else if (drinkName >= DrinkName.LemonJuice && drinkName <= DrinkName.GingerAle)
        {
            return DrinkType.Juice;
        }
        else if (drinkName >= DrinkName.Salt && drinkName <= DrinkName.PowderedSugar)
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
    public int WhatIsProof(DrinkName drinkName)
    {
        return 0;
    }

    /// <summary>
    /// �ַ� �̸����� ���� �˻�
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public int WhatIsWeight(DrinkName drinkName)
    {
        return 0;
    }



}
