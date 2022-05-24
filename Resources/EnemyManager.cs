using UnityEngine;


#if(UNITY_EDITOR_WIN)
#region DATA

[System.Serializable]
public class EnemyData
{

    public Sprite spriteRenderer;
    public float speed;
    public float agroRange;
    public string Name;
    public bool XMovement;
    public bool XYMovement;
    public bool YMovement;
    public bool isCanMove;
    public Transform target;

}
#endregion
#endif
