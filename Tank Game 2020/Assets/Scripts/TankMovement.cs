using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;


public class TankMovement : MonoBehaviour
{
    public TankData data;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Movement(Vector3 Direction)
    {
        //moves the tank in the specified direction and speed
        data.contolCharacter.SimpleMove(transform.forward * Direction.z * Time.deltaTime);
    }

    public void Rotate(Vector3 Direction)
    {
        //rotates the tank in the specified direction
        transform.Rotate(Vector3.up, Direction.x);
    }

    public void Shoot()
    {
        //creates the bullet at the fire point and rotation
        Instantiate(data.Bullet, data.FirePoint.position, data.FirePoint.rotation);
    }
}
