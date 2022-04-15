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
    [SerializeField] bool ýsCanMove;



    EnemyData data;
    Rigidbody2D rb;


    private void Awake()
    {
        data = GetComponent<EnemyData>();
        ýsCanMove = data.ýsCanMove;
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
    }

    private void Start()
    {
        

        ///<sumarry>
        /// we're getting our variable's value from our enemy's data.
        /// </sumarry>


    }
    /// <summary>
    /// you should add what you want for here.
    /// </summary>


    void Update()
    {

        #region Movement
        if (ýsCanMove == true)
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




    #region MovementFonctions
    void Moving()
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

    void Stop()
    {

        rb.velocity = new Vector2(0, rb.velocity.y);

    }
    #endregion


}
