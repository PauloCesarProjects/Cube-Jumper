
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReestartButon : MonoBehaviour
{
    public static bool clicadoR = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        clicadoR = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Check if the touch phase is "Ended" and if it hits this object
            if (touch.phase == TouchPhase.Ended)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit) && hit.transform == transform)
                {
                    clicadoR = true;
 
                    GameManager.pontos = 0;
                    PlayerControles.isGameOver = false;
                    SceneManager.LoadScene("SampleScene");
                }
            }
        }
    }
    private void OnMouseUp()
    {
       GameManager.pontos = 0;
        PlayerControles.isGameOver = false;
        SceneManager.LoadScene("SampleScene");
    }
}
