using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarObjetosConToque : MonoBehaviour
{
    private int currentIndex = 0; // Índice del objeto actual.
    private Transform[] childObjects; // Array de objetos secundarios.

    // Start is called before the first frame update
    void Start()
    {
        // Obtiene todos los objetos secundarios y los almacena en el array.
        childObjects = new Transform[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            childObjects[i] = transform.GetChild(i);
            childObjects[i].gameObject.SetActive(false);//desactivamos todos los objetos para mostrar uno por uno posterirmente 
        }

        // Activa solo el primer objeto al inicio.
        CambiarObjeto(currentIndex);
    }

    // Update is called once per frame
    void Update()
    {
        // Detecta toques en la pantalla.
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            // Desactiva el objeto actual.
            DesactivarObjeto(currentIndex);

            // Avanza al siguiente objeto en la lista.
            currentIndex = (currentIndex + 1) % childObjects.Length;

            // Activa el nuevo objeto.
            CambiarObjeto(currentIndex);
        }
    }

    // Desactiva un objeto por objeto.
    void DesactivarObjeto(int index)
    {
        childObjects[index].gameObject.SetActive(false);
    }

    // Activa un objeto por objeto.
    void CambiarObjeto(int index)
    {
        childObjects[index].gameObject.SetActive(true);
    }
}