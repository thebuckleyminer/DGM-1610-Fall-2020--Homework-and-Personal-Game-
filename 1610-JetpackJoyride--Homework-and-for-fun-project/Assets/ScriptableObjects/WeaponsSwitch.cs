using System;
using UnityEngine;
[CreateAssetMenu]
public class WeaponsSwitch : ScriptableObject
{
    public enum Weapons
    {
        Guns,
        Mistles,
        Spikes
    }

    public Weapons currentDefence;

    public void CaseCurrentWeapons()
    {
        switch (currentDefence)
        {
            case Weapons.Guns:
                // Function
                break;
            case Weapons.Mistles:
                // Function
                break;
            case Weapons.Spikes:
                // Function
                break;

        }
    }
}