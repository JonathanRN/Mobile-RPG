using UnityEngine;

public class MeleeAutoAttackAbility : AttackAbility
{
	/*public bool IsAutoAttacking { get; private set; }
	private float autoAttackTimer = 0;
	private bool waitingToAttack;

	public float TimerPercent => autoAttackTimer / Cooldown;

	private void Update()
	{
		if (IsAutoAttacking)
		{
			autoAttackTimer += Time.deltaTime;

			if (autoAttackTimer > Cooldown)
			{
				waitingToAttack = true;
				autoAttackTimer = Cooldown;
			}

			if (!Character.HasTarget)
			{
				Stop();
			}

			if (waitingToAttack && Character.IsTargetInRangeFromTarget(Range))
			{
				// Attack
				Character.Target.GetCharacterComponent<Health>().TakeDamage(40);

				waitingToAttack = false;
				autoAttackTimer = 0;
			}
		}

	}

	public void StartAutoAttacking()
	{
		if (!IsAutoAttacking)
		{
			IsAutoAttacking = true;
			waitingToAttack = false;
			autoAttackTimer = 0;
		}
	}

	public void Stop()
	{
		IsAutoAttacking = false;
	}*/
}