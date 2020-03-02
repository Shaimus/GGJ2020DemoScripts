using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villager : MonoBehaviour
{

    public bool isFree;
    public bool isWalking;
    public Vector3 destination;
    public float villagerSpeed = 25f;
    public Vector3 start;
    public Vector3 difference;
    private Animator animator;
    

    
    void Start()
    {
        isFree = true;
        animator = gameObject.GetComponent<Animator>();
    }

    
    void Update()
    {
        

        if (isWalking)
        {

            if (Vector3.Distance(transform.position, destination) < 3f)
            {
                
                destination *= -1.0f;
                isWalking = false;
                animator.ResetTrigger("VillagerMoving");
            }
            Vector3 pos = transform.position;
                pos.z += difference.z / villagerSpeed * Time.deltaTime;
                pos.x += difference.x / villagerSpeed * Time.deltaTime;
            Vector3 newDirection = Vector3.RotateTowards(transform.forward, destination, 10 * Time.deltaTime, 0.0f);
            transform.rotation = Quaternion.LookRotation(newDirection);

            transform.position = pos;

           
        }

        
    }

    public void setDestination(Vector3 des)
    {
        destination = des;
        start = transform.position;
        difference = destination - start;
        animator.SetTrigger("VillagerMoving");
    }
}
