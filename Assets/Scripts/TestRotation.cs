using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TestRotation : MonoBehaviour {

	public Transform ObjectForRotation;
	public Transform ObjectAfterRotation;

	public Transform ObjectForRotationInverse;
	public Transform ObjectAfterRotationInverse;

	public Vector3 Rotation;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () 
	{
		Matrix4x4 m = Matrix4x4.Rotate(Quaternion.Euler(Rotation));
		ObjectAfterRotation.position = m.MultiplyPoint(ObjectForRotation.position);
		Matrix4x4 mInv = m.inverse;
		// 如果ObjectForRotationInverse和ObjectAfterRotation是通一个物体，这边测试结果可以看出ObjectAfterRotationInverse的位置和ObjectForRotation的位置是一样的
		// 如果ObjectForRotationInverse和ObjectForRotation是通一个物体，这边测试结果可以看出ObjectAfterRotationInverse的运动方向和ObjectAfterRotation运动方向是相反的
		ObjectAfterRotationInverse.position = mInv.MultiplyPoint(ObjectForRotationInverse.position);
	}
}
