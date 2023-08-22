using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    private bool sphere4CollidedWithQuad8 = false;
    private bool sphere3CollidedWithQuad2 = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Sphere4" && collision.gameObject.name == "Quad8")
        {
            sphere4CollidedWithQuad8 = true;
        }

        if (collision.gameObject.name == "Sphere3" && collision.gameObject.name == "Quad2")
        {
            sphere3CollidedWithQuad2 = true;
        }
    }

    private void Update()
    {
        if (sphere4CollidedWithQuad8)
        {
            Destroy(GameObject.Find("Sphere4"));
            Destroy(GameObject.Find("Sphere5"));
            Destroy(GameObject.Find("MeshRope2"));
            sphere4CollidedWithQuad8 = false;
        }

        if (sphere3CollidedWithQuad2)
        {
            for (int i = 1; i <= 6; i++)
            {
                Destroy(GameObject.Find("Sphere" + i));
            }
            for (int i = 1; i <= 3; i++)
            {
                Destroy(GameObject.Find("MeshRope" + i));
            }
            sphere3CollidedWithQuad2 = false;
        }
    }
}
