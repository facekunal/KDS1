/* This script is used to detect object on gaze. I have attached Gvr Gaze to the Main Camera.
 * Alternativly, one can use event triggers.
 */
using UnityEngine;
using System.Collections;

public class MyFocus : MonoBehaviour, IGvrGazeResponder {

	[SerializeField]
	private bool autoShoot;
	private bool isShooting=false;

	public void OnGazeEnter(){
		isShooting = true;
	}

	public void OnGazeExit(){
		isShooting = false;
	}

	public void OnGazeTrigger(){
		
	}

	public void Update(){
		if (autoShoot && isShooting) {
			Debug.Log ("shoot...");
			Destroy (gameObject);
		}
	}

}
