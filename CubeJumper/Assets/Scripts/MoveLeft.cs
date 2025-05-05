using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public static float positionx = -0.8f;
    Vector3 posicao2 = new Vector3(positionx, 0, 0);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        positionx = -0.8f;
    }

    // Update is called once per frame
    void Update()
    {
        Dificuldade();
        Vector2 posicao = transform.position;
        transform.Translate(posicao2 * Time.deltaTime * 10);
        if(posicao.x <= -15)
        {
            Destroy(gameObject);
        }
    }
    public void Dificuldade()
    {
        float points = GameManager.pontos;
        if (points >= 100 && points < 200)
        {
            positionx = -1f;
            Debug.Log("Dificuldade: " + positionx);
            PlayerControles.TempoGiro = 0.04f;
        }
        else if (points >= 200 && points < 300)
        {
            positionx = -1.2f;
            Debug.Log("Dificuldade: " + positionx);
            PlayerControles.TempoGiro = 0.03f;
        }
        else if (points >= 300 && points < 400)
        {
            positionx = -1.4f;
            Debug.Log("Dificuldade: " + positionx);
            PlayerControles.TempoGiro = 0.02f;
        }
        else if (points >= 400 && points < 500)
        {
            positionx = -1.6f;
            Debug.Log("Dificuldade: " + positionx);
            PlayerControles.TempoGiro = 0.01f;
        }
        else if (points >= 500)
        {
            positionx = 1.8f;
            Debug.Log("Dificuldade: " + positionx);
            PlayerControles.TempoGiro = 0.005f;
        }

    }
}
