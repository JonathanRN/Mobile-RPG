using System;
using UnityEngine;

public class Character : MonoBehaviour
{
	[SerializeField]
	private bool autoGrabComponents = true;

	[SerializeField]
	private CharacterComponent[] components = null;

	[SerializeField]
	private bool canBeTargeted = true;

	public bool CanBeTargeted => canBeTargeted;
	public bool HasTarget => Target != null;

	public Character Target { get; private set; }

	public event Action<Character> OnTargetSet;

	private void Awake()
	{
		// Register all components
		foreach (var component in components)
		{
			component.RegisterComponent(this);
		}
	}

	private void OnValidate()
	{
		if (autoGrabComponents)
		{
			components = GetComponentsInChildren<CharacterComponent>();
		}
	}

	public void SetTarget(Character newTarget)
	{
		if (newTarget != null && newTarget.CanBeTargeted)
		{
			Target = newTarget;
			print($"{gameObject.name} is now targeting {newTarget.name}");
			OnTargetSet?.Invoke(Target);
		}
	}

	public T GetCharacterComponent<T>() where T : CharacterComponent
	{
		foreach (var component in components)
		{
			if (component.GetType().Equals(typeof(T)))
			{
				return (T)component;
			}
		}
		return default;
	}
}