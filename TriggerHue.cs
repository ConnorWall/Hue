using UnityEngine;

public class TriggerHue : MonoBehaviour
{

	public static bool isHue;

	public ColorChanger change;
	// Destroy everything that enters the trigger
	void OnTriggerEnter(Collider other)
	{
		Debug.Log ("Hit hue!!");

		isHue = true;
		//change
	}

}

