using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 4;
    public float jump = 5;
    public float jumpCooldown = 1f;
    public GameObject projectilePrefab;
    public Transform shootPoint;
    public float shootForce = 10f;
    private Rigidbody2D rb2D;
    private bool canJump = true;
    
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = (mousePosition - transform.position).normalized;
        transform.right = direction;
    }

    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        rb2D.velocity = new Vector2(move * speed, rb2D.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            rb2D.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
            canJump = false;
            StartCoroutine(EnableJumpAfterCooldown());
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
        Rigidbody2D projectileRb = projectile.GetComponent<Rigidbody2D>();
        if (projectileRb != null)
        {
            projectileRb.AddForce(transform.right * shootForce, ForceMode2D.Impulse);
        }
        else
        {
            Debug.LogError("no component");
        }
    }
    IEnumerator EnableJumpAfterCooldown()
    {
        yield return new WaitForSeconds(jumpCooldown);
        canJump = true;
    }
}
