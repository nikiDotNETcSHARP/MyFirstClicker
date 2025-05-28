using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Music : MonoBehaviour
{
    public AudioSource _sourceGameplayMusic;
    public AudioClip _clipGameplay;
    public AudioClip _clipGameOver;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);

        if (_sourceGameplayMusic == null)
            _sourceGameplayMusic = GetComponent<AudioSource>();
    }

    private void Start()
    {
        StartCoroutine(UpdateMusic());

        _sourceGameplayMusic.clip = _clipGameplay;
        _sourceGameplayMusic.Play();
    }

    IEnumerator UpdateMusic()
    {
        while (true)
        {
            string currentSceneName = SceneManager.GetActiveScene().name;

            if (currentSceneName.Equals("MilitaryGameOver"))
            {
                _sourceGameplayMusic.Stop();
                _sourceGameplayMusic.PlayOneShot(_clipGameOver);
                break;
            }

            yield return new WaitForSeconds(1f);
        }
    }
}
