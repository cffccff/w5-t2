using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
          Vector3 vector = new Vector3(2f,0,0);
        // transform.Translate(vector*2f* Time.deltaTime);
        rigidbody.AddForce(vector*2f);
    }
}
