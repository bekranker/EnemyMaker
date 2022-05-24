using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{
    public class Move : Movement
    {
        public override void _HorizontaltMove(Transform player, Transform target, float speed)
        {
            base._HorizontaltMove(player, target, speed);
        }
        public override void _VerticalMove(Transform player, Transform target, float speed)
        {
            base._VerticalMove(player, target, speed);
        }
        public override void _DoubleMovement(Transform player, Transform target, float speed)
        {
            base._DoubleMovement(player, target, speed);
        }
    }

}
