using Lowscope.ScriptableObjectUpdater;
using UnityEngine;

public abstract class BaseAbility : ScriptableObject
{
#pragma warning disable 0649
	[Header("Base Ability")]
	[SerializeField]
	private new string name;

	[SerializeField]
	private Sprite icon;

	[SerializeField]
	private float cooldown;

	[SerializeField]
	private float range;

	[SerializeField]
	private TargetType targetType;
#pragma warning restore 0649

	private float cooldownTimer;

	public string Name => name;
	public Sprite Icon => icon;
	public float Cooldown => cooldown;
	public float Range => range;
	public TargetType TargetType => targetType;

	public bool IsReady { get; private set; }
	public float TimerPercent => cooldownTimer / cooldown;

	protected bool InRange(Character source, Character destination)
	{
		return Vector3.Distance(source.transform.position, destination.transform.position) <= Range;
	}

	public virtual void UseAbility(Character caster)
	{
		cooldownTimer = 0;
		IsReady = false;
	}

	// Call every second
	[UpdateScriptableObject(eventType = EEventType.Update)]
	public virtual void CallUpdate()
	{
		if (!IsReady)
		{
			if (cooldownTimer <= Cooldown)
			{
				cooldownTimer += Time.deltaTime;
			}
			else
			{
				IsReady = true;
			}
		}
	}
}

public enum TargetType
{
	Self,
	Target
}