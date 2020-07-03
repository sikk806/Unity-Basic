using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float spinSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 마우스 클릭
        if(Input.GetMouseButtonDown(0))
        {
            this.spinSpeed = 10;
        }

        transform.Rotate(0, 0, this.spinSpeed);

        this.spinSpeed *= 0.996f;
    }
}
