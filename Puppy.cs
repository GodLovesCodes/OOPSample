using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puppy : AnimalBasic
{
    private void Start()
    {
        health = 100;
        wisdom = 50;
    }

    public override void _UpgradeAbility(int _multiplyHealth)
    {
        health += _multiplyHealth * Random.Range(1, 5);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            _UpgradeAbility(5);
        if (Input.GetKeyDown(KeyCode.E))
            _UpgradeAbility(5, 10);
    }
}
