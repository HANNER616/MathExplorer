
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioSource SFXsource;

    public AudioClip music;


    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        audioSource.clip = music;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void stopMusic() { audioSource.Stop(); }
    public void playMusic() { audioSource.Play(); }

    public void Destroy()
    {
        Destroy(gameObject);
    }
}
