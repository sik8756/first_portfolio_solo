using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField]
    float JumpPower;
    public static bool move;
    Rigidbody2D RB;
    [SerializeField]
    Transform GroundCheck;
    [SerializeField]
    GameObject Dont_move;
    [SerializeField]
    LayerMask Layer;
    float Playermove;
    float time;
    bool isGround;

    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if(move)
        {
            IsGround();
            Move();
            TryJump();
            RB.velocity = new Vector2(0, 0);
            time = 0;
        }
        else if(!move)
        {
            IsGround();
            Move();
            TryJump();
        }

        if(ScoreManager.score2 >= 50000)
        {
            time += Time.deltaTime;

            if(Playermove != 0)
            time = 0;

            if(time >= 2f)
            {
                time = 0;
                StartCoroutine(Dont_move.GetComponent<whereareyoulooking>().Pattern());
            }
        }
    }

    void IsGround()
    {       
        isGround = Physics2D.Raycast(GroundCheck.position, Vector2.down, 0.01f,Layer);
    }

    void Move()
    {
        Playermove = Input.GetAxisRaw("Horizontal");

        float move_x = Playermove * speed;
        RB.velocity = new Vector2(move_x , RB.velocity.y);
    }

    void TryJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
            Jump();
    }

    void Jump()
    {
        RB.velocity = new Vector2(RB.velocity.x, JumpPower);
    }
}
