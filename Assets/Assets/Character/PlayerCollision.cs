using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    public Health health;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Traps")
        {
            health.health--;
            StartCoroutine(GetHurt());

        }
    }
    IEnumerator GetHurt()
    {
        Physics2D.IgnoreLayerCollision(6, 10);
        GetComponent<Animator>().SetLayerWeight(1, 1);
        yield return new WaitForSeconds(3);
        GetComponent<Animator>().SetLayerWeight(1, 0);
        Physics2D.IgnoreLayerCollision(6, 10, false);

    }
}
