using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class ColorChanger : MonoBehaviour {

	public PostProcessingProfile post;
	public Transform Player;
	public Camera cam;

	private int i;
	private int timer;


	// Use this for initialization
	void Start () {

		ColorGradingModel.Settings colorSettings = post.colorGrading.settings;
		

		colorSettings.channelMixer.red.x = 1;
		colorSettings.channelMixer.green.y = 1;
		colorSettings.channelMixer.blue.z = 1;
		colorSettings.basic.hueShift = 0;

		post.colorGrading.settings = colorSettings;

		TriggerHue.isHue = true;




	}

	public void Update() {

		//if (isHue == true)
		timer++;

		//Debug.Log (timer);
		//Debug.Log(i);
		changeHue ();

		


	}

	public void changeHue(){




		ColorGradingModel.Settings colorSettings = post.colorGrading.settings;

		if (timer > 1 & TriggerHue.isHue == true)
		{

			//colorSettings.basic.hueShift = i;

				if (Player.position.y > 75){
			colorSettings.basic.hueShift = Player.position.y -75;
				}
				else 
				{
					colorSettings.basic.hueShift =0;
				}


			post.colorGrading.settings = colorSettings;
			cam.farClipPlane  = Player.position.y + 200;
			RenderSettings.fogDensity = .01f - (Player.position.y / 100000);
			//Debug.Log("Hit");
			i++;
			timer = 0;
		}


	}




	// Update is called once per frame
	public void changeRed () {

		ColorGradingModel.Settings colorSettings = post.colorGrading.settings;

		colorSettings.channelMixer.red.x = 2;
		colorSettings.channelMixer.green.y = 1;
		colorSettings.channelMixer.blue.z = 1;

		post.colorGrading.settings = colorSettings;

	}
	public void changeBlue () {

		ColorGradingModel.Settings colorSettings = post.colorGrading.settings;

		colorSettings.channelMixer.blue.z = 2;
		colorSettings.channelMixer.red.x = 1;
		colorSettings.channelMixer.green.y = 1;

		post.colorGrading.settings = colorSettings;

	}
	public void changeGreen () {

		ColorGradingModel.Settings colorSettings = post.colorGrading.settings;

		colorSettings.channelMixer.green.y = 2;
		colorSettings.channelMixer.blue.z = 1;
		colorSettings.channelMixer.red.x = 1;

		post.colorGrading.settings = colorSettings;

	}

	public void reset () {

		ColorGradingModel.Settings colorSettings = post.colorGrading.settings;

		colorSettings.channelMixer.red.x = 1;
		colorSettings.channelMixer.green.y = 1;
		colorSettings.channelMixer.blue.z = 1;
		colorSettings.basic.hueShift = 0;


		post.colorGrading.settings = colorSettings;
		TriggerHue.isHue = false;


	}

}
