using UnityEngine;

public class player : MonoBehaviour
{
    public float movespeed = 5f;
    private Animator playeranimator;
    public float jumping = 5f;
    Rigidbody rb;
    private float movespeed2 = 2f;
    private float movespeed3 = 3f;

    private void Awake()
    {
        playeranimator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Move();
    }
    void fall()
    {
        transform.position = transform.position + new Vector3(0, -2, 0);
    }
    private void Move()
    {
        
        {
            playeranimator.SetBool("run", true);
            transform.Translate(new Vector3(0, 0, movespeed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playeranimator.SetBool("run", true);
            if (this.gameObject.transform.position.x > levelboundry.leftside)
            {
                transform.Translate(new Vector3(-1 * movespeed * Time.deltaTime, 0, movespeed3 * Time.deltaTime));
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < levelboundry.rightside)
            {
                playeranimator.SetBool("run", true);
                transform.Translate(new Vector3(1 * movespeed * Time.deltaTime, 0, movespeed3 * Time.deltaTime));

            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = transform.position + new Vector3(0, 5, 0);
            Invoke("fall", 0.4f);
        }



    }
}
