using System.Collections;
using UnityEngine;

#region data
[System.Serializable]
public class EnemyData : MonoBehaviour
{

    public Sprite spriteRenderer;
    public float  speed, agroRange;
    public string Name;
    public bool isCanMove, XMovement, YMovement, XYMovement;
    public Transform target;


}
#endregion

