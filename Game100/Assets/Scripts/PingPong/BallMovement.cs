using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallMovement : MonoBehaviour
{
    
    [System.Serializable]
    public class Boundary
    {
        public float xMin, xMax, yMin, yMax;
    }
    public Boundary boundary;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector2(17f, 17f);
    }

    bool gameHasEnded = false;
    public float restartDelay = 1f;
    // Update is called once per frame
    void Update()
    {
        if (rb.position.y < -10f)
        { 
          gameHasEnded = true;
          Debug.Log("GAME OVER");
          Invoke("Restart", restartDelay);

        }

    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
