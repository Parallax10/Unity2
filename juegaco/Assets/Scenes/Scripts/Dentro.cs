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

    private const string ESCENA_TELE1 = "tele1";
    private const string ESCENA_TELE2 = "tele2";
    private const string ESCENA_TELE3 = "tele3";
    private const string ESCENA_TELE4 = "tele4";
    private const string ESCENA_TELE5 = "tele5";
    private const string ESCENA_TELE6 = "tele6";
    private const string ESCENA_TELE7 = "tele7";
    private const string ESCENA_TELE8 = "tele8";
    private const string ESCENA_TELE9 = "tele9";

    private const string ESCENA_PANTALLA1 = "Pantalla1";
    private const string ESCENA_PANTALLA2 = "Pantalla2";
    private const string ESCENA_PANTALLA3 = "Pantalla3";
    private const string ESCENA_PANTALLA4 = "Pantalla4";
    private const string ESCENA_PANTALLA5 = "Pantalla5";
    private const string ESCENA_PANTALLA6 = "Pantalla6";
    private const string ESCENA_PANTALLA7 = "Pantalla7";
    private const string ESCENA_PANTALLA8 = "Pantalla8";
    private const string ESCENA_PANTALLA9 = "Pantalla9";
    private const string ESCENA_SALIDA = "Menu inicia";


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
        SceneManager.LoadScene(ESCENA_TELE1);
    }
    public void bt2()
    {
        SceneManager.LoadScene(ESCENA_TELE2);
    }
    public void bt3()
    {
        SceneManager.LoadScene(ESCENA_TELE3);
    }
    public void bt4()
    {
        SceneManager.LoadScene(ESCENA_TELE4);
    }
    public void bt5()
    {
        SceneManager.LoadScene(ESCENA_TELE5);
    }
    public void bt6()
    {
        SceneManager.LoadScene(ESCENA_TELE6);
    }
    public void bt7()
    {
        SceneManager.LoadScene(ESCENA_TELE7);
    }
    public void bt8()
    {
        SceneManager.LoadScene(ESCENA_TELE8);
    }
    public void bt9()
    {
        SceneManager.LoadScene(ESCENA_TELE9);
    }
    public void tele1()
    {
        SceneManager.LoadScene(ESCENA_PANTALLA1);
    }
    public void tele2()
    {
        SceneManager.LoadScene(ESCENA_PANTALLA2);
    }
    public void tele3()
    {
        SceneManager.LoadScene(ESCENA_PANTALLA3);
    }
    public void tele4()
    {
        SceneManager.LoadScene(ESCENA_PANTALLA4);
    }
    public void tele5()
    {
        SceneManager.LoadScene(ESCENA_PANTALLA5);
    }
    public void tele6()
    {
        SceneManager.LoadScene(ESCENA_PANTALLA6);
    }
    public void tele7()
    {
        SceneManager.LoadScene(ESCENA_PANTALLA7);
    }
    public void tele8()
    {
        SceneManager.LoadScene(ESCENA_PANTALLA8);
    }
    public void tele9()
    {
        SceneManager.LoadScene(ESCENA_PANTALLA9);
    }

    public void Pantalla1()
    {
        SceneManager.LoadScene(ESCENA_INTERIOR2);
    }
    public void Pantalla2()
    {
        SceneManager.LoadScene(ESCENA_INTERIOR3);
    }
    public void Pantalla3()
    {
        SceneManager.LoadScene(ESCENA_INTERIOR4);
    }
    public void Pantalla4()
    {
        SceneManager.LoadScene(ESCENA_INTERIOR5);
    }
    public void Pantalla5()
    {
        SceneManager.LoadScene(ESCENA_INTERIOR6);
    }
    public void Pantalla6()
    {
        SceneManager.LoadScene(ESCENA_INTERIOR7);
    }
    public void Pantalla7()
    {
        SceneManager.LoadScene(ESCENA_INTERIOR8);
    }
    public void Pantalla8()
    {
        SceneManager.LoadScene(ESCENA_INTERIOR9);
    }
    public void Pantalla9()
    {
        SceneManager.LoadScene(ESCENA_SALIDA);
    }
    
    public void Salir()
    {
        SceneManager.LoadScene(ESCENA_SALIDA);
    }


}
