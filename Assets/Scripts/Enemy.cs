using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Player player;
    [SerializeField] private float enemySpeed = 5f;

    private Rigidbody2D _enemyRigidbody;

    private void Start()
    {
        _enemyRigidbody = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<Player>();
    }

    private void Update()
    {
        if (!player._isAlive)
        {
            enemySpeed = 0f;
        }

        if (IsFacingRight())
        {
            _enemyRigidbody.velocity = Vector3.right * enemySpeed;
        }
        else
        {
            _enemyRigidbody.velocity = Vector3.left * enemySpeed;
        }
    }
    private bool IsFacingRight()
    {
        return transform.localScale.x > 0;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        transform.localScale = new Vector3(-(Mathf.Sign(_enemyRigidbody.velocity.x)), 1f, 1f);
    }
}
