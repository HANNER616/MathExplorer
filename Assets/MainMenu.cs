using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private static MainMenu instance;
    public GameObject MainMenuUI;
    void Start()
    {
        
    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);  // No destruir al cargar una nueva escena
        }
        else
        {
            Destroy(gameObject);  // Destruir la nueva instancia creada
        }
    }


    void Update()
    {
        
    }


    public void startGame()
    {
          SceneManager.LoadScene("Level1");
    }

    public void exitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
    }

    public void IrAlMenuPrincipal()
    {
        Debug.Log("Llendo al menu principal");
        SceneManager.LoadScene(0);
        MainMenuUI.SetActive(true);
        
    }

    public void seleccionNivel1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void seleccionNivel2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void seleccionNivel3()
    {
        SceneManager.LoadScene("Level3");
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }





}
