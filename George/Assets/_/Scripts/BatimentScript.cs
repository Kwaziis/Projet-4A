using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BatimentScript : MonoBehaviour
{
    // Start is called before the first frame update
    private MonoBehaviour outlineScript, destruction;
    public GameObject player;
    public GameObject destroyedPrefab;
    public Material myMaterial;
    bool CanBeDestroyed, IsDestroyed;

    public ProgressBar ProgressBar;
    void Start()
    {
        
        outlineScript = GetComponent<Outline>();
        ProgressBar.maximum += 1;
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
            ProgressBar.current += 1;
            Destroy(gameObject);
            outlineScript.enabled = false;
            IsDestroyed = true;
            Instantiate(destroyedPrefab,  gameObject.transform.position,  Quaternion.identity); 
            destroyedPrefab.GetComponent<Renderer>().material = myMaterial;
            
        }
    }
}
