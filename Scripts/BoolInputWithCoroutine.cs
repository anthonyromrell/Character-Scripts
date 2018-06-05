using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "BoolInputWithCoroutine", menuName = "Player/Inputs/BoolInputWithCoroutine")]
public class BoolInputWithCoroutine : BoolInput 
{

	public float floatReturn;
	
	IEnumerator StopJumpForce()
	{
		while (FloatValue > 0)
		{
			FloatValue--;
			yield return new WaitForFixedUpdate();
		}
	}

	void JumpCharacter()
	{
		FloatValue = floatReturn;
		Coroutines.Instance.StartCoroutine(StopJumpForce());
		Debug.Log(Coroutines.Instance);
	}	
	
	
	public override float SetFloat()
	{
		if (Input.GetButton(InputName))
		{
			JumpCharacter();
			return FloatValue;
		} else
			return 0;
	}
}