using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : MonoBehaviour
{
	Rigidbody rb;

    void Start()
    {
		rb = gameObject.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Debug.Log(getSpeed());
    }

    public float getSpeed()
    {
        float result = Mathf.Abs(rb.velocity.x) + Mathf.Abs(rb.velocity.y) + Mathf.Abs(rb.velocity.z);
        return result;
    }

}
