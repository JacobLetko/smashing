using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class follow : MonoBehaviour {

    public GameObject player;
    NavMeshAgent nav;

    private void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update () {
        nav.SetDestination(player.transform.position);
	}
}
