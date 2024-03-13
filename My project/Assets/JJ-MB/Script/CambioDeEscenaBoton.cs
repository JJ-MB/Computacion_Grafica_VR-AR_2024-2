using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CambioDeEscenaBoton : MonoBehaviour
{
    // Nombre de la escena a la que deseamos cambiar.
    public string nombreDeEscenaDestino = "EscenasDestino";

    private void Start()
    {
        // Obtenemos el componente Button al que se adjunta este script.
        Button boton = GetComponent<Button>();
        
        // se llama a CambiarEscena().
        boton.onClick.AddListener(CambiarEscena);
    }

    // Se llama cuando se hace clic en el boton.
    void CambiarEscena()
    {
        // Cargamos la escena especificada en el campo "nombreDeEscenaDestino".
        SceneManager.LoadScene(nombreDeEscenaDestino);
    }
}
