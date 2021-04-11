﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapXcript : MonoBehaviour
{
    public Transform player;
    void LateUpdate()
    {
        Vector3 newPosition = player.position;
        newPosition.y = transform.position.y;
        transform.position = newPosition;

        transform.rotation = Quaternion.Euler(90f, player.eulerAngles.y, 0f);
    }
    // Start is called before the first frame update

}
