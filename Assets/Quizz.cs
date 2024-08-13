using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;
using System;

public class Quizz : MonoBehaviour
{
    public TextMeshProUGUI tituloText;
    public Image preguntaImage;
    public TextMeshProUGUI preguntaText;
    public Button[] answerButtons;

    public TextAsset jsonFile;
    private List<Pregunta> preguntasList;
    private Pregunta preguntaActual;



    [System.Serializable]
    public class Pregunta
    {
        public int id;
        public string titulo;
        public string imagen;
        public string pregunta;
        public List<string> respuestas;
        public int respuestaCorrecta;
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
        StartCoroutine(CargarImagen(preguntaActual.imagen));
        for (int i = 0; i < preguntaActual.respuestas.Count; i++)
        {
            answerButtons[i].GetComponentInChildren<TextMeshProUGUI>().text = preguntaActual.respuestas[i];
        }
    }
    }

 
    

    IEnumerator CargarImagen(string imagePath)
    {
    Texture2D texture = Resources.Load<Texture2D>("nombre_de_la_imagen"); // Sin extensión
}

}


