using System.Collections;
using UnityEngine;


public class CharacterData : MonoBehaviour
{

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
        prfb.AddComponent<EnemyMovement>();
        prfb.AddComponent<EnemyData>();
        prfb.AddComponent<Rigidbody2D>();
        prfb.AddComponent<BoxCollider2D>();
        EnemyData enemyData = prfb.GetComponent<EnemyData>();
        switch (Movement_Type)
        {
            case Types.MOVEMENT.Horizontal:
                enemyData.XMovement = true;
                break;
            case Types.MOVEMENT.Vertical:
                enemyData.YMovement = true;
                break;
            case Types.MOVEMENT.Horizontal_and_Vertical:
                enemyData.XYMovement = true;
                break;
            default:
                break;
        }
        enemyData.spriteRenderer = enemySprite;
        enemyData.Name = Name;
        enemyData.target = Target;
        enemyData.isCanMove = IsCanMove;
        enemyData.speed = enemySpeed;
        enemyData.agroRange = agroRange;

    }
    #endregion



}
