using UnityEngine;
using System.Collections;

public class TargetExit2 : MonoBehaviour
{
    
    private float exitAnimationSeconds = 6f; // should be >= time of the exit animation

    private bool startDestroy = false;
    


    private int shooting = 2;

    // Use this for initialization
    void Start()
    {
        shooting = Random.Range(1, 3);

    }

    // Update is called once per frame
    void Update()
    {
         if (startDestroy)
            {
                // set startDestroy to true so this code will not run a second time
                startDestroy = false;

                // trigger the Animator to make the "Exit" transition
                this.GetComponent<Animator>().SetTrigger("Death");

                // Call KillTarget function after exitAnimationSeconds to give time for animation to play
                Invoke("KillTarget", exitAnimationSeconds);
            }
        
    }

    // destroy the gameObject when called
    void KillTarget()
    {
        // remove the gameObject
        Destroy(gameObject);
    }

    // respond on collisions
    void OnCollisionEnter(Collision newCollision)
    {
        // only do stuff if hit by a projectile
        if (newCollision.gameObject.tag == "Projectile")
        {
            Destroy(newCollision.gameObject);
            shooting--;

            if (shooting==0)
            {
                startDestroy = true;
                GetComponent<Chaser2>().Stopwalking();
            }
            else
            {
                // trigger the Animator to make the "Exit" transition
                this.GetComponent<Animator>().SetTrigger("Damage");
            }

        }
    }
}
