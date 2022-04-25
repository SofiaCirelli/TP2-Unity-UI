using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MayoriaDeEdad : MonoBehaviour
{
    public int edadUsuario;
    public Text miTexto;
    // Start is called before the first frame update
    void Start()
    {
        if (edadUsuario >= 18)
        {
            miTexto.text = "Eres mayor de edad";
            Debug.Log("Eres mayor de edad");
        }
        else
        {
            miTexto.text = "No eres mayor de edad";
            Debug.Log("No eres mayor de edad");
        }
    }
    
}
