using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class AbilityButton : MonoBehaviour
{
	[SerializeField]
	private Character player = null;

	[SerializeField]
	private BaseAbility ability = null;

	private Button button;

	private void Awake()
	{
		button = GetComponent<Button>();
		button.onClick.AddListener(OnButtonClick);
	}

	public void OnButtonClick()
	{
		ability.UseAbility(player);
	}
}