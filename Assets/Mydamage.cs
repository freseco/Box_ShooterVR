using UnityEngine;
using System.Collections;

public class Mydamage : MonoBehaviour
{

    void OnCollisionEnter(Collision newCollision)
    {
        // only do stuff if hit by a projectile
        if (newCollision.gameObject.tag == "Monster")
        {

            if (newCollision.gameObject.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Attack"))
            {
                AudioSource audio = GetComponent<AudioSource>();
                audio.Play();
            }
        }
    }
}
