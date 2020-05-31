using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * Se encarga de mover al Player a través
 * de la informacion obtenida a través del
 * input
 */
public class PlayerController : MonoBehaviour
{
	public float velocity = 5f;														// Permite establecer un multiplicador de velocidad desde Unity
	public Text countText;
	public Text winText;
	
	private Rigidbody2D rb2d;
	private int count;
	
	// ==================== START ====================
	void Start()
	{
		rb2d = GetComponent<Rigidbody2D>();											// Permite acceder al Rigidbody2D
		count = 0;
		SetCountText();
		winText.text = "";
	}

	// ==================== UPDATE ====================
	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");							// Input para movimientos horizontales
		float moveVertical = Input.GetAxis("Vertical");								// Input para movimientos verticales
		
		Vector2 movement = new Vector2(moveHorizontal, moveVertical);
		rb2d.AddForce(movement * velocity);											// Añade las fuerzas de movimiento al Player
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("PickUp"))
		{
			other.gameObject.SetActive(false);										// Destruye los Pickups cuando el Player colisiona con ellos
			count++;																// Contador de Pickups recogidos
			SetCountText();															 // Actualiza el texto del contador
		}
	}

	void SetCountText()
	{
		countText.text = ($"Count: {count.ToString()}");

		if (count >= 8)
		{
			winText.text = "YOU WIN!!!";
		}
	}
}