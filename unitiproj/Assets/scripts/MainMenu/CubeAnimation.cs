using UnityEngine;
using System.Collections;

public class CubeAnimation : MonoBehaviour
{
	public Vector3 axis = new Vector3( 0, 1, 0 );
	public float degrees = 90f;
	public float timespan = 1f;
	public float delay = 5000f;
	
	private float _rotated = 0;
	private Vector3 _rotationVector;
	private long start = 0;
	

	public void Start()
	{
		axis.Normalize();
		_rotationVector = axis * degrees;
		start = System.DateTime.Now.Ticks;
	}
	
	public void Update()
	{
		//Debug.Log(System.DateTime.Now.Ticks - start); 
		if ((System.DateTime.Now.Ticks - start) > delay * 1000f) {
			//Debug.Log(System.DateTime.Now.Ticks - start);
			_rotated += degrees * (Time.deltaTime / timespan);
			if ( degrees > _rotated )
				transform.Rotate( _rotationVector * (Time.deltaTime / timespan) );
		}
/*
		// reset animation
		if ((System.DateTime.Now.Ticks - start) > (delay + delay+ delay) * 1000L) {
			_rotated = 0;
			start = System.DateTime.Now.Ticks;
			_rotationVector = axis * degrees;
		}
*/
	}
	
}