using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float rotateSpeed = 150.0f;
	public float movementSpeed = 3.0f;
	void Update()
	{
		//Forward Backward Move
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * rotateSpeed;
		//Rotate 
		var z = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;

		transform.Rotate(0, x, 0);
		transform.Translate(0, 0, z);
	}
}