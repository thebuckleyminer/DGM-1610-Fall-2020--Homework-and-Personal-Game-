using UnityEngine;
[CreateAssetMenu]
public class CollectibleWeaponSOScript : ScriptableObject
{
    public int ammo;
    public Sprite weaponImage;
    public Color currentColor = Color.white;
    public bool activeWeapon = false;
}
