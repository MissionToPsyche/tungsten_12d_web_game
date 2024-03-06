using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{

    /*
        All variables here represent initial conditions each time a 'round'
        is completed and the assets need to be reset to their original
        conditions, things that need to be randomized do need to be handled some
        way though
    */

    /*
        Spawn area dimensions - We don't want random functions called and generated
        at the start, or else it will randomize once but we do the location values
        saved
    */


    // offset based on created spawn blocks
    int spawn_offset = 3;



    /*
        Start will initialize the first generation of asteroids
        - however, since the scene is being re-used instead of being created and destroyed each time
        this will only be called once at the very beginning
         
    */
    void Start()
    {
        // --- Outter circle quadrant spawns (x,y) ---
        // left side top to bottom
        Vector2 quadrant1 = new Vector2(Random.Range(-33 - spawn_offset, -33 + 1 + spawn_offset), Random.Range(24 - spawn_offset, 25 + spawn_offset));
        Vector2 quadrant2 = new Vector2(Random.Range(-44 - spawn_offset, -44 + 1 + spawn_offset), Random.Range(14 - spawn_offset, 14 + 1 + spawn_offset));
        Vector3 quadrant3 = new Vector2(Random.Range(-44 - spawn_offset, -44 + 1 + spawn_offset), Random.Range(0 - spawn_offset, 0 + 1 + spawn_offset));
        Vector2 quadrant4 = new Vector2(Random.Range(-43 - spawn_offset, -43 + 1 + spawn_offset), Random.Range(-15 - spawn_offset, -15 + 1 + spawn_offset));
        Vector2 quadrant5 = new Vector2(Random.Range(-32 - spawn_offset, -32 + 1 + spawn_offset), Random.Range(-24 - spawn_offset, -24 + 1 + spawn_offset));

        // right side top to bottom
        Vector2 quadrant6 = new Vector2(Random.Range(26 - spawn_offset, 26 + 1 + spawn_offset), Random.Range(23 - spawn_offset, 23 + 1 + spawn_offset));
        Vector2 quadrant7 = new Vector2(Random.Range(42 - spawn_offset, 42 + 1 + spawn_offset), Random.Range(17 - spawn_offset, 17 + 1 + spawn_offset));



        // --- Inner circle quadrant spawns (x,y) ---
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
