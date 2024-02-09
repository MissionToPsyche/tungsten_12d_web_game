using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("----------AudioSource---------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("----------AudioClip---------")]
    public AudioClip background;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }
    
}
