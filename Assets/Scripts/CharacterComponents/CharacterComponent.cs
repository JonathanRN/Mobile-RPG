using UnityEngine;

public class CharacterComponent : MonoBehaviour
{
	protected Character Character;

	public void RegisterComponent(Character character)
	{
		Character = character;
	}
}