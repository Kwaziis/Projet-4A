using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DJDeLambiance : MonoBehaviour
{
    public AudioSource LeSon;
    public AudioClip[] tracks;
    // Start is called before the first frame update
    void Start()
    {
        int choose = Random.Range(0, tracks.Length-1);
        LeSon.clip = tracks[choose];
        LeSon.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
