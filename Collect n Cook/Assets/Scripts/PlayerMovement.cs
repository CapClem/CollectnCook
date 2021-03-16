using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 5f;
    public float gravity = -100f;
    public float jumpHeight = 4f;
    public float speedBoost = 7f;

    Vector3 velocity;

    [SerializeField]
    Animator animator;

    float walkingV;

    [SerializeField]
    Transform groundCheck;

    [SerializeField]
    float groundDistance = 0.4f;

    [SerializeField]
    LayerMask groundMask;
    //public float waterDistance = 0.4f;
    //public LayerMask waterMask;
    bool isGrounded;
    //public bool isWatered;

    float downTime, pressTime = 0;
    float countDown = 5.0f;

    [SerializeField]
    float turnSmoothTime = 0.1f;

    float turnSmoothVelocity;
    [SerializeField]
    Transform cam;

    void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        //isWatered = Physics.CheckSphere(groundCheck.position, waterDistance, waterMask);
        
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

     /*   if (isWatered)
        {
            Debug.Log("In water");
        }
     */
        float x = Input.GetAxis("Horizontal");
        walkingV = Input.GetAxis("Vertical");
  
        animator.SetFloat("Walking", Mathf.Abs(walkingV));

        //Vector3 move = (transform.right * x + transform.forward * walkingV).normalized;

        Vector3 move = new Vector3(x, 0f, walkingV).normalized;
        
        //Player rotation left and right
        if (move.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(move.x, move.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }

        //Animation if statement for running
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            downTime = Time.time;
            pressTime = downTime + countDown;
            
            animator.SetFloat("Running", 1f);
            speed += speedBoost;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            animator.SetFloat("Running", 0f);

            if (Time.time >= pressTime)
            {
                //SoundManager.PlaySFX("HBreathing");
            }

            //SoundManager.PlaySFX("HBreathing");
            speed -= speedBoost;        
        }

        //Animation if statement for jumping
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            //SoundManager.PlaySFX("JumpLanding");
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);      
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, 10f);
    }
}
