using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text TextPontos;
    public GameObject BotaoReiniciar;   
    public GameObject BotaoSair;



    private AudioSource audioSource;

    public static int pontos;
    void Start()
    {
        InvokeRepeating("AdicionarPontos", 0.3f, 0.3f);
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
        pontos = 0;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AdicionarPontos()
    {
        if (!PlayerControles.isGameOver)
        {
            if (TextPontos == null)
            {
                Debug.Log("TextPontos is null");
            }
            pontos += 1;
            TextPontos.text = "Pontos: " + GameManager.pontos.ToString();
        }
        else
        {
            audioSource.Stop();
            TextPontos.text = "";
            MoveLeft.positionx = -0.8f;
            BotaoReiniciar.gameObject.SetActive(true);
            BotaoSair.gameObject.SetActive(true);
        }
    }




}
