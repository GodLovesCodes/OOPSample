using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalBasic : MonoBehaviour
{
    public int health, wisdom;

    public virtual void _UpgradeAbility(int _health)
    {
        health += _health;
    }

    public virtual void _UpgradeAbility(int _health, int _wisdom)
    {
        health += _health;
        wisdom += _wisdom;
    }
}