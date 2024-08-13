using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;
using System;
using System.Net;


public class Quizz : MonoBehaviour
{
    //PanelPreguntaUI
    public TextMeshProUGUI tituloText;
    public Image preguntaImage;
    public TextMeshProUGUI preguntaText;
    public Button[] answerButtons;

    //PanelExplicacion
    public TextMeshProUGUI explicacionPanelIncorrecto;
    public TextMeshProUGUI explicacionPanelCorrecto;


    //Json
    public TextAsset jsonFile;
    private Pregunta preguntaActual;

    //Paneles
    public GameObject panelPregunta;
    public GameObject panelRespuestaIncorrecta;
    public GameObject panelRespuestaCorrecta;

    private static Quizz instance;

    [System.Serializable]
    public class Pregunta
    {
        public int id;
        public string titulo;
        public string imagen;
        public string pregunta;
        public List<string> respuestas;
        public int respuestaCorrecta;
        public List<string> explicacion;
    }

    [Serializable]
    public class Preguntas
    {
        public Pregunta[] preguntas;
    }

    public Preguntas preguntas = new Preguntas();




    void Start()
    {
       
        CargarPreguntas();
        MostrarPreguntaAleatoria();



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

    public void CargarPreguntas()
    {
        preguntas = JsonUtility.FromJson<Preguntas>(jsonFile.text);
    }

    public void MostrarPreguntaAleatoria()
    {
        int randomIndex = UnityEngine.Random.Range(0, preguntas.preguntas.Length);
        preguntaActual = preguntas.preguntas[randomIndex];
        tituloText.text = preguntaActual.titulo;
        preguntaText.text = preguntaActual.pregunta;

        //Cargar sprite de una ruta relativa
        preguntaImage.sprite = Resources.Load<Sprite>(preguntaActual.imagen);

        for (int i = 0; i < preguntaActual.respuestas.Count; i++)
        {
            answerButtons[i].GetComponentInChildren<TextMeshProUGUI>().text = preguntaActual.respuestas[i];
        }

    }

    
    public void ComprobarRespuesta(int respuestaIndex)
    {
        if (preguntaActual.respuestaCorrecta == respuestaIndex)
        {
            explicacionPanelCorrecto.text = preguntaActual.explicacion[respuestaIndex];
            panelPregunta.SetActive(false);
            panelRespuestaCorrecta.SetActive(true);
            Debug.Log("Respuesta Correcta");
        }
        else
        {
            
            panelPregunta.SetActive(false);
            panelRespuestaIncorrecta.SetActive(true);
            explicacionPanelIncorrecto.text = preguntaActual.explicacion[respuestaIndex];
            Debug.Log("Respuesta Incorrecta");
        }

        
    }

    public void setActive()
    {
          panelPregunta.SetActive(true);
    }








}











