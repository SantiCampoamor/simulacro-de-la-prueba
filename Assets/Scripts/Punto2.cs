using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punto2 : MonoBehaviour
{
    // Start is called before the first frame update
    //Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible.
    //Comunicar si la suma de los mismos supera o no el monto de dinero disponible.
    //Luego indicar cuánto dinero sobra o falta.
    public int precio1;
    public int precio2;
    public int precio3;
    public int monto;
    int vuelto;
    int pago;
    void Start()
    {
        int pago = precio1 + precio2 + precio3;
        if (pago == monto)
        {
            Debug.Log("Si te alcanza para comprar los 3 productos, no te sobro nada");
        }
        else if(pago < monto)
        {
            int vuelto = monto - pago;
            Debug.Log("Si te alcanza para comprar los 3 procutos, te sobro " + vuelto );
        }
        else
        {
            int falta = pago - monto;
            Debug.Log("No te alcanza para comprar los 3 productos, te falta "+ falta );
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
