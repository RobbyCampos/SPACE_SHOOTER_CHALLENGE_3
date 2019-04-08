using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGscroller : MonoBehaviour {

    public float scrollSpeed;
    public float tilesizeZ;

    private Vector3 startPosition;

    public void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tilesizeZ);
        transform.position = startPosition + Vector3.forward * newPosition;
    }
}
