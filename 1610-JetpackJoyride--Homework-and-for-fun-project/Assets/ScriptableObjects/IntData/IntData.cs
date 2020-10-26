using UnityEngine;
[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int value;

    public void ValueChanger(int number)
    {
        value += number;
    }
}
