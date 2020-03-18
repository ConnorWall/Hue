using UnityEngine;

public class TriggerRed : MonoBehaviour




{

	public ColorChanger change;



	// Destroy everything that enters the trigger
	void OnTriggerEnter(Collider other)
	{
		Debug.Log ("Hit red!!");

		//GameObject mainCam = GameObject.Find ("Main Camera");

		//mainCam.GetComponent<ColorChanger>().changeColor();

		//ColorChanger changetoRed = (ColorChanger) goGetComponent(typeof(ColorChanger));

		change.changeRed();




	}

}

