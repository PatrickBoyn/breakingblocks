using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

	[SerializeField] private float screenWidthUnits = 16f;
	[SerializeField] private float minValue = 1f;
	[SerializeField] private float maxValue = 15f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthUnits;
		
		var paddlePosition = new Vector2(transform.position.x, transform.position.y);

		paddlePosition.x = Mathf.Clamp(mousePosInUnits, minValue, maxValue);

		transform.position = paddlePosition;
	}
}
