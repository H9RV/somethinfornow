using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour{


    void Update() {
        Vector3 eulerRot = new Vector3(Mathf.Sin((float)(Time.deltaTime * 12)),
                                       Mathf.Sin((float)(Time.deltaTime * 15)),
                                       Mathf.Sin((float)(Time.deltaTime * 20)));

        transform.Rotate(eulerRot);
    }
}
