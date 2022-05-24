using UnityEngine;

#if(UNITY_EDITOR_WIN)
public class CharacterData : MonoBehaviour
{
    [HideInInspector]
    public EnemyData data = new EnemyData();
    [Header("-----Basic Enemy Properities-----")]
    [SerializeField] Sprite enemySprite;
    [SerializeField] string Name;

    [Header("------The Enemy's Appearance-----")]
    [SerializeField] GameObject prefab;
    [SerializeField] Transform Target;

    [Header("-----Enemy Physics-----")]
    [SerializeField] float enemySpeed;
    [SerializeField] bool IsCanMove;

    [Header("-----Enemy Movement Settings-----")]
    [SerializeField] Types.MOVEMENT Movement_Type;
    [SerializeField] float agroRange;

    private void Awake()
    {
        Movement_Type = Types.MOVEMENT.Horizontal;
    }
    public void createAnEnemy()
    {
        GameObject enemyObjected = Instantiate(prefab, transform.position, Quaternion.identity);
        TakingVariables(enemyObjected);
    }

    #region TakeingVariabes
    void TakingVariables(GameObject prfb)
    {
        data = new EnemyData();
        prfb.AddComponent<EnemyMovement>();
        prfb.AddComponent<Rigidbody2D>();
        prfb.AddComponent<BoxCollider2D>();
        switch (Movement_Type)
        {
            case Types.MOVEMENT.Horizontal:
                data.XMovement = true;
                break;
            case Types.MOVEMENT.Vertical:
                data.YMovement = true;
                break;
            case Types.MOVEMENT.Horizontal_and_Vertical:
                data.XYMovement = true;
                break;
            default:
                break;
        }
        data.spriteRenderer = enemySprite;
        data.Name = Name;
        data.target = Target;
        data.isCanMove = IsCanMove;
        data.speed = enemySpeed;
        data.agroRange = agroRange;
    }
    #endregion



}
#endif