using System.Collections;
using UnityEngine;

class EnemyMovement : MonoBehaviour
{
    [HideInInspector]
    [SerializeField] Sprite sp;
    [HideInInspector]
    [SerializeField] Transform target;
    [HideInInspector]
    [SerializeField] float speed, agroRange, health, Damage;
    [HideInInspector]
    [SerializeField] string Name;
    [HideInInspector]
    [SerializeField] bool �sCanMove, horMovement, verMovement, doubleMovement;



    EnemyData data;
    Rigidbody2D rb;


    private void Awake()
    {
        ///<sumarry>
        /// we're getting our variable's value from our enemy's data.
        /// </sumarry>

        #region variables
        data = GetComponent<EnemyData>();
        horMovement = data.horMovement;
        verMovement = data.verMovement;
        doubleMovement = data.doubleMovement;
        �sCanMove = data.�sCanMove;
        speed = data.speed;
        target = data.target;
        Name = data.Name;
        Damage = data.Damage;
        health = data.Health;
        agroRange = data.agroRange;
        sp = data.spriteRenderer;
        gameObject.name = Name;
        rb = this.GetComponent<Rigidbody2D>();
        gameObject.GetComponent<SpriteRenderer>().sprite = sp;
        #endregion


    }

    /// <summary>
    /// you should add what you want for here.
    /// </summary>


    void Update()
    {

        #region Movement
        if (�sCanMove == true)
        {
            float distanceToPlayer = Vector2.Distance(transform.position, target.position);

            if (distanceToPlayer <= agroRange && distanceToPlayer >= 3)
            {
                Moving();
            }

            else if (distanceToPlayer < 3)
            {
                Stop();
            }



        }
        #endregion

    }




    #region Moving
    void Moving()
    {
        if (horMovement == true)
        {
            horizontalMovement();
        }
        else if (verMovement == true)
        {
            verticleMovement();

        }
        else if (doubleMovement == true)
        {
            DoubleMovement();
        }


    }

    void Stop()
    {

        rb.velocity = new Vector2(0, rb.velocity.y);

    }
    #endregion

    #region MOVEMENT_FUNCTIONS
    void horizontalMovement()
    {
        if (transform.position.x < target.position.x)
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
    }
    void verticleMovement()
    {
        GetComponent<Rigidbody2D>().gravityScale = 0;
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, target.position.y), speed * Time.deltaTime);
    }
    void DoubleMovement()
    {
        GetComponent<Rigidbody2D>().gravityScale = 0;
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
    #endregion

}
