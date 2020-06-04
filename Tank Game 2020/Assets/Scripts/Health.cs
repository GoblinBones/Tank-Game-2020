using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public TankData data;
    /// <summary>
    /// takeDamage subtracts the damage from the CurrentHealth
    /// </summary>
    /// <param name="damage"></param>
    public void takeDamage(float damage)
    {
        data.CurrentHealth -= damage;
    }
}
