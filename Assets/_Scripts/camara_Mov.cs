using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara_Mov : MonoBehaviour
{
    public Transform playerPos;

    private void FixedUpdate() {

        transform.position = new Vector3(playerPos.position.x, transform.position.y, playerPos.position.z-4f);

    }
}
