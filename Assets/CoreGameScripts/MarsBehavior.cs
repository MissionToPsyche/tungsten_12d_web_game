using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarsBehavior : MonoBehaviour
{

    // Allow for adjusting of the rotation in editor
    [SerializeField] private float rotation_speed;

    // Mars object, but don't want it to react physically so no rigidBody
    public Transform mars;

    /*
        Note for later: May need to have some functions in here to reset the 
        Mars position incase 

    */

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // continually update sprite for rotation
        mars.Rotate(0, 0, rotation_speed * Time.deltaTime);
    }
}
