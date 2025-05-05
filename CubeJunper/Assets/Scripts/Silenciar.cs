using UnityEngine;

public class Silenciar : MonoBehaviour
{
    private AudioListener audioListener;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioListener = GetComponent<AudioListener>();
        Invoke("SilenciarAudiosIndesejaveis", 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SilenciarAudiosIndesejaveis() 
    {
        Debug.Log("Silenciando audios indesejaveis");
        audioListener.gameObject.SetActive(false);
    }
}
