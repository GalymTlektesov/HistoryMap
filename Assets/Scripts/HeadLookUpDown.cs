using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadLookUpDown : MonoBehaviour
{
    public float velocity = 0.7f;
    public float minHeight = 1.6f;
    public float maxHeight = 20.0f;

    private void Update()
    {
        float moveY = Camera.main.transform.forward.y * velocity * Time.deltaTime;
        float newY = transform.position.y + moveY;
        if(newY >= minHeight && newY < maxHeight)
        {
            transform.position = new Vector3(transform.position.x,
                newY, transform.position.z);
        }
    }
}
