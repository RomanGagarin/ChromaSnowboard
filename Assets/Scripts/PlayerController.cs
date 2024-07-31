using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.U2D;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float torqueAmount = 1;
    [SerializeField] GameObject levelFloor;
    SurfaceEffector2D floorEffector;
    Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        //floorEffector = levelFloor.GetComponent<SurfaceEffector2D>();
        floorEffector = GameObject.FindWithTag("Ground").GetComponent<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            // Do Nothing
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torqueAmount);
        }

        if (Input.GetKey(KeyCode.UpArrow) && floorEffector.speed < 50)
        {
            floorEffector.speed += 0.01f;
        }
        else if (Input.GetKey(KeyCode.DownArrow) && floorEffector.speed > 15)
        {
            floorEffector.speed -= 0.02f;
        }
    }
}
