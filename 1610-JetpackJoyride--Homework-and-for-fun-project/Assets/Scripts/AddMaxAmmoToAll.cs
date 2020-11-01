using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

public class AddMaxAmmoToAll : MonoBehaviour
{
    public int howdy;

    public List<CollectibleWeaponSOScript> collectibleWeapons;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void reloadAll()
    {
        for (var i = 0; i < collectibleWeapons.Count; i++)
        {
            var indexWeapon = collectibleWeapons[i];
            indexWeapon.ammo = 100;
        }
    }
}
