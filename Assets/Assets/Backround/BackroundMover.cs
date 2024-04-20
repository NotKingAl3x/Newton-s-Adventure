using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackroundMover : MonoBehaviour
{
    public Transform player;
    [Range(-1f,1f)]
    public float BackroundSpeed = 0.1f;
    private float offset;
    private Material Mat;

    void Start()
    {
        Mat = GetComponent<Renderer>().material;
        
    }

    void Update()
    {
        transform.position = new Vector3 (player.position.x, -0.34f, 1);
        offset += (Time.deltaTime * BackroundSpeed) / 10f;
        Mat.SetTextureOffset("_MainTex", new Vector2(offset, 0));
        
    }
}
