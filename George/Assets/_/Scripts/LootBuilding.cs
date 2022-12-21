using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootBuilding : MonoBehaviour
{
    public BuildingLoots table;
    private Loot pop;

    void Start()
    {
        table.initialize();
        pop = table.GetLoot(1);
        if (pop == null)
        {
            Debug.Log("rien");
            return;
        }
        Instantiate(pop.prefab, new Vector3(0, 5, 0), Quaternion.identity);
    }
}
