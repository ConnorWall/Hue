using UnityEngine;

public class TriggerBlue : MonoBehaviour
{

	public ColorChanger change;
	// Destroy everything that enters the trigger
	void OnTriggerEnter(Collider other)
	{
		Debug.Log ("Hit blue!!");

		change.changeBlue();
	}

}

