using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Augmenta;
using System;

public class AugmentaManagerControllable : Controllable
{

	[Header("OSC Input")]
	[OSCProperty] public int inputPort;
	[OSCProperty(isInteractible = false)] public bool portBinded;
	[OSCProperty(isInteractible = false)] public bool receivingData;
	[OSCProperty] public bool mute;
	[OSCProperty(TargetList = "protocolVersions")]
	public string currentProtocolVersion;

	[Header("Scene Settings")]
	[OSCProperty] public float scaling;
	[OSCProperty] public bool flipX;
	[OSCProperty] public bool flipY;

	[Header("Object Settings")]
	[OSCProperty] public float augmentaObjectTimeOut = 1.0f; // seconds
	[OSCProperty(TargetList = "desiredObjectTypes")]	
	public string currentDesiredObjectType;
	[OSCProperty] public int desiredAugmentaObjectCount = 1;
	[OSCProperty] public float velocitySmoothing;
	[OSCProperty] public float positionOffsetFromVelocity;

	[Header("Debug")]
	[OSCProperty] public bool showSceneDebug;
	[OSCProperty] public bool showObjectDebug;

	public List<string> desiredObjectTypes;
	public List<string> protocolVersions;

	public override void Awake() {
		currentDesiredObjectType = ((AugmentaManager)TargetScript).desiredAugmentaObjectType.ToString();
		desiredObjectTypes.Add(DesiredAugmentaObjectType.All.ToString());
		desiredObjectTypes.Add(DesiredAugmentaObjectType.Oldest.ToString());
		desiredObjectTypes.Add(DesiredAugmentaObjectType.Newest.ToString());

		currentProtocolVersion = ((AugmentaManager)TargetScript).protocolVersion.ToString();
		protocolVersions.Add(AugmentaProtocolVersion.V1.ToString());
		protocolVersions.Add(AugmentaProtocolVersion.V2.ToString());

		base.Awake();
	}

	public override void OnUiValueChanged(string name) {
		base.OnUiValueChanged(name);

		((AugmentaManager)TargetScript).ShowDebug(showSceneDebug, showObjectDebug);
		((AugmentaManager)TargetScript).desiredAugmentaObjectType = (DesiredAugmentaObjectType)Enum.Parse(typeof(DesiredAugmentaObjectType), currentDesiredObjectType);
		((AugmentaManager)TargetScript).protocolVersion = (AugmentaProtocolVersion)Enum.Parse(typeof(AugmentaProtocolVersion), currentProtocolVersion);
	}

	public override void OnScriptValueChanged(string name) {
		base.OnScriptValueChanged(name);

		currentDesiredObjectType = ((AugmentaManager)TargetScript).desiredAugmentaObjectType.ToString();
		currentProtocolVersion = ((AugmentaManager)TargetScript).protocolVersion.ToString();
	}
}
