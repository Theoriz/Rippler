
public class AugmentaVideoOutputFusionSpoutControllable : Controllable
{
	[OSCProperty] public bool showFusionSpout = false;
	[OSCProperty] public bool autoFindFusionSpout = true;
	[OSCProperty] public string fusionSpoutName = "Augmenta Fusion - Scene";

	public override void OnUiValueChanged(string name) {
		base.OnUiValueChanged(name);

		(TargetScript as AugmentaVideoOutputFusionSpout).InitializeSpout();
	}
}
