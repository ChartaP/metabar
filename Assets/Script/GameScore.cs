using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//���ھ� ��ü
public class GameScore : MonoBehaviour
{

    public static int value; // �����ϴ� ���ھ� ��

    public int startCounter = 0; // ���ھ� �ʱⰪ�� 0���� ����
    // Start is called before the first frame update
    void Start()
    {
        value = startCounter; //ī���� �ʱⰪ�� ����
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
