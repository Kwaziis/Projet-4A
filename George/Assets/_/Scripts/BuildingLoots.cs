using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Loot
{
    //categorise les loots des batiments (surement que des armes mais ça peut changer)
    public Weapon prefab;
    public float Chance = 100;
    public int Tier = 1;
    public bool alreadyLooted = false;
}

[CreateAssetMenu]
public class BuildingLoots : ScriptableObject
{
    //une liste de loots que qui peuvent apparaitre d'un batiment
    public Loot[] loots;
    // donne un loot qui n'est pas déja aparu et qui a un tier valide
    public Loot GetLoot(int Tier)
    {
        float drawn = Random.Range(0f, 100f);
        foreach(Loot loot in loots)
        {
            if (loot.alreadyLooted) 
            {
                continue;
            }
            if (loot.Chance <= drawn && loot.Tier <= Tier) 
            {
                loot.alreadyLooted = true;
                return loot;
            }
        }
        return null;
    }
    public void initialize()
    { 
        foreach(Loot loot in loots)
        {
            loot.alreadyLooted = false;
        }
    }
}
