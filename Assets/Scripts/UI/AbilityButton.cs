using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class AbilityButton : MonoBehaviour
{
	[SerializeField]
	private Character player = null;

	// todo remove this eventually
	[SerializeField]
	private BaseAbility baseAbility = null;

	private BaseAbility ability;
	private Button button;

	private void Awake()
	{
		button = GetComponent<Button>();
		button.onClick.AddListener(OnButtonClick);
	}

	// todo remove this eventually
	private void OnValidate()
	{
		button = GetComponent<Button>();
		SetAbility(baseAbility);
	}

	private void Update()
	{
		button.image.fillAmount = ability.TimerPercent;
	}

	public void OnButtonClick()
	{
		if (ability.IsReady)
		{
			ability.UseAbility(player);
		}
		else
		{
			Debug.Log("Ability isnt ready!");
		}
	}

	public void SetAbility(BaseAbility ability)
	{
		this.ability = ability;
		button.image.sprite = ability.Icon;
	}
}