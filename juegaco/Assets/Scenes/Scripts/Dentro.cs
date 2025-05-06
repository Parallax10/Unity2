using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiaeDentro : MonoBehaviour{
    private const string ESCENA_TELE_VIEJA = "Televieja";
    private const string ESCENA_INTERIOR1 = "Interior1";
    private const string ESCENA_INTERIOR2 = "Interior2";
    private const string ESCENA_INTERIOR3 = "Interior3";
    private const string ESCENA_INTERIOR4 = "Interior4";
    private const string ESCENA_INTERIOR5 = "Interior5";
    private const string ESCENA_INTERIOR6 = "Interior6";
    private const string ESCENA_INTERIOR7 = "Interior7";
    private const string ESCENA_INTERIOR8 = "Interior8";
    private const string ESCENA_INTERIOR9 = "Interior9";

    public void BotonTeleVieja()
    {
        SceneManager.LoadScene(ESCENA_TELE_VIEJA);
    }
    public void Mando()
    {
        SceneManager.LoadScene(ESCENA_INTERIOR1);
    }
    public void bt1()
    {
        SceneManager.LoadScene(ESCENA_INTERIOR2);
    }
    public void bt2()
    {
        SceneManager.LoadScene(ESCENA_INTERIOR3);
    }
    public void bt3()
    {
        SceneManager.LoadScene(ESCENA_INTERIOR4);
    }
    public void bt4()
    {
        SceneManager.LoadScene(ESCENA_INTERIOR5);
    }
    public void bt5()
    {
        SceneManager.LoadScene(ESCENA_INTERIOR6);
    }
    public void bt6()
    {
        SceneManager.LoadScene(ESCENA_INTERIOR7);
    }
    public void bt7()
    {
        SceneManager.LoadScene(ESCENA_INTERIOR8);
    }
    public void bt8()
    {
        SceneManager.LoadScene(ESCENA_INTERIOR9);
    }


}
