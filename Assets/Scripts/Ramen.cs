using UnityEngine;

public class Ramen : Model
{
    [SerializeField]
    private GameObject[] fragments;

    private float speed;
    private float maximumSpeed = 10;
    private int maxRamenFragments = 30;

    private void Update()
    {
        speed = this.getSpeed();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (speed > maximumSpeed)
        {
            int index = 0;

            for (int i = 0; i <= maxRamenFragments; i++)
            {
                index = Random.Range(0, fragments.Length);

                Vector3 vel = gameObject.GetComponent<Rigidbody>().velocity;

                GameObject obj = fragments[index].gameObject;
                //Instanciar todos los fragmentos.
                Instantiate(obj, collision.contacts[0].point, Quaternion.identity);

                obj.GetComponent<Rigidbody>().velocity= vel;
            }


            //Destuir el objeto.
            Destroy(this.gameObject);
        }
    }
}
