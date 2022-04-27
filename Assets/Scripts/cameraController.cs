using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float startingX = 1.08f;
    [SerializeField] private float startingY = -2.57f;
    [SerializeField] private float endingX = 45.6906f;

    // Update is called once per frame
    private void Update()
    {
        float x = player.position.x;
        float y = player.position.y;

        if (player.position.x < startingX)
        {
            x = startingX;
        } 
        else if (player.position.x > endingX)
        {
            x = endingX;
        }

        if (player.position.y < startingY)
        {
            y = startingY;
        }

        transform.position = new Vector3(x, y, transform.position.z);
    }
}
