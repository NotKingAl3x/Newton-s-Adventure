using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollider : MonoBehaviour
{
    public bool isTouchingWall = false;
    
    public Collider2D wallCollider;

    private void Update()
    {
        // Check if there are any colliders overlapping with wallCollider
        Collider2D[] results = new Collider2D[1];
        ContactFilter2D filter = new ContactFilter2D();
        filter.SetLayerMask(LayerMask.GetMask("Ground")); // Filter by layer "Ground"

        int count = wallCollider.OverlapCollider(filter, results);

        // If no colliders are overlapping with wallCollider
        if (count == 0)
        {
            isTouchingWall = false;
        }
        else
        {
            isTouchingWall = true;
        }
    }
    
}
