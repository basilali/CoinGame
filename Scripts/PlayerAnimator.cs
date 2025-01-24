using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{

    private Animator am;
    private PlayerMovement pm;
    private SpriteRenderer sr;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        am = GetComponent<Animator>();
        pm = GetComponent<PlayerMovement>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pm.moveDirection.x != 0 || pm.moveDirection.y != 0)
        {
            am.SetBool("IsMoving", true);
            SpriteDirectionChecker();
        }
        else
        {
            am.SetBool("IsMoving", false);
        }
    }

    void SpriteDirectionChecker()
    {
        if (pm.lastHorizontalVector < 0)
        {
            sr.flipX = true;
        }
        else
        {
            sr.flipX = false;
        }
    }
}
