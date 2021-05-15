using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySight : MonoBehaviour
{
	// private variables below

	// store references to components on the gameObject
    Transform _transform;
	Rigidbody2D _rigidbody;
    Animator _animator;

    //enemy tracking
    bool isGrounded = false;

    void Awake(){
        // get a reference to the components we are going to be changing and store a reference for efficiency purposes
		_transform = GetComponent<Transform> ();
		
		_rigidbody = GetComponent<Rigidbody2D> ();
		if (_rigidbody==null) // if Rigidbody is missing
			Debug.LogError("Rigidbody2D component missing from this gameobject");
		
		_animator = GetComponent<Animator>();
		if (_animator==null) // if Animator is missing
			Debug.LogError("Animator component missing from this gameobject");
    }

	void OnTriggerEnter2D (Collider2D other)
	{
		if ((other.tag == "Player" ) && (other.gameObject.GetComponent<CharacterController2D>().playerCanMove))
		{
            if(this.gameObject.GetComponent<Enemy>().isStunned== false)
                _animator.SetTrigger("Sight");
		}
	}
}
