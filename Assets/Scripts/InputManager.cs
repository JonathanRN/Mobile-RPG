using System.Linq;
using UnityEngine;

public static class InputManager
{
	public static bool IsInputDown()
	{
		return Input.GetMouseButtonDown(0) || Input.touches.Count(x => x.phase == TouchPhase.Began) > 0;
	}

	public static bool Raycast(out RaycastHit hit, LayerMask mask, Camera cam)
	{
#if !UNITY_EDITOR
		Touch touch = Input.touches.Where(x => x.phase == TouchPhase.Began).FirstOrDefault();
		Ray ray = cam.ScreenPointToRay(touch.position);
#else
		Ray ray = cam.ScreenPointToRay(Input.mousePosition);
#endif
		return Physics.Raycast(ray, out hit, 100f, mask);
	}
}