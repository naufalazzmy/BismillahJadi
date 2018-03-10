using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float movementSpeed = 150.0f;
	public float rotateSpeed = 3.0f;
	void Update()
	{
		//Forward Backward Move
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;
		//Rotate 
		var z = Input.GetAxis("Vertical") * Time.deltaTime * rotateSpeed;

		transform.Rotate(0, x, 0);
		transform.Translate(0, 0, z);
	}
}