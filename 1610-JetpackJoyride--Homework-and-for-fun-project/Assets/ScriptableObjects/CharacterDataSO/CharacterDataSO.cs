using UnityEngine;
[CreateAssetMenu]
public class CharacterDataSO : ScriptableObject
{
    public bool playerOffGround = false;
    public Sprite currentSkin;
    public Color powerUpColor = Color.white;
    public int currentHeight = 2;
    public float playerHealth = 1.0f;
}
