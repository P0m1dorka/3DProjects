using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat
{
    public void Shoot(Transform firepoint, GameObject bullet)
    {
        GameObject bull = GameObject.Instantiate(bullet, firepoint);
    }
}
