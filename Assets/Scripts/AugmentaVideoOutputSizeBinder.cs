using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Augmenta;

public class AugmentaVideoOutputSizeBinder : MonoBehaviour
{
    public AugmentaVideoOutput augmentaVideoOutput;

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(augmentaVideoOutput.botLeftCorner.x + augmentaVideoOutput.videoOutputSizeInMeters.x * 0.5f,
                                              transform.localPosition.y,
                                              augmentaVideoOutput.botLeftCorner.z + augmentaVideoOutput.videoOutputSizeInMeters.y * 0.5f);
        transform.localScale = new Vector3(augmentaVideoOutput.videoOutputSizeInMeters.x, augmentaVideoOutput.videoOutputSizeInMeters.y, 1);
    }
}
