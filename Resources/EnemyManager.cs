using System.Collections;
using UnityEngine;




#if(UNITY_EDITOR_WIN)
#region data
[System.Serializable]
public class EnemyData : MonoBehaviour
{

    public Sprite spriteRenderer;
    public float  speed, agroRange;
    public string Name;
    [HideInInspector]
    public bool XMovement, YMovement, XYMovement;
    public Transform target;
    public bool isCanMove;

}
#endregion
#endif
