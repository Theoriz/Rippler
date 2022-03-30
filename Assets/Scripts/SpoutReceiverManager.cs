using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Klak.Spout;

public class SpoutReceiverManager : MonoBehaviour
{
    public SpoutReceiver spoutReceiver;

    public string spoutName {
		get { return spoutReceiver.sourceName; }
        set { spoutReceiver.sourceName = value; }
	}

    public Material ripplesMaterial;

	private void Update() {

		BindSpoutToMaterial();
	}

	void BindSpoutToMaterial() {

		if(spoutReceiver.receivedTexture != null)
			ripplesMaterial.SetTexture("_BackgroundTex", spoutReceiver.receivedTexture);
	}
}
