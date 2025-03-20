using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections; // Necesario para corutinas(no se que es)

public class CambiarNivel : MonoBehaviour
{
    
    private bool llavefuera = false;
    private string Escenaesponja = "EsponjaPiedra";
    private string EscenaPuertaSinllave = "PuertaSinllave";
    private string EscenaInterior = "Interior";

    

    public void BotonPiedra()
    {
        llavefuera = true;
        SceneManager.LoadScene(Escenaesponja);
         
    }
    public void BotonPuerta()
    {
        if(llavefuera==true){
            SceneManager.LoadScene(EscenaInterior);
        }else{
            SceneManager.LoadScene(EscenaPuertaSinllave);
        }

    }
}
