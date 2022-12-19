using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float damage;
    // -1 durability <=> infinite
    public int durability = -1;

    public void attack() 
    {
        if (durability == -1)
            return;
        durability -= 1;
        if (durability == 0)
            Destroy(gameObject);
    }
}
