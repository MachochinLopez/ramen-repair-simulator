using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Space : MonoBehaviour
{
    [SerializeField]
    private GameObject fill;
    [SerializeField]
    private Vector3 relativePosition;
    [SerializeField]
    private float minimumSpeed;

    private bool isFilled = false;

    private void OnTriggerEnter(Collider other)
    {
        //Si es una marushan...
        if(other.gameObject.tag == "Ramen")
        {
            //Si la maruchan entra en el trigger
            float speed = other.GetComponent<Model>().getSpeed();

            //Comparamos que la velocidad sea suficientemente rápida.
            if (speed >= minimumSpeed && !isFilled)
            {
                //Instancia el fill del objeto en la posición por defecto y como hijo del objeto a reparar.
                Instantiate(fill, relativePosition, Quaternion.identity, gameObject.transform.parent);
                isFilled = false;

                return;
            }
        }
    }
}
