using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuInicio :MonoBehaviour
{
    private const string Basica = "Basica";

    public void Boton_inicio()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(Basica);
    }
}
