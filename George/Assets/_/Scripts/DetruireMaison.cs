using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetruireMaison : MonoBehaviour
{

    public float radius = 5.0F;
    public float power = 2000.0F;

    // Start is called before the first frame update
    void Start()
    {
    }

    private void Explode() {
        foreach(Transform child in transform)
        {
            Rigidbody rb = child.gameObject.GetComponent<Rigidbody>();
            rb.AddExplosionForce(power, transform.position, radius, 30.0F);
        }        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return)){
            this.Explode();
        }   
    }
}