using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleVieja : MonoBehaviour
{
    private const string interior = "Interior";
    public void Boton_menu()
    {
        SceneManager.LoadScene(interior);
    }
}
