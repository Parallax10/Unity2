using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarNivel : MonoBehaviour
{
    // Constantes para nombres de escenas
    private const string ESCENA_ESPONJA = "EsponjaPiedra";
    private const string ESCENA_PUERTA_SIN_LLAVE = "PuertaSinllave";
    private const string ESCENA_INTERIOR = "Interior";

    // Variable persistente para la llave
    private const string LLAVE_OBTENIDA_KEY = "llavefuera";

    void Start()
    {
        // Solo para depuración: eliminar esto después de probar
        //PlayerPrefs.DeleteAll();
    }

    public void BotonPiedra()
    {
        PlayerPrefs.SetInt(LLAVE_OBTENIDA_KEY, 1); // Guardar estado de la llave
        PlayerPrefs.Save(); // Asegurar que se guarde
        Debug.Log("Llave obtenida. Valor guardado: " + PlayerPrefs.GetInt(LLAVE_OBTENIDA_KEY));
        SceneManager.LoadScene(ESCENA_ESPONJA);
    }

    public void BotonPuerta()
    {
        int llavefuera = PlayerPrefs.GetInt(LLAVE_OBTENIDA_KEY, 0);
        Debug.Log("Valor de la llave al presionar la puerta: " + llavefuera);

        if (llavefuera == 1)
        {
            Debug.Log("Acceso concedido. Entrando a " + ESCENA_INTERIOR);
            SceneManager.LoadScene(ESCENA_INTERIOR);
        }
        else
        {
            Debug.Log("Acceso denegado. Entrando a " + ESCENA_PUERTA_SIN_LLAVE);
            SceneManager.LoadScene(ESCENA_PUERTA_SIN_LLAVE);
        }
    }
}
