using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //fer yfir á næsta scene í build hierarchy 
    }

    public void QuitGame ()
    {
        Debug.Log("QUIT");  //Loggar QUIT
        Application.Quit(); //Lokar Applicationinu
    }
}
