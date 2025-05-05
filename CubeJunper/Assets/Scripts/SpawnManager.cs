using UnityEngine;
using UnityEngine.Rendering;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    public GameObject[] prefabs;

    private float tempoDeSpaw = 2;
    private int obstaculoAtual;

    void Start()
    {
        InvokeRepeating("Spawnar", 0.5f, tempoDeSpaw);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Spawnar()
    {
        int ItemAleatorio = Random.Range(0, 4);
        if (ItemAleatorio == 0)
        {
            Vector3 posicao = new Vector3(20, -2.79f, 0);
            Instantiate(prefabs[0], posicao, Quaternion.identity);
        }
        else if (ItemAleatorio == 1)
        {
            Vector3 posicao = new Vector3(20, -3.30f, 0);
            Instantiate(prefabs[1], posicao, Quaternion.identity);
        }
        else if (ItemAleatorio == 2)
        {
            Vector3 posicao = new Vector3(20, -4.33f, 0);
            Instantiate(prefabs[2], posicao, Quaternion.identity);
        }
        else if (ItemAleatorio == 3)
        {
            if(obstaculoAtual != 3) 
            {
                Vector3 posicao = new Vector3(20, -1.5f, 0);
                Instantiate(prefabs[3], posicao, Quaternion.identity);
                obstaculoAtual = 3;
            }
            else
            {
                obstaculoAtual = 0;
                Vector3 posicao = new Vector3(20, -4.33f, 0);
                Instantiate(prefabs[2], posicao, Quaternion.identity);
            }
            
        }
    }
    
}
