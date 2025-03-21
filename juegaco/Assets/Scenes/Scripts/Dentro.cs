using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiaeDentro : MonoBehaviour{
    private const string ESCENA_TELE_VIEJA = "Televieja";
    public void BotonTeleVieja()
    {
        SceneManager.LoadScene(ESCENA_TELE_VIEJA);
    }
}
