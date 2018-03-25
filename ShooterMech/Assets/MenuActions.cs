using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuActions : MonoBehaviour {

      public void StartMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
