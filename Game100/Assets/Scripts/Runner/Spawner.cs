
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform player;
    public Vector3 offset1;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset1;
    }
}