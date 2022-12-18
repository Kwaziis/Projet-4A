using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Loot
{
    public float Chance;
    public bool Present;
}

[CreateAssetMenu]
public class BuildingLoots : ScriptableObject
{
    public Loot[] loots;
    // Start is called before the first frame update
    public Loot GetLoot()
    {
        float drawn = Random.Range(0, loots.Length);
        return loots[(int)Mathf.Floor(drawn)];
    }
}
