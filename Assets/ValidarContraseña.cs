using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ValidarContraseña : MonoBehaviour
{

    string ContraseñaCorrecta;
    string ContraseñaUsuario;
    public Text IngresoUsuario;

    public void Validar_Contraseña()
    {
        
        ContraseñaUsuario = IngresoUsuario.text;

        if (ContraseñaUsuario == ContraseñaCorrecta)
        {
            Debug.Log("Bienvenido");
        }
        else
        {
            Debug.Log("Contraseña incorrecta");
        }
    }

    void Start()
    {
        ContraseñaCorrecta = "12345";
    }


}
