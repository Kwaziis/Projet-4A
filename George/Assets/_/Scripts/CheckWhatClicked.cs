using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CheckWhatClicked : MonoBehaviour
{
    // Start is called before the first frame update
    private MonoBehaviour outlineScript, destruction;
    public GameObject player;
    bool CanBeDestroyed, IsDestroyed;
    void Start()
    {
        
        outlineScript = GetComponent<Outline>();
        //destruction = GetComponent<Destruction>();
    }

    // Update is called once per frame
    void Update()
    {
    if (!IsDestroyed){
        float dist = Vector2.Distance(player.transform.position, transform.position);    
        if (dist<=7){
            CanBeDestroyed = true;
            outlineScript.enabled = true; 
        }
        else{
            CanBeDestroyed = false;
            outlineScript.enabled = false; 
        }
    }
    }

    void OnMouseDown()
    {
     
        if (CanBeDestroyed)
        {
            Destroy(gameObject);
            outlineScript.enabled = false;
            IsDestroyed = true;
            
        }
    }
}
