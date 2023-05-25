using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ToastText : MonoBehaviour
{
    [SerializeField]
    private float waitTime = 3f;
    [SerializeField]
    private TMPro.TMP_Text tmp = null;    

    public void SetText(string text)
    {
        tmp.text = text;

    }
    // Start is called before the first frame update
    void Start()
    {
        if(tmp == null)
        {
            tmp = transform.GetComponent<TMPro.TextMeshPro>();
        }
        StartCoroutine(Wait());

    }

    private IEnumerator Wait()
    {
        float time = 0f;
        while(true)
        {
            time += Time.deltaTime;
            if(time > waitTime)
            {
                StartCoroutine(Gone());
                yield break;
            }
            yield return null;
        }
        yield return null;
    }

    private IEnumerator Gone()
    {
        Color aColor = tmp.color;
        aColor.a = 0f;

        while(true)
        {
            transform.Translate(Vector2.up * 60f * Time.deltaTime);
            tmp.color = Color.Lerp(tmp.color, aColor, 2.0f * Time.deltaTime);
            if(tmp.color.a <= 0.01f)
            {
                Destroy(gameObject);
                yield break;
            }
            yield return null;
        }
        yield return null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
