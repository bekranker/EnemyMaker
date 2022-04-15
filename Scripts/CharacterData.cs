using System.Collections;
using UnityEngine;


public class CharacterData : MonoBehaviour
{

    [Header("-----Basic Enemy Properities-----")]
    [SerializeField] Sprite enemySprite;
    [SerializeField] float health;
    [SerializeField] float damage;
    [SerializeField] string Name;

    [Header("------The Enemy's Appearance-----")]
    [SerializeField] GameObject prefab;
    [SerializeField] Transform spawner;
    [SerializeField] Transform Target;

    [Header("-----Enemy Physics-----")]
    [SerializeField] float enemySpeed;
    [SerializeField] bool IsCanMove;

    [Header("-----Enemy Movement Settings-----")]
    [SerializeField] float agroRange;




    public void createAnEnemy()
    {

        GameObject enemyObjected = Instantiate(prefab, spawner.position, Quaternion.identity);
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

        enemyData.Health = health;
        enemyData.Damage = damage;
        enemyData.spriteRenderer = enemySprite;
        enemyData.Name = Name;
        enemyData.target = Target;
        enemyData.ýsCanMove = IsCanMove;
        enemyData.speed = enemySpeed;
        enemyData.agroRange = agroRange;

    }
    #endregion



}
