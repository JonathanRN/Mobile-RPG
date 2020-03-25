using System.Collections;
using UnityEngine;

public abstract class BaseAbility : ScriptableObject
{
#pragma warning disable 0649
	[Header("Base Ability")]
	[SerializeField]
	private new string name;

	[SerializeField]
	private float cooldown;

	[SerializeField]
	private float range;

	[SerializeField]
	private TargetType targetType;
#pragma warning restore 0649

	public string Name => name;
	public float Cooldown => cooldown;
	public float Range => range;
	public TargetType TargetType => targetType;

	public bool IsReady { get; private set; }

	protected bool InRange(Character source, Character destination)
	{
		return Vector3.Distance(source.transform.position, destination.transform.position) <= Range;
	}

	public virtual void UseAbility(Character caster)
	{

	}
}

public enum TargetType
{
	Self,
	Target
}