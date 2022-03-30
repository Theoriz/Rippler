using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Augmenta;

public class AugmentaVideoOutputSizeBinder : MonoBehaviour
{
    public AugmentaVideoOutput augmentaVideoOutput;
    public Transform ripplesQuadTransform;
    public RipplesComputeController ripplesController;
    [Range(0, 2)] public float ripplesTextureSizeMultiplier = 1;

    // Update is called once per frame
    void Update()
    {
        UpdateRipplesController();
        UpdateRipplesQuad();
    }

    void UpdateRipplesController() {

        ripplesController.textureSize.x = Mathf.CeilToInt(augmentaVideoOutput.videoOutputSizeInPixels.x * ripplesTextureSizeMultiplier);
        ripplesController.textureSize.y = Mathf.CeilToInt(augmentaVideoOutput.videoOutputSizeInPixels.y * ripplesTextureSizeMultiplier);
    }

    void UpdateRipplesQuad() {

        ripplesQuadTransform.localPosition = new Vector3(augmentaVideoOutput.botLeftCorner.x + augmentaVideoOutput.videoOutputSizeInMeters.x * 0.5f,
                                      transform.localPosition.y,
                                      augmentaVideoOutput.botLeftCorner.z + augmentaVideoOutput.videoOutputSizeInMeters.y * 0.5f);
        ripplesQuadTransform.localScale = new Vector3(augmentaVideoOutput.videoOutputSizeInMeters.x, augmentaVideoOutput.videoOutputSizeInMeters.y, 1);
    }
}
