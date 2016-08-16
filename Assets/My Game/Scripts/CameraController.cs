using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;
	private Vector3 q;



	void Start ()
	{
		offset = transform.position - player.transform.position;

	}

	void LateUpdate ()
	{
		transform.position = player.transform.position + offset;
		//player.transform.rotation = transform.rotation;
	}
}