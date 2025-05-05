using UnityEngine;

public class EstrelaCadente : MonoBehaviour
{
    private int ProbabilidadeDeAparecer = 1;
    private int VaiAparecer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("Sorte", 35f);
        if (VaiAparecer == ProbabilidadeDeAparecer)
        {
            transform.Translate(Vector3.left * Time.deltaTime * 30f);
        }

    }
    private void Sorte()
    {
        VaiAparecer = Random.Range(0, 75);
    }
}
