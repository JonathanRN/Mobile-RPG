using UnityEngine;

public class PlayerJoystickMovement : MonoBehaviour
{
	[SerializeField]
	private Joystick joystick = null;

	[SerializeField]
	private Rigidbody rbody = null;

	[SerializeField]
	private float speed = 5f;

	private void FixedUpdate()
	{
		Vector2 joystickTranslation = new Vector2(joystick.Horizontal, joystick.Vertical);
		if (joystickTranslation != Vector2.zero)
		{
			Vector3 movement = new Vector3(joystickTranslation.x, 0.0f, joystickTranslation.y);
			rbody.transform.rotation = Quaternion.LookRotation(movement, Vector3.up);
			rbody.velocity = movement * speed;
		}
	}
}