using UnityEngine;

public class CharacterTargeter : CharacterComponent
{
	[SerializeField]
	private LayerMask layerMask = 0;

	private Camera mainCamera;

	private void Awake()
	{
		mainCamera = Camera.main;
	}

	private void Update()
	{
		if (InputManager.IsInputDown())
		{
			if (InputManager.Raycast(out RaycastHit hit, layerMask, mainCamera))
			{
				Character target = hit.collider.GetComponent<Character>();
				if (target != null)
				{
					Character.SetTarget(target);
				}
			}
		}
	}
}
