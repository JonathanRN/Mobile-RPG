using UnityEngine;

public class Health : CharacterComponent
{
	[SerializeField]
	private CharacterStat maxHealthPoints = null;

	public int HealthPoints { get; private set; }

	private void Start()
	{
		HealthPoints = (int)maxHealthPoints.Value;
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
		Destroy(Character.gameObject);
		print(gameObject.name + " died!");
	}
}