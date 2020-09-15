using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Script02 : MonoBehaviour
{
    public Button button;
    public string backScene;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(onButtonClick);
    }

    private void onButtonClick()
    {
        Debug.Log("Back Clicked");
        SceneManager.LoadScene(backScene);
    }
}
