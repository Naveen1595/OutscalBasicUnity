using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Script01 : MonoBehaviour
{
    public Button button01;
    public Button button02;
    public Button button03;

    public string scene01;
    public string scene02;
    public string scene03;
    public void Start()
    {
        button01.onClick.AddListener(onButtonClick01);
        button02.onClick.AddListener(onButtonClick02);
        button03.onClick.AddListener(onButtonClick03);
    }
    private void onButtonClick01()
    {
        Debug.Log("1 Clicked");
        SceneManager.LoadScene(scene01);
    }
    private void onButtonClick02()
    {
        Debug.Log("2 Clicked");
        SceneManager.LoadScene(scene02);
    }
    private void onButtonClick03()
    {
        Debug.Log("3 Clicked");
        SceneManager.LoadScene(scene03);
    }
}
