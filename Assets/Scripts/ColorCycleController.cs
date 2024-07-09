using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCycleController : MonoBehaviour
{

    public Color[] colors;
    public float transitionSpeed = 1.0f;

    private Camera mainCamera;
    private int currentIndex = 0;
    private Color currentColor;
    private Color targetColor;

    void Start()
    {
        mainCamera = Camera.main;
        currentColor = colors[0];
        targetColor = colors[1];
    }

    // Update is called once per frame
    void Update()
    {
        //Smoothly transition between colors
        currentColor = Color.Lerp(currentColor, targetColor, Time.deltaTime * transitionSpeed);
        mainCamera.backgroundColor = currentColor;

        //If current color is close to the target color, switch to the next color
        if(Vector4.Distance(currentColor, targetColor) < 0.01f) {
            currentIndex = (currentIndex + 1) % colors.Length;
            targetColor = colors[currentIndex];
        }
    }
}
