using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class equations : MonoBehaviour
{
    private float pi = 3.1415f;
    private float radius = 2.5f;
    private float rLength = 1f;
    private float rWidth = 2f;
    private float tHeight = 3f;
    private float tBase = 4f;

    // Use this for initialization
    void Start()
    {
        //find diameter of circle
        float diameter = 2 * radius;

        print("The diameter of the circle with a radius of " + radius + " is " + diameter + ".");
        //find circumference of a circle
        float circ = 2 * pi * radius;
        print("The circumference of the circle with a radius of " + radius + " is " + circ + ".");

        //find area of circle
        float area = pi * (radius * radius);
        print("The area of the circle with a radius of " + radius + " is " + area + ".");

        //perimeter of a rectangle
        float rPerimeter = rLength * 2f + rWidth * 2;
        print("The perimeter of a rectangle with a length of " + rLength + " and a width of " + rWidth + " is " + rPerimeter);

        //Area of a rectangle
        float rArea = rLength * rWidth;
        print("The area of a rectangle with a length of " + rLength + " and a width of " + rWidth + " is " + rArea);

        //Area of a triangle
        float tArea = (tHeight * tBase) / 2f;
        print("The area of a rectangle with a height of " + tHeight + " and a base of " + tBase + " is " + tArea);

    }
}
