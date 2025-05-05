using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControler : MonoBehaviour
{


    private AudioSource AudioSource2;


    void Start()
    {

        AudioSource2 = GetComponent<AudioSource>();
        AudioSource2.Play();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 1)
        { 
        
            SceneManager.LoadScene(2);
        }

    }
}
