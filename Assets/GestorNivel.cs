using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GestorNivel : MonoBehaviour
{
    public GameObject audioSource;
    public GameObject MainMenu;
    void Start()
    {
        
    }

 
    
    void Update()
    {
        
    }

    public void pasarNivel()
    {
        string currentScene = SceneManager.GetActiveScene().name;
        if(currentScene == "Level1")
        {
            SceneManager.LoadScene("Level2");
        }
        else if (currentScene == "Level2")
        {
            SceneManager.LoadScene("Level3");
        }
        else if (currentScene == "Level3")
        {
            
            SceneManager.LoadScene("MenuPrincipal");
            MainMenu.SetActive(true);
        }
    }
}
