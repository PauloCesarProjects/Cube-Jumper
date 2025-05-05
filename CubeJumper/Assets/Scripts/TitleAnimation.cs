using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleAnimation : MonoBehaviour
{
    public Text TextoTitulo;
    public Text TextoPress;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("TrocarDeCena", 4f);
    }

    public void TrocarDeCena()
    {
        SceneManager.LoadScene(1);     
    }
}
