using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RipplesComputeControllerControllable : Controllable
{
    [OSCProperty] public int updatePerSeconds = 60;
    [OSCProperty] public Vector2 ripplesSize = Vector2.one;
    [OSCProperty] public float ripplesScale = 5.0f;
    [OSCProperty] public float ripplesAttenuation = 0.01f;
    [OSCProperty] public Vector3 ripplesLightDirection = new Vector3(.2f, -.5f, .7f);
    [OSCProperty] public float ripplesSpecular = 10.0f;
    [OSCProperty] public float ripplesSpecularPower = 32.0f;
    [OSCProperty] public float ripplesFrontSpecular = 10.0f;
}
