using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCarrusel : MonoBehaviour
{
    public GameObject centro1;
    public GameObject centro2;
    public GameObject centro3;
    public float altura1 = 0f;
    public float altura2 = 2.5f;
    public float altura3 = 5f;

    void Start()
    {
        // Iniciar la corrutina de movimiento
        StartCoroutine(MoverCentrosCiclicamente());
    }

    IEnumerator MoverCentrosCiclicamente()
    {

        while (true)
        {
            // Mover cada centro a su altura específica de manera instantánea
            MoverObjetoEnY(centro1, altura3);
            MoverObjetoEnY(centro2, altura1);
            MoverObjetoEnY(centro3, altura2);

            // Esperar 5 segundos antes de la siguiente iteración
            yield return new WaitForSeconds(5f);

            // Reposicionar cada centro a nuevas alturas después de 5 segundos adicionales
            MoverObjetoEnY(centro1, altura2);
            MoverObjetoEnY(centro2, altura3);
            MoverObjetoEnY(centro3, altura1);

            // Esperar 5 segundos antes de la siguiente iteración
            yield return new WaitForSeconds(5f);

            // Reposicionar cada centro a nuevas alturas después de 5 segundos adicionales
            MoverObjetoEnY(centro1, altura1);
            MoverObjetoEnY(centro2, altura2);
            MoverObjetoEnY(centro3, altura3);

            // Esperar 5 segundos antes de la siguiente iteración
            yield return new WaitForSeconds(5f);
        }
    }

    void MoverObjetoEnY(GameObject objeto, float alturaDestino)
    {
        Vector3 nuevaPosicion = new Vector3(objeto.transform.position.x, alturaDestino, objeto.transform.position.z);
        objeto.transform.position = nuevaPosicion;
    }
}
