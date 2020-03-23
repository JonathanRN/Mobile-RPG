using System;
using UnityEngine;

public class Character : MonoBehaviour
{
	[SerializeField]
	private bool canBeTargeted = true;

	public bool CanBeTargeted => canBeTargeted;
	public bool HasTarget => Target != null;

	public Character Target { get; private set; }

	public event Action<Character> OnTargetSet;

	public void SetTarget(Character newTarget)
	{
		if (newTarget != null && newTarget.CanBeTargeted)
		{
			Target = newTarget;
			print($"{gameObject.name} is now targeting {newTarget.name}");
			OnTargetSet?.Invoke(Target);
		}
	}
}