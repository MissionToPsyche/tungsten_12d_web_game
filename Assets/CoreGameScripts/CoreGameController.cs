using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;



public class CoreGameController : MonoBehaviour
{
    /*
        Items managing the game state
    */
    private enum GameState {Playing, Paused, GameOver}
    private GameState currentState;

    /*
        Linking all asset scripts that are managed by the core game controller
        
        important to note: spawner already handles and controls asteroid object, hence
        why we don't include a direct link to all asteroid objects here
        
        Also: Since asteroidSpawner and CoreShip implement the start function
        we don't need to worry about instantiating the objects in the core game script
        unity kind of takes care of all that part for us.
        
        !!! If they do not implement the start then it is likely you will need to handle that here,
        but don't do much computation here since we want to encourage modularity of each game object !!!
    */
    public AsteroidSpawner asteroidSpawner;
    public CoreShipObject spaceship;


    // Start is called before the first frame update
    void Start()
    {
        // start of the game
        currentState = GameState.Playing;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    /*
        Core functions guiding Rounds of the main game.
        New Round Condition 1: the spaceship hits an asteroid
        New Round Condition 2: the spaceship goes out of bounds
        
        important to understand these are event triggered and called in the
        CoreShipObject.cs
    */
    public void OnSpaceshipHitAsteroid(){

        // Currently test code to just start a new round, prove functionality works
        asteroidSpawner.RespawnAsteroids();
        spaceship.ResetSpaceship();
    }
    public void OnSpaceshipOutOfBounds(){
        
        // Currently test code to just start a new round, prove functionality works
        asteroidSpawner.RespawnAsteroids();
        spaceship.ResetSpaceship();
    }
}
