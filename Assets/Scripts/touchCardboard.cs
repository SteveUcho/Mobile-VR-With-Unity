using UnityEngine;
using System.Collections;

public class touchCardboard : MonoBehaviour {
	
	public GameObject building;
	public Transform center;
	public Vector3 axis = Vector3.up;
	public Vector3 desiredPosition;
	public float radius = 190.0f;
	float radiusSpeed = .5f;
	float rotationSpeed = 20.0f;
	public int count = 0;
	public bool test = false;

	void Start () {
		
	}

	void Update()
	{
		if (test == true)
		{
			transform.LookAt (center);
			transform.RotateAround (center.position, axis, rotationSpeed * Time.deltaTime);
			desiredPosition = (transform.position - center.position).normalized * radius + center.position;
			transform.position = Vector3.MoveTowards(transform.position, desiredPosition, Time.deltaTime * radiusSpeed);
		}
	}
}