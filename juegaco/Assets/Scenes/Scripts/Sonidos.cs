using UnityEngine;

public class SonidoBoton : MonoBehaviour
{
    public AudioSource yippie;
    public AudioClip efecto;
   public void pulsarboton()
    {
        yippie.clip=efecto;
        yippie.Play();
    }


}
