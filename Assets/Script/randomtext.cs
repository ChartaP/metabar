
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class randomtext : MonoBehaviour
{
    string[] strings = { "����� ��Ƽ��", "�ױ׷δ�", "�̰��� ����", "�� ����", "����ư","����Ʈ ����","�õ� �м���",
        "����","����Ű����","�귣�� �˷����","���̵�ī","��Ϲ�","Ǫ�� ī�� ���κ���","B-52","������Ÿ","��ų�� ��������"
         ,"�� ��","�׷���ȣ��","�������� Ĭ����","Ű��","�� ���þ�","�ú긮��","���� ��Ƽ��","�� ���Ϸ��� ���̽� Ƽ",
        "�ڽ�������ź","���� ��","����Ű��","��ī��","��� ���극","����Ÿ��","�ǳ� �ݶ��","��� �Ͽ��̾�","����","����"
            ,"ǲ���","�ݻ�","��â","������ ���� ������","���� ����Ʈ ��ġ" };
    public Text name1, name2, name3;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < strings.Length; i++)
        {
            string name;
            do
            {
                name = strings[Random.Range(0, strings.Length)];
            } while (name == name1.text || name == name2.text || name == name3.text);
            switch (i)
            {
                case 0:
                    name1.text = "A. "+name;
                    
                    break;
                case 1:
                    name2.text = "B. "+name;
                    
                    break;
                case 2:
                    name3.text = "C. "+name;
                    
                    break;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
