using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Augmenta;

public class AugmentaVideoOutputSizeBinderControllable : Controllable
{
    [OSCProperty] [Range(0, 2)] public float ripplesTextureSizeMultiplier;
}
