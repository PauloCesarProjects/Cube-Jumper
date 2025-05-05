using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControles : MonoBehaviour
{
    public bool isGround;
    public float jumpForce = 5f; 
 
    private Rigidbody2D rb;
    private AudioSource pulo;
    private BoxCollider2D box;

    public GameObject TextGameOver;
    public GameObject TextScoreGameOver;


    public static float TempoGiro = 0.05f;
    public static bool isGameOver = false;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        box = GetComponent<BoxCollider2D>();
 

        InvokeRepeating("Rodar", TempoGiro, TempoGiro);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround && isGameOver == false)
        {
            pulo = GetComponent<AudioSource>();
            pulo.Play();
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);

            isGround = false;
        }
        else if (Input.touchCount == 1 && isGround && isGameOver == false)
        {
            pulo = GetComponent<AudioSource>();
            pulo.Play();
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);

            isGround = false;
        }
        Debug.Log(isGround);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("chao"))
        {
            isGround = true;
            Debug.Log("isGround: " + isGround);
        }
        else if (collision.gameObject.CompareTag("Obstaculo"))
        {

            Destroy(gameObject);
            TextGameOver.gameObject.SetActive(true);
            TextScoreGameOver.gameObject.SetActive(true);
            TextScoreGameOver.GetComponent<Text>().text = "Pontos: " + GameManager.pontos.ToString();
            isGameOver = true;

        }
        else if (collision.gameObject.CompareTag("buraco"))
        {

            box.isTrigger = true;
            TextGameOver.gameObject.SetActive(true);
            TextScoreGameOver.gameObject.SetActive(true);
            TextScoreGameOver.GetComponent<Text>().text = "Pontos: " + GameManager.pontos.ToString();
            isGameOver = true;

        }
    }
    public void Rodar()
    {
        transform.Rotate(new Vector3(0, 0, -10));
    }

}


//Adionar aba de configurações
//Arrumar o son de morte
//Arrumar o som de clique
//Adicionar aba de skills
//Adicionar aba de Skins
//Adicionar arte