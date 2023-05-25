using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggleprefab : MonoBehaviour
{
    public Toggle toggle;
    public GameObject[] prefabs;
    // Start is called before the first frame update
    void Start()
    {
        toggle.onValueChanged.AddListener(OnToggleValueChanged);
    }
    private void OnToggleValueChanged(bool value)
    {
        // ����� üũ���� �ʾ��� �� ������ ��Ȱ��ȭ
        if (!value)
        {
            foreach (GameObject prefab in prefabs)
            {
                if (prefab != null)
                {
                    prefab.SetActive(false);
                }
            }
        }
        else
        {
            // ����� üũ�Ǿ��� �� �����յ� Ȱ��ȭ
            foreach (GameObject prefab in prefabs)
            {
                if (prefab != null)
                {
                    prefab.SetActive(true);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
