using UnityEngine;

public class MusicaDerrotaManager : MonoBehaviour
{
    private AudioSource audioSource;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!PlayerControles.isGameOver)
        {
            audioSource.Play();
        }
    }
}
