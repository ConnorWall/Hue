using UnityEngine;

public class TriggerGreen : MonoBehaviour
{

	public ColorChanger change;
	// Destroy everything that enters the trigger
	void OnTriggerEnter(Collider other)
	{
		Debug.Log ("Hit green!!");

		change.changeGreen();
	}

}

