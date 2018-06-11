using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScale : MonoBehaviour {

	public Transform ObjectForScale;
	public Transform ObjectAfterScale;

	public Transform ObjectFoScaleInverse;
	public Transform ObjectAfterScaleInverse;

	public Vector3 Translation;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () 
	{
		Matrix4x4 m = Matrix4x4.Scale(Translation);
		ObjectAfterScale.position = m.MultiplyPoint(ObjectForScale.position);
		Matrix4x4 mInv = m.inverse;
		// 如果ObjectForRotationInverse和ObjectAfterRotation是通一个物体，这边测试结果可以看出ObjectAfterRotationInverse的位置和ObjectForRotation的位置是一样的
		// 如果ObjectForRotationInverse和ObjectForRotation是通一个物体，这边测试结果可以看出ObjectAfterRotationInverse的运动方向和ObjectAfterRotation运动方向是相反的
		ObjectAfterScaleInverse.position = mInv.MultiplyPoint(ObjectFoScaleInverse.position);
	}
}
