using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorController : MonoBehaviour
{
    float horizontal;
    float vertical;

    Rigidbody rb;
    public int speed;
    public float JumpV = 10;
    public float thrust = 10;

    public int monedas;
    public int totalDeMonedas;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed = 5;
        monedas = 0;
        totalDeMonedas = 10;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal * speed, 0f ,vertical * speed);
        rb.AddForce(direction);
        RaycastHit hitInfo;
            if (Input.GetKeyDown(KeyCode.Space) && Physics.SphereCast(transform.position,0.04f,Vector3.down,out hitInfo,0.02f))
                jump();
            

    }
    public void jump()
    {
        rb.AddForce(0, thrust, 0, ForceMode.Impulse);
    }
    public int getMonedas()
    {
        return monedas;
    }
}
