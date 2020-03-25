using UnityEngine;

[CreateAssetMenu(menuName = "Ability/" + nameof(AttackAbility))]
public class AttackAbility : BaseAbility
{
	[Header("Attack Ability")]
	[SerializeField]
	private int damage = 0;

	public int Damage => damage;

	public override void UseAbility(Character caster)
	{
		if (TargetType != TargetType.Target)
		{
			throw new System.NotSupportedException();
		}

		if (!caster.HasTarget)
		{
			Debug.Log(caster.gameObject.name + " doesn't have a target!");
			return;
		}

		var healthComponent = caster.Target.GetCharacterComponent<Health>();
		if (healthComponent != null)
		{
			if (InRange(caster, caster.Target))
			{
				healthComponent.TakeDamage(damage);
			}
			else
			{
				Debug.Log("Target is out of range!");
			}
		}
		else
		{
			Debug.LogWarning("Health component not found on " + caster.Target.gameObject.name);
		}
	}
}