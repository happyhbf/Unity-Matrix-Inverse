using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTranslate : MonoBehaviour {

	public Transform ObjectForTranslation;
	public Transform ObjectAfterTranslation;

	public Transform ObjectFoTranslationInverse;
	public Transform ObjectAfterTranslationInverse;

	public Vector3 Translation;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () 
	{
		Matrix4x4 m = Matrix4x4.Translate(Translation);
		ObjectAfterTranslation.position = m.MultiplyPoint(ObjectForTranslation.position);
		Matrix4x4 mInv = m.inverse;
		// 如果ObjectForRotationInverse和ObjectAfterRotation是通一个物体，这边测试结果可以看出ObjectAfterRotationInverse的位置和ObjectForRotation的位置是一样的
		// 如果ObjectForRotationInverse和ObjectForRotation是通一个物体，这边测试结果可以看出ObjectAfterRotationInverse的运动方向和ObjectAfterRotation运动方向是相反的
		ObjectAfterTranslationInverse.position = mInv.MultiplyPoint(ObjectFoTranslationInverse.position);
	}
}
