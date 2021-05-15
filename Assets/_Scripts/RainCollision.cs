using System.Collections;
using UnityEngine;

public class RainCollision : MonoBehaviour
{

    public GameObject explosion;

    // if the player touches the coin, it has not already been taken, and the player can move (not dead or victory)
	// then take the coin
	void OnCollisionEnter2D (Collision2D other)
	{
		if ((other.gameObject.tag == "Player" ))
		{

			// if explosion prefab is provide, then instantiate it
			if (explosion)
			{
				Instantiate(explosion,transform.position,transform.rotation);
			}

			// do the player damage
			other.gameObject.GetComponent<CharacterController2D>().ApplyDamage(1);

			// destroy the rain
			DestroyObject(this.gameObject);
		}
        else if((other.gameObject.tag == "Ground") || (other.gameObject.tag == "Platform") || (other.gameObject.tag == "Enemy") || (other.gameObject.tag == "Decor"))
		{
            // if explosion prefab is provide, then instantiate it
			if (explosion)
			{
				Instantiate(explosion,transform.position,transform.rotation);
			}

            // destroy the rain
			DestroyObject(this.gameObject);
        }
	}
}
