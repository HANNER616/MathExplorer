
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioSource SFXsource;
    [SerializeField] AudioSource lectura;

    private static AudioManager audioMangager;
    public AudioClip music;
    public AudioClip AudioBotonPlay;
    public AudioClip AudioBotonNiveles;
    public AudioClip AudioBotonSalir;
    public AudioClip AudioBotonSilenciar;
    public AudioClip AudioBotonAtras;
    public AudioClip AudioBotonNivel1;
    public AudioClip AudioBotonNivel2;
    public AudioClip AudioBotonNivel3;
    public AudioClip AudioBotonInformacion;
    public AudioClip AudioBotonSiguienteNivel;

    private void Awake()
    {
        if (audioMangager == null)
        {
            audioMangager = this;
            DontDestroyOnLoad(gameObject);  
        }
        else
        {
            Destroy(gameObject);  
        }
    }
    void Start()
    {
        audioSource.clip = music;
        audioSource.Play();
    }

    public void leerBotonPlay() {
        lectura.PlayOneShot(AudioBotonPlay);
    }
    public void leerBotonNiveles()
    {
          lectura.PlayOneShot(AudioBotonNiveles);
    }
    public void leerBotonSalir()
    {
        lectura.PlayOneShot(AudioBotonSalir);
    }
    public void leerBotonSilenciar()
    {
        lectura.PlayOneShot(AudioBotonSilenciar);
    }
    public void leerBotonAtras()
    {
        lectura.PlayOneShot(AudioBotonAtras);
    }
    public void leerBotonNivel1()
    {
        lectura.PlayOneShot(AudioBotonNivel1);
    }
    public void leerBotonNivel2()
    {
        lectura.PlayOneShot(AudioBotonNivel2);
    }
    public void leerBotonNivel3()
    {
        lectura.PlayOneShot(AudioBotonNivel3);
    }

    public void leerBotonInformacion()
    {
        lectura.PlayOneShot(AudioBotonInformacion);
    }

    public void leerBotonSiguienteNivel()
    {
        lectura.PlayOneShot(AudioBotonSiguienteNivel);
    }
  








   

    public void stopMusic() { audioSource.Stop(); }
    public void playMusic() { audioSource.Play(); }

    public void Destroy()
    {
        Destroy(gameObject);
    }
}
