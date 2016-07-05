using UnityEngine;
using System.Collections;

//[RequireComponent(typeof(CharacterController))]

public class Chaser2 : MonoBehaviour
{

    public float speed = 20.0f;
    public float minDist = 3f;
    public Transform target;
    private bool stop = false;

    // Use this for initialization
    void Start()
    {
        // if no target specified, assume the player
        if (target == null)
        {

            if (GameObject.FindWithTag("Player") != null)
            {
                target = GameObject.FindWithTag("Player").GetComponent<Transform>();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
            return;

        

        //get the distance between the chaser and the target
        float distance = Vector3.Distance(transform.position, target.position);

        //so long as the chaser is farther away than the minimum distance, move towards it at rate speed.
        if ((distance > minDist))
        {
            if (!stop)
            {
                transform.position += transform.forward * speed * Time.deltaTime;
                // face the target
                transform.LookAt(target);
            }
            else
            {
                stop = true;
            }

        }
        else
        {
            // trigger the Animator to make the "Exit" transition
            this.GetComponent<Animator>().SetTrigger("Attack");
        }
    }

    // Set the target of the chaser
    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }

    public void Stopwalking()
    {
        stop = true;
    }
}