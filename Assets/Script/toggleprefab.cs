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
        // 토글이 체크되지 않았을 때 프리팹 비활성화
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
            // 토글이 체크되었을 때 프리팹들 활성화
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
