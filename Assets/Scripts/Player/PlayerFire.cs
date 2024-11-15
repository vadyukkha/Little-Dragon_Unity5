using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerFire : MonoBehaviour
{
    [SerializeField] GameObject fireball;
    PlayerMovement playerMovement;
    Animator animator;
    float cooldownInterval = 1;
    float cooldownTimer = Mathf.Infinity;
    public static int currentCountFireballs = 3;

    void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
        animator = GetComponent<Animator>();
        currentCountFireballs = 3;
    }

    public void OnFire(InputAction.CallbackContext context)
    {
        if (context.started && playerMovement.canFire() && cooldownTimer > cooldownInterval && currentCountFireballs > 0) 
        {
            cooldownTimer = 0;
            animator.SetTrigger("fire");
            --currentCountFireballs;
            if (playerMovement.getIsFacingRight())
            {
                GameObject newFireball = Instantiate(fireball, new Vector3(transform.position.x + 1f, transform.position.y - 0.5f, 0f), Quaternion.identity);
                newFireball.GetComponent<Fireball>().setDirection(1);
            }
            else
            {
                GameObject newFireball = Instantiate(fireball, new Vector3(transform.position.x - 1f,transform.position.y - 0.5f, 0f), Quaternion.identity);
                newFireball.GetComponent<Fireball>().setDirection(-1);
                newFireball.GetComponent<SpriteRenderer>().flipX = true;
            }
        }
    }

    void FixedUpdate()
    {
        cooldownTimer += Time.fixedDeltaTime;
    }

}