using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Space : MonoBehaviour
{
    [SerializeField]
    private Collider col;
    [SerializeField]
    private GameObject fill;
    [SerializeField]
    private Vector3 relativePosition;
    [SerializeField]
    private float minimumSpeed;

    private void OnTriggerEnter(Collider other)
    {
        //Si la maruchan entra en el trigger
        float speed = other.GetComponent<Model>().getSpeed();

        //Comparamos que la velocidad sea suficientemente rápida.
        if(speed >= minimumSpeed)
        {
            //Instancia el fill del objeto.
            Instantiate(fill, relativePosition, Quaternion.identity, gameObject.transform.parent);
        }
    }
}
