using System.Collections;
using UnityEngine;

#region data
[System.Serializable]
public class EnemyData : MonoBehaviour
{

    public Sprite spriteRenderer;
    public float Health, speed, Damage, agroRange;
    public string Name;
    public bool ýsCanMove;
    public Transform target;


}
#endregion

