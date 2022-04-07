using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punto1 : MonoBehaviour
{
    // Start is called before the first frame update
    //Crea un programa que permita ingresar por Inspector dos valores enteros y responda si son iguales o no lo son.
    public int num1;
    public int num2;
    void Start()

    {
        if (num1 == num2)
        {
            Debug.Log("Estos dos numeros son iguales");
        }
        else
        {
            Debug.Log("Estos dos numeros no son iguales");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
