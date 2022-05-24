using System.Collections;
using UnityEngine;

namespace UnityEngine
{
    public class Movement : MonoBehaviour
    {
        #region Horizontal Movement
        public virtual void _HorizontaltMove(Transform player, Transform target, float speed)
        {

            Rigidbody2D rb = player.GetComponent<Rigidbody2D>();

            if (rb.position.x < target.position.x)
            {
                rb.velocity = new Vector2(speed, rb.velocity.y);
            }
            else
            {
                rb.velocity = new Vector2(-speed, rb.velocity.y);
            }
        }
        #endregion

        #region Vertical Movement
        public virtual void _VerticalMove(Transform player, Transform target, float speed)
        {
            Rigidbody2D rb = player.GetComponent<Rigidbody2D>();
            rb.GetComponent<Rigidbody2D>().gravityScale = 0;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, target.position.y), speed * Time.deltaTime);

        }
        #endregion

        #region Horizontal and Vertical Movement
        public virtual void _DoubleMovement(Transform player, Transform target, float speed)
        {
            GetComponent<Rigidbody2D>().gravityScale = 0;
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        #endregion

    }
}