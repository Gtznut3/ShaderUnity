using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawnBoatScript : MonoBehaviour
{
    private collisionRockBoatScript _collisionBoatScript;

    private Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;

        _collisionBoatScript = GetComponent<collisionRockBoatScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -15f)
        {
            transform.SetLocalPositionAndRotation(startPos, transform.localRotation);
            transform.GetComponent<CapsuleCollider>().isTrigger = false;
            transform.GetComponent<BoxCollider>().isTrigger = false;

            _collisionBoatScript.setIsCollide(false);
        }
    }
}
