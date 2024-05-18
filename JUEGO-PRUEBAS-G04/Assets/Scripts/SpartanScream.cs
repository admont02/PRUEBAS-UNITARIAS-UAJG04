using UnityEngine;

public class SonidoPersonaje : MonoBehaviour
{
    public AudioClip sonido; // Arrastra aquí el archivo de sonido desde el Inspector de Unity
    public GameObject particles; // Arrastra aquí el archivo de sonido desde el Inspector de Unity
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null) // Si no hay AudioSource en el objeto, lo añadimos
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        audioSource.clip = sonido;
        InvokeRepeating("ReproducirSonido", 0, 5); // Inicia la repetición del sonido cada 2 segundos
    }
    private void Update()
    {

        if (audioSource.isPlaying)
            particles.SetActive(true);
        else
            particles.SetActive(false);
    }

    void ReproducirSonido()
    {
        audioSource.Play();
    }
}
