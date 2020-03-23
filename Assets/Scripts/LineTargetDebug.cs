using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class LineTargetDebug : MonoBehaviour
{
	[SerializeField]
	private Character player = null;

	private LineRenderer lineRenderer;

	private void Awake()
	{
		lineRenderer = GetComponent<LineRenderer>();
	}

	private void Update()
	{
		lineRenderer.positionCount = player.HasTarget ? 2 : 0;
		if (player.HasTarget)
		{
			lineRenderer.SetPositions(new Vector3[] { transform.position, player.Target.transform.position });
		}
	}
}