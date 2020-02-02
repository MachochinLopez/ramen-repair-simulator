using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : MonoBehaviour
{
	private Rigidbody rb;

    void Start()
    {
		rb = gameObject.GetComponent<Rigidbody>();
    }

    public float getSpeed()
    {
        float result = Mathf.Abs(rb.velocity.x) + Mathf.Abs(rb.velocity.y) + Mathf.Abs(rb.velocity.z);
        return result;
    }

}
