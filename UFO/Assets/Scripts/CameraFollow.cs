using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * Se encarga de que la camara siga al Player
 */
public class CameraFollow : MonoBehaviour
{
	public GameObject player;													// Aquí debemos referenciar el Player (desde Unity)

	private Vector3 offset;														// Diferencia entre la posicion de la camara y la del Player
	
	// ==================== START ====================
	void Start()
	{
		offset = (transform.position - player.transform.position);
	}

	// ==================== UPDATE ====================
	void LateUpdate()
	{
		transform.position = (player.transform.position + offset);
	}
}
