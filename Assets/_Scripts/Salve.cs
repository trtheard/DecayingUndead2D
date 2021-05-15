using System.Collections;
using UnityEngine;

public class Salve : MonoBehaviour
{

    public int salveValue = 4;
	public bool taken = false;
	public GameObject explosion;

    
    // if the player touches the salve bottle, it has not already been taken, and the player can move (not dead or victory)
	// then take the salve bottle
	void OnTriggerEnter2D (Collider2D other)
	{
		if ((other.tag == "Player" ) && (!taken) && (other.gameObject.GetComponent<CharacterController2D>().playerCanMove))
		{
			// mark as taken so doesn't get taken multiple times
			taken=true;

			// if explosion prefab is provide, then instantiate it
			if (explosion)
			{
				Instantiate(explosion,transform.position,transform.rotation);
			}

			// do the player collect coin thing
			other.gameObject.GetComponent<CharacterController2D>().CollectSalve(salveValue);

			// destroy the coin
			DestroyObject(this.gameObject);
		}
	}
}
