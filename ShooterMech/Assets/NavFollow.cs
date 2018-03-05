using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavFollow : MonoBehaviour {
    [SerializeField]
    Transform _destination;

    NavMeshAgent _navMeshAgent;
    private GameObject player;

    // Use this for initialization
    void Start()
    {
        _navMeshAgent = this.GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");

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
        }
    }
}
