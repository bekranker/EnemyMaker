using System.Collections;
using UnityEngine;

#region data
[System.Serializable]
public class EnemyData : MonoBehaviour
{

    public Sprite spriteRenderer;
    public float Health, speed, Damage, agroRange;
    public string Name;
    public bool �sCanMove, horMovement, verMovement, doubleMovement;
    public Transform target;


}
#endregion

