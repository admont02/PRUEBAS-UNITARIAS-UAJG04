using UnityEngine;

public class SonidoPersonaje : MonoBehaviour
{
    public AudioClip sonido; // Arrastra aqu� el archivo de sonido desde el Inspector de Unity
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null) // Si no hay AudioSource en el objeto, lo a�adimos
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        audioSource.clip = sonido;
        InvokeRepeating("ReproducirSonido", 0, 5); // Inicia la repetici�n del sonido cada 2 segundos
    }

    void ReproducirSonido()
    {
        audioSource.Play();
    }
}
