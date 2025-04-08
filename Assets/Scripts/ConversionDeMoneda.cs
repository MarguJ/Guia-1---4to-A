using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversionDeMoneda : MonoBehaviour
{
    public float plata;
    public string conversion;

    // Start is called before the first frame update
    void Start()
    {
        if (plata >= 1000)
        {
            if (conversion == "D")
            {
                plata = plata / 1075.43f;
            }
            else if (conversion == "R")
            {
                plata = plata / 225.61f;
            }
            else if (conversion == "E")
            {
                plata = plata / 1172.99f;
            }
            else
            {
                Debug.Log("Opción de moneda extranjera no válida");
                return;
            }
            Debug.Log("El monto convertido es " + plata);
            return;
        }
        else
            Debug.Log("El monto minimo es $1000");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
