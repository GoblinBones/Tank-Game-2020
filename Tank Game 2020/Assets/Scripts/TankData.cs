using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankData : MonoBehaviour
{
    public TankMovement moveTank;
    public CharacterController contolCharacter;
    public float Speed;
    public float Reverse;
    public float Rotation;
    public GameObject Bullet;
    public Transform FirePoint;
    public float FireRate;
    public float CurrentHealth;
    public float maxHealth;
    public float Score;

    void Start()
    {
        //Set the current Health to Max health
        CurrentHealth = maxHealth;
    }
}
