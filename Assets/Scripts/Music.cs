using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioSource _audioSource;
    public AudioClip _audioClip;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        _audioSource.clip = _audioClip;
        _audioSource.Play();
    }
}
