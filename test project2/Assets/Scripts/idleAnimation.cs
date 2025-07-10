using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idleAnimation : MonoBehaviour
{

    public RectTransform panel;
    public float speed;
    public float ScaleAmount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float scale = 1 + Mathf.Sin(Time.time * speed) * ScaleAmount;
        panel.localScale = new Vector3(scale, scale, 1);
    }
}
