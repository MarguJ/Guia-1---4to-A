using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orientacion : MonoBehaviour
{
    public string nombreDeAlumno;
    public int añoAlumno;
    public string orientacion;

    // Start is called before the first frame update
    void Start()
    {
        if (añoAlumno > 0 && añoAlumno < 3)
        {
            Debug.Log("Error. Aún estás en el ciclo básico");
            return;
        }
        else if (añoAlumno > 2 && añoAlumno < 6)
        {
            if (orientacion != "T" && orientacion != "D" && orientacion != "M" && orientacion != "G" && orientacion != "H")
            {
                Debug.Log("Solo puede ingresar T, D, G, M o H");
                return;
            }
            else if (orientacion == "H" && añoAlumno != 5)
            {
                Debug.Log("Humanidades no existe en 3°ro o 4°to");
            }
            else
            {
                Debug.Log("Muchas gracias " + nombreDeAlumno + "!");
            }
        }
        else
        {
            Debug.Log("Error. La secundaria de esta escuela hasta 5°to año.");
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
