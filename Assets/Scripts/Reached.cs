using UnityEngine;
using System.Collections;

public class Reached : MonoBehaviour {

    // respond on collisions
    void OnCollisionEnter(Collision newCollision)
    {
        // only do stuff if hit by a projectile
        if (newCollision.gameObject.tag == "Projectile")
        {
            Destroy(newCollision.gameObject);
            Destroy(gameObject);
            
            
        }
    }
}
