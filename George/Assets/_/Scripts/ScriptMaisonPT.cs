using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptMaisonPT : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<transform.childCount;i++){
			
			Rigidbody rb = transform.GetChild(i).GetComponent<Rigidbody>();
			rb.constraints = RigidbodyConstraints.None;			
			rb.AddForce(new Vector3(0.3f, 0.8f, 1f) * 30);
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
