using UnityEngine;
using System.Collections;
using UnityEngine.VR;

public class Shooter : MonoBehaviour {

	// Reference to projectile prefab to shoot
	public GameObject projectile;
	public float power = 10.0f;
	public GameObject FollowObjet;
    public Transform postionfire;
    public GameObject Fire;
	
	// Reference to AudioClip to play
	public AudioClip shootSFX;

	// Update is called once per frame
	void Update () {
		// Detect if fire button is pressed
		if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Jump"))
		{	
			// if projectile is specified
			if (projectile)
			{
				// Instantiante projectile 
				GameObject newProjectile = Instantiate(projectile,
														FollowObjet.transform.position + FollowObjet.transform.forward,
                                                        FollowObjet.transform.rotation) as GameObject;

                GameObject fire = Instantiate(Fire, postionfire.position,
                                                        postionfire.rotation) as GameObject;



                Fire.transform.parent=(transform);

                // Destroy the bullet after 2 seconds
                Destroy(fire, 2.0f);


                // if the projectile does not have a rigidbody component, add one
                if (!newProjectile.GetComponent<Rigidbody>()) 
				{
					newProjectile.AddComponent<Rigidbody>();
				}
				
                // Apply force to the newProjectile's Rigidbody component if it has one
				//newProjectile.GetComponent<Rigidbody>().AddForce(FollowObjet.transform.forward * power, ForceMode.VelocityChange);
                // Add velocity to the bullet
                newProjectile.GetComponent<Rigidbody>().velocity = newProjectile.transform.forward * power;



                // play sound effect if set
                if (shootSFX)
				{
					if (newProjectile.GetComponent<AudioSource> ()) { // the projectile has an AudioSource component
						// play the sound clip through the AudioSource component on the gameobject.
						// note: The audio will travel with the gameobject.
						newProjectile.GetComponent<AudioSource> ().PlayOneShot (shootSFX);
					} else {
						// dynamically create a new gameObject with an AudioSource
						// this automatically destroys itself once the audio is done
						AudioSource.PlayClipAtPoint (shootSFX, newProjectile.transform.position);
					}
				}
			}
		}
	}
}
