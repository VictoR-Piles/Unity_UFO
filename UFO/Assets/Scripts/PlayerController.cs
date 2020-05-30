using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * Se encarga de mover al Player a través
 * de la informacion obtenida a través del
 * input
 */
public class PlayerController : MonoBehaviour
{
	public float velocity = 5f;														// Permite establecer un multiplicador de velocidad desde Unity

	private Rigidbody2D rb2d;
	
	// ==================== START ====================
	void Start()
	{
		rb2d = GetComponent<Rigidbody2D>();											// Permite acceder al Rigidbody2D
	}

	// ==================== UPDATE ====================
	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");							// Input para movimientos horizontales
		float moveVertical = Input.GetAxis("Vertical");								// Input para movimientos verticales
		
		Vector2 movement = new Vector2(moveHorizontal, moveVertical);
		rb2d.AddForce(movement * velocity);											// Añade las fuerzas de movimiento al Player
	}
}