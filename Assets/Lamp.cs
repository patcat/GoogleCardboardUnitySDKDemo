using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class Lamp : MonoBehaviour {
	public Renderer skybox;
	public Material sky1;
	public Material sky2;
	public Material sky3;
	public Material sky4;
	private int currentSky = 0;
	
	void Start () {
	}
	
	public void rubLamp() {
		GetComponent<ParticleSystem>().Emit(10); 
	}
	
	public void stareAtLamp() {
		switch (currentSky) {
		case 0:
			skybox.material = sky2;
			currentSky++;
			break;
		case 1:
			skybox.material = sky3;
			currentSky++;
			break;
		case 2:
			skybox.material = sky4;
			currentSky++;
			break;
		case 3:
			skybox.material = sky1;
			currentSky = 0;
			break;
		}
	}
}