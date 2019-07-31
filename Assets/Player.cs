using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

    [Tooltip("In ms^-1")][SerializeField] float xSpeed = 40f;
    [SerializeField] float xRange = 13f;

    [SerializeField] float positionPitchFactor = -2f;
    [SerializeField] float positionYawFactor = 2f;
    [SerializeField] float movingPitchFactor = -10f;
    [SerializeField] float movingRollFactor = -20f;

    float HorizontalThrow, VerticalThrow;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        PositionControl();
        RotationControl();
    }

    private void PositionControl()
    {
        HorizontalThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        // print(HorizontalThrow);
        VerticalThrow = CrossPlatformInputManager.GetAxis("Vertical");

        float xoffset = Time.deltaTime * HorizontalThrow * xSpeed;
        // print(xoffset);
        float yoffset = Time.deltaTime * VerticalThrow * xSpeed;
        // print(xoffset);
        float rawNewXPos = transform.localPosition.x + xoffset;
        float rawNewYPos = transform.localPosition.y + yoffset;

        transform.localPosition = new Vector3(Mathf.Clamp(rawNewXPos, -xRange, xRange), Mathf.Clamp(rawNewYPos, -8, 9), transform.localPosition.z);
    }
    private void RotationControl()
    {
        float pitch = (transform.localPosition.y * positionPitchFactor + VerticalThrow * movingPitchFactor);
        float yaw= (transform.localPosition.x * positionYawFactor);
        float roll= HorizontalThrow * movingRollFactor;

        transform.localRotation = Quaternion.Euler(pitch, yaw, roll);
    }
}
