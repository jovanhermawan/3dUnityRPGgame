using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScreenLoader : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    // Update is called once per frame
    public void QuitTheGame()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }
}
