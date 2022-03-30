using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AugmentaVideoOutputControllable : Controllable
{
    [OSCProperty] public Color paddingColor;

    [OSCProperty] public bool autoOutputSizeInPixels;
    [OSCProperty] public bool autoOutputSizeInMeters;
    [OSCProperty] public bool autoOutputOffset;

    [OSCProperty] public Vector2Int videoOutputSizeInPixels;
    [OSCProperty] public Vector2 videoOutputSizeInMeters;
    [OSCProperty] public Vector2 videoOutputOffset;
}
