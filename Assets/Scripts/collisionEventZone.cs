using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class collisionEventZone : MonoBehaviour
{
    NavMeshAgent _playerNav;

    public Vector3 _dokageObjectPosition;

    private void OnTriggerStay(Collider other)
    {
        _dokageObjectPosition = GameObject.FindGameObjectWithTag("Dockage").transform.position;

        if (other.gameObject.tag == "EventZone")
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                _playerNav.SetDestination(_dokageObjectPosition);

                Debug.Log("grande zone");
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        _playerNav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}