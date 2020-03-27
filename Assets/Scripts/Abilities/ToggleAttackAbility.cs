using Lowscope.ScriptableObjectUpdater;
using UnityEngine;

[CreateAssetMenu(menuName = "Ability/" + nameof(ToggleAttackAbility))]
public class ToggleAttackAbility : AttackAbility
{
	[Header(nameof(ToggleAttackAbility))]
	[SerializeField]
	private float timeBetweenAttacks = 0;

	private bool isToggled = false;
	private float timer = 0;
	private Character caster;

	public override void UseAbility(Character caster)
	{
		isToggled = !isToggled;

		if (this.caster == null)
		{
			this.caster = caster;
		}
	}

	[UpdateScriptableObject(eventType = EEventType.Start)]
	public void CallStart()
	{
		isToggled = false;
	}

	public override void CallUpdate()
	{
		base.CallUpdate();

		if (isToggled)
		{
			timer += Time.deltaTime;

			if (timer > timeBetweenAttacks)
			{
				if (!caster.HasTarget)
				{
					isToggled = false;
				}
				base.UseAbility(caster);
				timer = 0;
			}
		}
	}
}