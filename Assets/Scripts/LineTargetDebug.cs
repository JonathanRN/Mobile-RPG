using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class LineTargetDebug : CharacterComponent
{
	private LineRenderer lineRenderer;

	private void Awake()
	{
		lineRenderer = GetComponent<LineRenderer>();
	}

	private void Update()
	{
		lineRenderer.positionCount = Character.HasTarget ? 2 : 0;
		if (Character.HasTarget)
		{
			lineRenderer.SetPositions(new Vector3[] { transform.position, Character.Target.transform.position });
		}
	}
}