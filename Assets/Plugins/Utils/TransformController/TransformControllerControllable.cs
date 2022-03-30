using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformControllerControllable : Controllable
{
	[OSCProperty] public Vector3 position;
	[OSCProperty] public Vector3 rotation;
	[OSCProperty] public Vector3 scale;
}
