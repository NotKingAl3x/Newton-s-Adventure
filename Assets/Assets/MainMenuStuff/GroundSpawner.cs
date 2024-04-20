using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject terrain;
    public Transform transforms;

    void Start()
    {
        Spawn();
    }

    public void Spawn()
    {
        Instantiate(terrain, transform.position, transforms.rotation);
    }
}
