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
    // Game objects
    public GameObject Meteor1Prefab;
    public GameObject Meteor2Prefab;
    public GameObject Meteor3Prefab;

    // Quadrant data
    private Vector2 quadrant1;
    private Vector2 quadrant2;
    private Vector2 quadrant3;
    private Vector2 quadrant4;
    private Vector2 quadrant5;
    private Vector2 quadrant6;
    private Vector2 quadrant7;
    private Vector2 quadrant8;
    private Vector2 quadrant9;
    private Vector2 quadrant10;
    private Vector2 quadrant11;
    private Vector2 quadrant12;
    private Vector2 quadrant13;
    private Vector2 quadrant14;
    private Vector2 quadrant15;
    private Vector2 quadrant16;
    private Vector2 quadrant17;
    private Vector2 quadrant18;

    // offset
    [SerializeField] private int spawn_offset = 5;

    // Asteroid Game Objects
    private GameObject ast1;
    private GameObject ast2;
    private GameObject ast3;
    private GameObject ast4;
    private GameObject ast5;
    private GameObject ast6;
    private GameObject ast7;
    private GameObject ast8;
    private GameObject ast9;
    private GameObject ast10;
    private GameObject ast11;
    private GameObject ast12;
    private GameObject ast13;
    private GameObject ast14;
    private GameObject ast15;
    private GameObject ast16;
    private GameObject ast17;
    private GameObject ast18;

    // Asteroid Items
    private AsteroidObject asteroid1;
    private AsteroidObject asteroid2;
    private AsteroidObject asteroid3;
    private AsteroidObject asteroid4;
    private AsteroidObject asteroid5;
    private AsteroidObject asteroid6;
    private AsteroidObject asteroid7;
    private AsteroidObject asteroid8;
    private AsteroidObject asteroid9;
    private AsteroidObject asteroid10;
    private AsteroidObject asteroid11;
    private AsteroidObject asteroid12;
    private AsteroidObject asteroid13;
    private AsteroidObject asteroid14;
    private AsteroidObject asteroid15;
    private AsteroidObject asteroid16;
    private AsteroidObject asteroid17;
    private AsteroidObject asteroid18;

    // SerializeFields for getting dynamic movement
    [SerializeField] private float x_drift;
    [SerializeField] private float y_drift;
    [SerializeField] private float ast_rotation;



    /*
        Start will initialize the first generation of asteroids
        - however, since the scene is being re-used instead of being created and destroyed each time
        this will only be called once at the very beginning
         
    */
    void Start()
    {
        RandomizeQuadrants();
        InstantiateAsteroidGameObjects();
        InstantiateAsteroidObjects();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RandomizeQuadrants()
    {
        // --- Outter circle quadrant spawns (x,y) ---
        // left side top to bottom
        quadrant1 = new Vector2(Random.Range(-33 - spawn_offset, -33 + 1 + spawn_offset), Random.Range(24 - spawn_offset, 25 + spawn_offset));
        quadrant2 = new Vector2(Random.Range(-44 - spawn_offset, -44 + 1 + spawn_offset), Random.Range(14 - spawn_offset, 14 + 1 + spawn_offset));
        quadrant3 = new Vector2(Random.Range(-44 - spawn_offset, -44 + 1 + spawn_offset), Random.Range(0 - spawn_offset, 0 + 1 + spawn_offset));
        quadrant4 = new Vector2(Random.Range(-43 - spawn_offset, -43 + 1 + spawn_offset), Random.Range(-15 - spawn_offset, -15 + 1 + spawn_offset));
        quadrant5 = new Vector2(Random.Range(-32 - spawn_offset, -32 + 1 + spawn_offset), Random.Range(-24 - spawn_offset, -24 + 1 + spawn_offset));

        // right side top to bottom
        quadrant6 = new Vector2(Random.Range(26 - spawn_offset, 26 + 1 + spawn_offset), Random.Range(23 - spawn_offset, 23 + 1 + spawn_offset));
        quadrant7 = new Vector2(Random.Range(42 - spawn_offset, 42 + 1 + spawn_offset), Random.Range(17 - spawn_offset, 17 + 1 + spawn_offset));
        quadrant8 = new Vector2(Random.Range(42 - spawn_offset, 42 + 1 + spawn_offset), Random.Range(0 - spawn_offset, 0 + 1 + spawn_offset));
        quadrant9 = new Vector2(Random.Range(44 - spawn_offset, 44 + 1 + spawn_offset), Random.Range(-15 - spawn_offset, -15 + 1 + spawn_offset));
        quadrant10 = new Vector2(Random.Range(31 - spawn_offset, 31 + 1 + spawn_offset), Random.Range(-25 - spawn_offset, -25 + 1 + spawn_offset));



        // --- Inner circle quadrant spawns (x,y) ---
        // left side top to bottom
        quadrant11 = new Vector2(Random.Range(-14 - spawn_offset, -14 + 1 + spawn_offset), Random.Range(23 - spawn_offset, 23 + 1 + spawn_offset));
        quadrant12 = new Vector2(Random.Range(-26 - spawn_offset, -26 + 1 + spawn_offset), Random.Range(11 - spawn_offset, 11 + 1 + spawn_offset));
        quadrant13 = new Vector2(Random.Range(-28 - spawn_offset, -28 + 1 + spawn_offset), Random.Range(-7 - spawn_offset, -7 + 1 + spawn_offset));
        quadrant14 = new Vector2(Random.Range(-13 - spawn_offset, -13 + 1 + spawn_offset), Random.Range(-21 - spawn_offset, -21 + 1 + spawn_offset));

        // right side top to bottom
        quadrant15 = new Vector2(Random.Range(9 - spawn_offset, 9 + 1 + spawn_offset), Random.Range(23 - spawn_offset, 23 + 1 + spawn_offset));
        quadrant16 = new Vector2(Random.Range(24 - spawn_offset, 24 + 1 + spawn_offset), Random.Range(5 - spawn_offset, 5 + 1 + spawn_offset));
        quadrant17 = new Vector2(Random.Range(25 - spawn_offset, 25 + 1 + spawn_offset), Random.Range(-13 - spawn_offset, -13 + 1 + spawn_offset));
        quadrant18 = new Vector2(Random.Range(7 - spawn_offset, 7 + 1 + spawn_offset), Random.Range(-20 - spawn_offset, -20 + 1 + spawn_offset));
    }


    void InstantiateAsteroidGameObjects()
    {
        ast1 = Instantiate(Meteor1Prefab, quadrant1, Quaternion.identity);
        ast2 = Instantiate(Meteor3Prefab, quadrant2, Quaternion.identity);
        ast3 = Instantiate(Meteor2Prefab, quadrant3, Quaternion.identity);
        ast4 = Instantiate(Meteor3Prefab, quadrant4, Quaternion.identity);
        ast5 = Instantiate(Meteor2Prefab, quadrant5, Quaternion.identity);
        ast6 = Instantiate(Meteor1Prefab, quadrant6, Quaternion.identity);
        ast7 = Instantiate(Meteor2Prefab, quadrant7, Quaternion.identity);
        ast8 = Instantiate(Meteor1Prefab, quadrant8, Quaternion.identity);
        ast9 = Instantiate(Meteor3Prefab, quadrant9, Quaternion.identity);
        ast10 = Instantiate(Meteor1Prefab, quadrant10, Quaternion.identity);
        ast11 = Instantiate(Meteor2Prefab, quadrant11, Quaternion.identity);
        ast12 = Instantiate(Meteor1Prefab, quadrant12, Quaternion.identity);
        ast13 = Instantiate(Meteor3Prefab, quadrant13, Quaternion.identity);
        ast14 = Instantiate(Meteor1Prefab, quadrant14, Quaternion.identity);
        ast15 = Instantiate(Meteor2Prefab, quadrant15, Quaternion.identity);
        ast16 = Instantiate(Meteor1Prefab, quadrant16, Quaternion.identity);
        ast17 = Instantiate(Meteor3Prefab, quadrant17, Quaternion.identity);
        ast18 = Instantiate(Meteor1Prefab, quadrant18, Quaternion.identity);
    }


    void InstantiateAsteroidObjects()
    {
        // make sure instantiate the velocity related values here, before
        // passing to the instantiation function
        this.x_drift = 0.05f; this.y_drift = 0.05f; this.ast_rotation = 0.05f;

        // Final operation to get all asteroids completed and spawned onto the screen
        asteroid1 = ast1.GetComponent<AsteroidObject>();
        if(asteroid1 != null)
        {
            asteroid1.Initialize(quadrant1, x_drift, y_drift, ast_rotation);
            asteroid1.tag = "Asteroid";
            asteroid1.name = "Asteroid1";
        }

        asteroid2 = ast2.GetComponent<AsteroidObject>();
        if (asteroid2 != null)
        {
            asteroid2.Initialize(quadrant2, x_drift, y_drift, ast_rotation);
            asteroid2.tag = "Asteroid";
            asteroid2.name = "Asteroid2";
        }

        asteroid3 = ast3.GetComponent<AsteroidObject>();
        if (asteroid3 != null)
        {
            asteroid3.Initialize(quadrant3, x_drift, y_drift, ast_rotation);
            asteroid3.tag = "Asteroid";
            asteroid3.name = "Asteroid3";
        }

        asteroid4 = ast4.GetComponent<AsteroidObject>();
        if (asteroid4 != null)
        {
            asteroid4.Initialize(quadrant4, x_drift, y_drift, ast_rotation);
            asteroid4.tag = "Asteroid";
            asteroid4.name = "Asteroid4";
        }

        asteroid5 = ast5.GetComponent<AsteroidObject>();
        if (asteroid5 != null)
        {
            asteroid5.Initialize(quadrant5, x_drift, y_drift, ast_rotation);
            asteroid5.tag = "Asteroid";
            asteroid5.name = "Asteroid5";
        }

        asteroid6 = ast6.GetComponent<AsteroidObject>();
        if (asteroid6 != null)
        {
            asteroid6.Initialize(quadrant6, x_drift, y_drift, ast_rotation);
            asteroid6.tag = "Asteroid";
            asteroid6.name = "Asteroid6";
        }

        asteroid7 = ast7.GetComponent<AsteroidObject>();
        if (asteroid7 != null)
        {
            asteroid7.Initialize(quadrant7, x_drift, y_drift, ast_rotation);
            asteroid7.tag = "Asteroid";
            asteroid7.name = "Asteroid7";
        }

        asteroid8 = ast8.GetComponent<AsteroidObject>();
        if (asteroid8 != null)
        {
            asteroid8.Initialize(quadrant8, x_drift, y_drift, ast_rotation);
            asteroid8.tag = "Asteroid";
            asteroid8.name = "Asteroid8";
        }

        asteroid9 = ast9.GetComponent<AsteroidObject>();
        if (asteroid9 != null)
        {
            asteroid9.Initialize(quadrant9, x_drift, y_drift, ast_rotation);
            asteroid9.tag = "Asteroid";
            asteroid9.name = "Asteroid9";
        }

        asteroid10 = ast10.GetComponent<AsteroidObject>();
        if (asteroid10 != null)
        {
            asteroid10.Initialize(quadrant10, x_drift, y_drift, ast_rotation);
            asteroid10.tag = "Asteroid";
            asteroid10.name = "Asteroid10";
        }

        asteroid11 = ast11.GetComponent<AsteroidObject>();
        if (asteroid11 != null)
        {
            asteroid11.Initialize(quadrant11, x_drift, y_drift, ast_rotation);
            asteroid11.tag = "Asteroid";
            asteroid11.name = "Asteroid11";
        }

        asteroid12 = ast12.GetComponent<AsteroidObject>();
        if (asteroid12 != null)
        {
            asteroid12.Initialize(quadrant12, x_drift, y_drift, ast_rotation);
            asteroid12.tag = "Asteroid";
            asteroid12.name = "Asteroid12";
        }

        asteroid13 = ast13.GetComponent<AsteroidObject>();
        if (asteroid13 != null)
        {
            asteroid13.Initialize(quadrant13, x_drift, y_drift, ast_rotation);
            asteroid13.tag = "Asteroid";
            asteroid13.name = "Asteroid13";
        }

        asteroid14 = ast14.GetComponent<AsteroidObject>();
        if (asteroid14 != null)
        {
            asteroid14.Initialize(quadrant14, x_drift, y_drift, ast_rotation);
            asteroid14.tag = "Asteroid";
            asteroid14.name = "Asteroid14";
        }

        asteroid15 = ast15.GetComponent<AsteroidObject>();
        if (asteroid15 != null)
        {
            asteroid15.Initialize(quadrant15, x_drift, y_drift, ast_rotation);
            asteroid15.tag = "Asteroid";
            asteroid15.name = "Asteroid15";
        }

        asteroid16 = ast16.GetComponent<AsteroidObject>();
        if (asteroid16 != null)
        {
            asteroid16.Initialize(quadrant16, x_drift, y_drift, ast_rotation);
            asteroid16.tag = "Asteroid";
            asteroid16.name = "Asteroid16";
        }

        asteroid17 = ast17.GetComponent<AsteroidObject>();
        if (asteroid17 != null)
        {
            asteroid17.Initialize(quadrant17, x_drift, y_drift, ast_rotation);
            asteroid17.tag = "Asteroid";
            asteroid17.name = "Asteroid17";
        }

        asteroid18 = ast18.GetComponent<AsteroidObject>();
        if (asteroid18 != null)
        {
            asteroid18.Initialize(quadrant18, x_drift, y_drift, ast_rotation);
            asteroid18.tag = "Asteroid";
            asteroid18.name = "Asteroid18";
        }
    }

    public void RespawnAsteroids(){
        
        // get new semi-random positions
        RandomizeQuadrants();

        // update the positions of all the asteroids
        asteroid1.ResetPosition(quadrant1);
        asteroid2.ResetPosition(quadrant2);
        asteroid3.ResetPosition(quadrant3);
        asteroid4.ResetPosition(quadrant4);
        asteroid5.ResetPosition(quadrant5);
        asteroid6.ResetPosition(quadrant6);
        asteroid7.ResetPosition(quadrant7);
        asteroid8.ResetPosition(quadrant8);
        asteroid9.ResetPosition(quadrant9);
        asteroid10.ResetPosition(quadrant10);
        asteroid11.ResetPosition(quadrant11);
        asteroid12.ResetPosition(quadrant12);
        asteroid13.ResetPosition(quadrant13);
        asteroid14.ResetPosition(quadrant14);
        asteroid15.ResetPosition(quadrant15);
        asteroid16.ResetPosition(quadrant16);
        asteroid17.ResetPosition(quadrant17);
        asteroid18.ResetPosition(quadrant18);
    }
}
