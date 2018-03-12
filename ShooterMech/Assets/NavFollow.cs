using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavFollow : MonoBehaviour {
    [SerializeField]
    Transform _destination;

    NavMeshAgent _navMeshAgent;
    private GameObject player;
    public float damage = 50f;
    public float attackRange = 1.0f;
    public float attackTime = 20f;
    private Health health;
   
    // Use this for initialization
    void Start()
    {
        _navMeshAgent = this.GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");
        health = player.GetComponent<Health>();

    }
    private void Update()
    {
        if (_navMeshAgent == null)
        {
            Debug.LogError("No NavMesh");
        }
        else
        {
            SetDestination();
        }
    }
    private void SetDestination()
    {
        if(_destination != null)
        {
            Vector3 targetVector = player.transform.position;
            _navMeshAgent.SetDestination(targetVector);
            

            float distance = Vector3.Distance(targetVector, transform.position);
            if (distance <= attackRange)
            { //Kill
                StartCoroutine(Attack());
                
            }
        }
    }
    IEnumerator Attack()
    {
        health.TakeDamage(damage);
        yield return new WaitForSeconds(attackTime);
    }
}
