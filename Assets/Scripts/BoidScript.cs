using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoidScript : MonoBehaviour
{
    public float speed = 1f;
    public float rotSpeed = 1f;

    float boundLimit = 29f;

    void FixedUpdate() {
        transform.position = transform.position + (transform.up * speed * Time.fixedDeltaTime);
        transform.Rotate(Random.Range(-rotSpeed, rotSpeed) * Time.fixedDeltaTime,
            Random.Range(-rotSpeed, rotSpeed) * Time.fixedDeltaTime,
            Random.Range(-rotSpeed, rotSpeed) * Time.fixedDeltaTime,
            Space.Self);

        checkBounds();
    }

    void checkBounds() {
        // X
        if (transform.position.x > boundLimit) {
            transform.position = new Vector3(transform.position.x - boundLimit * 2,
                transform.position.y,
                transform.position.z);
        } else if (transform.position.x < -boundLimit) {
            transform.position = new Vector3(transform.position.x + boundLimit * 2,
                transform.position.y,
                transform.position.z);
        }
        // Y
        if (transform.position.y > boundLimit) {
            transform.position = new Vector3(transform.position.x,
                transform.position.y - boundLimit * 2,
                transform.position.z);
        } else if (transform.position.y < -boundLimit) {
            transform.position = new Vector3(transform.position.x,
                transform.position.y + boundLimit * 2,
                transform.position.z);
        }
        // Z
        if (transform.position.z > boundLimit) {
            transform.position = new Vector3(transform.position.x,
                transform.position.y,
                transform.position.z - boundLimit * 2);
        } else if (transform.position.z < -boundLimit) {
            transform.position = new Vector3(transform.position.x,
                transform.position.y,
                transform.position.z + boundLimit * 2);
        }
    }
}
