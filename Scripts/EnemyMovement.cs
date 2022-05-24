using UnityEngine;


class EnemyMovement : Move
{
    [HideInInspector]
    [SerializeField] Sprite sp;
    [HideInInspector]
    [SerializeField] Transform target;
    [HideInInspector]
    [SerializeField] float speed, agroRange;
    [HideInInspector]
    [SerializeField] string Name;
    [HideInInspector]
    [SerializeField] bool isCanMove, horMovement, verMovement, doubleMovement;

    Rigidbody2D rb;
    CharacterData characterData;

    private void Awake()
    {
        ///<sumarry>
        /// we're getting our variable's value from our enemy's data.
        /// </sumarry>
        characterData = FindObjectOfType<CharacterData>();
        EnemyData data = characterData.data;
        #region variables
        horMovement = data.XMovement;
        verMovement = data.YMovement;
        doubleMovement = data.XYMovement;
        isCanMove = data.isCanMove;
        speed = data.speed;
        target = data.target;
        Name = data.Name;
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
        if (isCanMove == true)
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
        if (verMovement == true)
        {
            verticleMovement();

        }
        if (doubleMovement == true)
        {
            DoubleMovement();
        }
    }

    void Stop()
    {
        if (horMovement) { rb.velocity = new Vector2(0, rb.velocity.y); }
        if (verMovement) { rb.velocity = new Vector2(rb.velocity.x, 0); }
        if (doubleMovement) { rb.velocity = new Vector2(0, 0); }
    }
    #endregion

    #region MOVEMENT_FUNCTIONS
    void horizontalMovement()
    {
        _HorizontaltMove(gameObject.transform, target, speed);
    }
    void verticleMovement()
    {
        _VerticalMove(gameObject.transform, target, speed);
    }
    void DoubleMovement()
    {
        _DoubleMovement(gameObject.transform, target, speed);
    }
    #endregion

}
