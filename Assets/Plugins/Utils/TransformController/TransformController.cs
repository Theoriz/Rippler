using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformController : MonoBehaviour
{
	public Vector3 position {
		get { return transform.position; }
		set { transform.position = value; }
	}

	public Vector3 rotation {
		get { return transform.rotation.eulerAngles; }
		set { transform.rotation = Quaternion.Euler(value); }
	}

	public Vector3 scale {
		get { return transform.localScale; }
		set { transform.localScale = value; }
	}
}
