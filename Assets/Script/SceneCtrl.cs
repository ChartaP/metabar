using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene("ProtoCounter2"); //���� �ϴ� ������ �̵�
     
    }
    public void ChangeScene2()
    {
        SceneManager.LoadScene(3); // ������� ������ ������ �̵�
    }
    public void ChangeScene3()
    {
        SceneManager.LoadScene(1); //������� 3��Ĭ���� �� ������ ������ �̵�
    }
    public void ChangeScene4()
    {
        SceneManager.LoadScene("�������ΰ��¾�");
    }
    public void ChangeScene5()
    {
        SceneManager.LoadScene(7); //������� 3�� Ĭ���� ������ ������ �̵�
    }
}
