using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public TankData data;

    private float timer;

    private bool canShoot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // subtracts time from the timer
        timer -= Time.deltaTime;
        // if the timer is less than 1
        if (timer < 1)
        {
            // it can shoot
            canShoot = true;
            // resets the timer
            timer = data.FireRate;
        }
        //sets verticalInput to 0
        Vector3 verticalInput = Vector3.zero;
        //Get input for moving forwards and backwards
        verticalInput = new Vector3(0,0,Input.GetAxis("Vertical"));
        //Gets input for rotating left and right
        Vector3 horizontalInput = new Vector3(Input.GetAxis("Horizontal"), 0,0);
        //if the player presses Space 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //and they can shoot
            if (canShoot)
            {
                // the tank shoots
                data.moveTank.Shoot();

            }

        }
        //if the tank is going backwards
        if (verticalInput.z < 0)
        {
            //The tank moves backwards using the reverse speed
            data.moveTank.Movement(verticalInput * data.Reverse);
        }
        else
        {
            //other wise the tanks moves forwards speed
            data.moveTank.Movement(verticalInput * data.Speed);
        }
        // Rotates the tank in the input direction
        data.moveTank.Rotate(horizontalInput * data.Rotation * Time.deltaTime);
        
    }
}
