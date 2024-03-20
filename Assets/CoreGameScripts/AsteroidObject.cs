using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
    Mainly a simple object class model to dictate asteroid behavior when 
    used in other scripts. This functions more as a model not a controller

*/
public class AsteroidObject : MonoBehaviour
{
    // Items related to position of the asteroids
    // note: we will not be making drift speeds random
    public Rigidbody2D asteroid;
    [SerializeField] private float x_drift;
    [SerializeField] private float y_drift;
    [SerializeField] private float rotation;

    // To-Do: Get other values on this asteroid to then
    // be used later on with research points for upgrades

    public void Initialize(Vector2 initial_position, float xDrift, float yDrift, float newRotation)
    {
        // init the rigid body
        asteroid = GetComponent<Rigidbody2D>();

        // set asteroid initial position
        transform.position = initial_position;

        // init movement
        this.x_drift = xDrift;
        this.y_drift = yDrift;
        this.rotation = newRotation;

        // init velocity
        asteroid.velocity = new Vector2(xDrift, yDrift);
    }

    public void ResetPosition(Vector2 new_position){
        
        // reset location of the asteroid
        transform.position = new_position;

        // reset asteroid drift velocity
        asteroid.velocity = new Vector2(this.x_drift, this.y_drift);
        
    }

    // Update is called once per
    // We want the asteroid objects to handle their own rotation and movement,
    // NOT the spawner 
    void Update()
    {
        // maintain rotation and movement
        transform.Translate(new Vector2(x_drift, y_drift) * Time.deltaTime);
        asteroid.rotation += rotation;
    }
}
