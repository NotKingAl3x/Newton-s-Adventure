using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuBackground : MonoBehaviour
{
    [Range(-1f,1f)]
    private float BackroundSpeed = 0.1f;
    private float offset;
    private Material Mat;

    void Start()
    {
        Mat = GetComponent<Renderer>().material;
    }

    void Update()
    {
        offset += (Time.deltaTime * BackroundSpeed) / 10f;
        Mat.SetTextureOffset("_MainTex", new Vector2(offset, 0));
        
    }
}
