using Augmenta;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AugmentaVideoOutputFusionNDIControllable : Controllable
{
	[OSCProperty] public bool showFusionNdi;
	[OSCProperty] public bool autoFindFusionNdi;
	[OSCProperty] public string fusionNdiName;

	public override void OnUiValueChanged(string name) {
		base.OnUiValueChanged(name);

		(TargetScript as AugmentaVideoOutputFusionNDI).InitializeNdi();
	}
}
