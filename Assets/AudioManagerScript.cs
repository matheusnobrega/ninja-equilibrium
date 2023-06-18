using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManagerScript : MonoBehaviour
{
    public AudioClip soundClip; // The audio clip you want to play

    private AudioSource audioSource;

    private void Awake()
    {
        // Make sure only one AudioManager instance persists across scenes
        if (FindObjectsOfType<AudioManagerScript>().Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }

        audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        // Attach the PlaySound method to the scene loaded event
        SceneManager.sceneLoaded += PlaySound;
    }

    private void OnDestroy()
    {
        // Remove the PlaySound method from the scene loaded event
        SceneManager.sceneLoaded -= PlaySound;
    }

    private void PlaySound(Scene scene, LoadSceneMode mode)
    {
        // Play the sound clip
        audioSource.PlayOneShot(soundClip);
    }
}
