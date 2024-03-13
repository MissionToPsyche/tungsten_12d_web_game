using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoreShipScript : MonoBehaviour
{

    /*
        primary items for ship orbiting around planet
    */
    public Transform planet;
    public Transform launchPosition;
    public Rigidbody2D ship;
    [SerializeField] public float orbitDistance;
    [SerializeField] public float orbitSpeed;
    [SerializeField] public float launchSpeed;
    private bool launched;


    // Start is called before the first frame update
    void Start()
    {
        // Unity requires manual setting of values for some reason rather than an intitialization
        // I think because it is in the class which typically reqiure inits
        orbitDistance = 5.0f;
        orbitSpeed = -30.0f;
        launchSpeed = 2.0f;
        launched = false;

        // intialize the ship
        ship = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        // continually check for keyboard input
        if(Input.GetKeyDown(KeyCode.Space)){
            launched = true;
            Launch();
        }

        // only orbit if the planet is there and the launch key has not been pressed
       if(planet != null && !launched){
            OrbitAroundPlanet();
       }
    }

    private void OrbitAroundPlanet(){
        float orbitCircumference = orbitSpeed * Time.deltaTime;
        
        // adjust position of orbiting sprite around planet
        transform.RotateAround(planet.position, Vector3.forward, orbitCircumference);
    }


    private void Launch(){
        
        // get current position of the ship
        // Vector3 currentShipPosition = transform.position;
        
        // test
        Vector3 currentShipPosition = transform.up;
        ship.velocity = currentShipPosition * launchSpeed;
    }    
}
