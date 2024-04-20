using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDeleter : MonoBehaviour
{
    private GroundSpawner groundSpawner;
    void Start()
    {
        groundSpawner = FindObjectOfType<GroundSpawner>();
    }
    void Update()
    {
        if (transform.position.x < -44f)
        {
            groundSpawner.Spawn();
            Destroy(gameObject);
        }
    }
}
