using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoidGenerator : MonoBehaviour
{
    public GameObject boidObj;

    void Start() {
        float rot = 7.5f;

        for (int i = 0 ; i < 50 ; i++) {
            for (int j = 0 ; j < 50 ; j++) {
                GameObject c = Instantiate(boidObj, Vector3.zero, Quaternion.identity);
                c.transform.eulerAngles = new Vector3(0f, -j * rot, -i * rot);
            }
        }
    }
}
