using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform user;
    private NavMeshAgent enemyAgent;
    public bool UserDetect;
    private Animator enemyAnimator;
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        UserDetect = true;
    }
    void Start()
    {
        enemyAgent = GetComponent<NavMeshAgent>();
        enemyAnimator =GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(UserDetect)
        {
            enemyAgent.destination = user.position;
            enemyAnimator.SetInteger("Accion", 1);
        }
    }
}
