using UnityEngine;
using UnityEngine.UI;

public class MeleeAttackSlider : MonoBehaviour
{
	[SerializeField]
	private Character player = null;

	[SerializeField]
	private Slider slider = null;

	//private MeleeAutoAttack meleeAutoAttack;

	private void Awake()
	{
		//meleeAutoAttack = player.GetCharacterComponent<MeleeAutoAttack>();
		//if (meleeAutoAttack == null)
		//{
		//	Debug.LogError("Couldn't find " + nameof(MeleeAutoAttack));
		//}
	}

	private void Update()
	{
		//if (meleeAutoAttack != null && meleeAutoAttack.IsAutoAttacking)
		//{
		//	if (!slider.gameObject.activeSelf)
		//	{
		//		slider.gameObject.SetActive(true);
		//	}
		//	slider.value = meleeAutoAttack.TimerPercent;
		//}
		//else
		//{
		//	if (slider.gameObject.activeSelf)
		//	{
		//		slider.gameObject.SetActive(false);
		//	}
		//}
	}
}