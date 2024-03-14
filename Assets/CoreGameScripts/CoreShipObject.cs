using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoreShipObject : MonoBehaviour
{

    /*
        primary items for ship orbiting around planet
    */
    public Transform planet;
    public Transform launchPosition;
    public Rigidbody2D ship;
    private CoreGameController coreGameController;
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
        coreGameController = FindObjectOfType<CoreGameController>();

    }

    // Update is called once per frame
    void Update()
    {

        // testing item for getting orbit to go back to normal
        if(Input.GetKeyDown(KeyCode.L)){
            launched = false;
        }
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

    public void OrbitAroundPlanet(){
        // Calculate circumference
        float orbitCircumference = orbitSpeed * Time.deltaTime;
        
        // adjust position of orbiting sprite around planet
        transform.RotateAround(planet.position, Vector3.forward, orbitCircumference);
    }

    public void Launch(){
        
        // get current position of the ship
        // Vector3 currentShipPosition = transform.position;
        
        // test
        Vector3 currentShipPosition = transform.up;
        ship.velocity = currentShipPosition * launchSpeed;
    }

    void OnCollisionEnter2D(Collision2D collision){

        // Flag the asteroid hitting one of the out of bounds walls
        if(collision.gameObject.CompareTag("LeftBoundary") || collision.gameObject.CompareTag("RightBoundary") || 
        collision.gameObject.CompareTag("TopBoundary") || collision.gameObject.CompareTag("BottomBoundary")){
            
            // let the core game controller invoke the out of bounds method
            coreGameController.OnSpaceshipOutOfBounds();
        }
    }


    public void ResetSpaceship(){
        
        // reset ship position
        ship.position = new Vector2(0, 4);

        // reset velocity to zero
        ship.velocity = Vector2.zero;
        ship.angularVelocity = 0;

        // Reset rotation to initial orientation
        transform.rotation = Quaternion.Euler(0, 0, -90);

        
        // make sure launched is put back to false
        // launched = false;
    }
}
