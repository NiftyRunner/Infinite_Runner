using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    public static float rightSide = 4f;
    public static float leftSide = -4f;

    [SerializeField] float internalRightSide;
    [SerializeField] float internalLeftSide;

    void Update()
    {
        internalRightSide = rightSide;
        internalLeftSide = leftSide;
    }
}
