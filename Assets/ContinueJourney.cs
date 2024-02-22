using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueJourney : MonoBehaviour
{
    public void Continue()
    {
        SceneManager.LoadSceneAsync(1);
    }
}
