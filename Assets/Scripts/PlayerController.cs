using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // PROPIEDADES O VARIABLES
    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Tenemos que mover el vehiculo hacia delante

        transform.Translate(10 * Time.deltaTime * Vector3.forward);
    }
}
