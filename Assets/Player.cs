using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

    [Tooltip("In ms^-1")][SerializeField] float xSpeed = 40f;
    [SerializeField] float xRange = 13f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        float HorizontalThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        // print(HorizontalThrow);
        float VerticalThrow = CrossPlatformInputManager.GetAxis("Vertical");

        float xoffset = Time.deltaTime * HorizontalThrow *xSpeed;
        // print(xoffset);
        float yoffset = Time.deltaTime * VerticalThrow * xSpeed;
        // print(xoffset);
        float rawNewXPos = transform.localPosition.x + xoffset;
        float rawNewYPos = transform.localPosition.y + yoffset;

        transform.localPosition = new Vector3(Mathf.Clamp(rawNewXPos,-xRange, xRange), Mathf.Clamp(rawNewYPos, -8, 9), transform.localPosition.z);

    }
}
