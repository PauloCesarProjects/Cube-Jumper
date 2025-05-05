using UnityEngine;

public class ControlaDorSonoro : MonoBehaviour
{

    private AudioListener audioListener;    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioListener = GetComponent<AudioListener>();
        audioListener.enabled = false;
        Invoke("VoutandoSom", 0.2f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void VoutandoSom()
    {
        audioListener.enabled = true;
    }
}
