using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public Color[] colors;
    public Renderer cubeRenderer;
    public int randomColorIndex;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SetRandomColor), 0,2.5f);
    }

    // Update is called once per frame
    void SetRandomColor()
    {
        randomColorIndex = Random.Range(0, colors.Length);
        cubeRenderer.material.color = colors[randomColorIndex];
    }
}
