using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RunnerButton : MonoBehaviour
{
   public void PlayGame ()
    {
        SceneManager.LoadScene(1);
    }
}
