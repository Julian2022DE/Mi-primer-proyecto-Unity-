using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class My_script : MonoBehaviour
{
    public string MensajedeBienvenida;
    public string Mi_Nombre;
    public string Nombre_amigo;
    public int Mi_edad;
    public int edad_amigo;

    // Start is called before the first frame update
    void Start()
    {
        int total;
        total = Mi_edad + edad_amigo;

        Debug.Log("Nos llamamos" + Mi_Nombre + ("y ") + Nombre_amigo + (" y la suma de nuestras edades es") + (" ") + total);
        

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
