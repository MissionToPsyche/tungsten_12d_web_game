using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoreShipObject : MonoBehaviour
{

    /*
        Local items to dictate spaceship functionality
    */
    public Transform planet;
    public Transform launchPosition;
    public Rigidbody2D ship;
    private CoreGameController coreGameController;
    [SerializeField] public float orbitDistance;
    [SerializeField] public float orbitSpeed;
    [SerializeField] public float launchSpeed;
    [SerializeField] public float orbitDelaySec; // may be useful for debuging later, or issues in test
    private bool launched;


    // Start is called before the first frame update
    void Start()
    {
        // Unity requires manual setting of values for some reason rather than an intitialization
        // I think because it is in a class which typically reqiure inits
        orbitDistance = 5.0f;
        orbitSpeed = -30.0f;
        launchSpeed = 5.0f;
        orbitDelaySec = 0.5f;
        launched = false;

        // intialize the ship
        ship = GetComponent<Rigidbody2D>();
        coreGameController = FindObjectOfType<CoreGameController>();

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

    /*
        Movement function in initial round state when the spaceship is orbiting around the 
        planet. 

        !!! Do not modify this function without consulting Cole (dc message is fine) !!!
    */
    public void OrbitAroundPlanet(){
        // Calculate circumference
        float orbitCircumference = orbitSpeed * Time.deltaTime;
        
        // adjust position of orbiting sprite around planet
        transform.RotateAround(planet.position, Vector3.forward, orbitCircumference);
    }

    /*
        Function that launches the spacecraft away from the planet

        !!! Do not modify this function without consulting Cole (dc message is fine) !!!
    */
    public void Launch(){
        
        Vector3 currentShipPosition = transform.up;
        ship.velocity = currentShipPosition * launchSpeed;
    }


    /*
        Here are the event triggers for when the spaceship either goes out of bounds or hits and asteroid

        OnCollisionenter2D is a unity specific function, (arguments included) therefore it is imperative
        you !!! do not modify the name of the function, only the items inside the function !!!
    
    
    */
    void OnCollisionEnter2D(Collision2D collision){

        // Flag the asteroid hitting one of the out of bounds walls
        if(collision.gameObject.CompareTag("LeftBoundary") || collision.gameObject.CompareTag("RightBoundary") || 
        collision.gameObject.CompareTag("TopBoundary") || collision.gameObject.CompareTag("BottomBoundary")){
            
            // let the core game controller invoke the out of bounds method
            coreGameController.OnSpaceshipOutOfBounds();
        }

        if(collision.gameObject.CompareTag("Asteroid")){
            coreGameController.OnSpaceshipHitAsteroid();
        }
    }




    /*
        The next three functions are responsible for resetting the spaceship back to the original
        position and then starting up the orbit. It is super important not to modify the IEnumerator
        
        If you need to adjust the time for reposition, just change the orbitDelaySec variable and it will
        make the game wait a little longer before starting the orbit movement again.
    
    */
    // Helper function to ResetSpaceship 
    // essential to have coroutine so orbit doesn't start before the reposition is complete
    IEnumerator RepositionComplete(){
        
        // wait 500 ms before setting orbit movement back to normal
        yield return new WaitForSeconds(orbitDelaySec);

        launched = false;
    }

    // may be needed later on incase user system has orbit problems and need to increase 
    // delay before starting movement again - tie to a setting or report screen
    public void IncreaseDelay(){
        orbitDelaySec += 0.5f;
    }

    public void ResetSpaceship(){

        // reset ship position
        ship.position = new Vector2(0, 4);

        // reset velocity and rotation to zero
        ship.velocity = Vector2.zero;
        ship.angularVelocity = 0;

        // Reset rotation to initial orientation
        transform.rotation = Quaternion.Euler(0, 0, -90);

        // make sure we wait a set time before starting orbit back up
        // or else the orbit movement will be severly messed up
        StartCoroutine(RepositionComplete());
    }
}
