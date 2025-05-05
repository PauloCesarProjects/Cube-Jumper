using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class EstrelasControles : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.x < -15)
        {
            transform.position = new Vector3(10, Random.Range(-3, 4), 0);
        }
        else
        {
            transform.Translate(Vector3.left * Time.deltaTime * 0.2f);
        }
    }
}
