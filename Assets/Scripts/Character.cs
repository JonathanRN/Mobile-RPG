using System;
using UnityEngine;

public class Character : MonoBehaviour
{
	[Header("Stats")]
	[SerializeField]
	private CharacterStat maxHealthPoints = null;

	[SerializeField]
	private bool canBeTargeted = true;

	public int HealthPoints { get; private set; }
	public bool CanBeTargeted => canBeTargeted;
	public bool HasTarget => Target != null;

	public Character Target { get; private set; }

	public event Action<Character> OnTargetSet;

	private void Start()
	{
		HealthPoints = (int)maxHealthPoints.Value;
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

	public void TakeDamage(int amount)
	{
		HealthPoints -= amount;
		print($"{gameObject.name} took {amount} damage.");
		if (HealthPoints <= 0)
		{
			Die();
		}
	}

	public void Heal(int amount)
	{
		HealthPoints += amount;
		print($"{gameObject.name} healed for {amount}.");
		if (HealthPoints > (int)maxHealthPoints.Value)
		{
			HealthPoints = (int)maxHealthPoints.Value;
		}
	}

	private void Die()
	{
		Destroy(gameObject);
		print(gameObject.name + " died!");
	}
}