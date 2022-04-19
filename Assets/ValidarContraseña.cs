using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ValidarContraseña : MonoBehaviour
{

    string ContraseñaCorrecta;
    string ContraseñaUsuario;
    public Text IngresoUsuario;
    public Text TextoMensaje;
    public GameObject cartel_Mensaje;

    public void Validar_Contraseña()
    {
        
        ContraseñaUsuario = IngresoUsuario.text;

        if (ContraseñaUsuario == ContraseñaCorrecta)
        {
            Debug.Log("Bienvenido");
            cartel_Mensaje.SetActive(true);
            TextoMensaje.text = "Bienvenido";
        }
        else
        {
            Debug.Log("Contraseña incorrecta");
            cartel_Mensaje.SetActive(true);
            TextoMensaje.text = "Contraseña incorrecta";
        }
    }

    void Start()
    {
        ContraseñaCorrecta = "12345";
        cartel_Mensaje.SetActive(false);
    }


}
