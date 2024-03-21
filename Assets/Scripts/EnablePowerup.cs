using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnablePowerup : MonoBehaviour
{
    public GameObject test;
    
    public void DoTheThing()
    {
        //this makes the object in question appear visable
        if(test.activeInHierarchy == false)
        {
            test.SetActive(true);
        }
    }
}
