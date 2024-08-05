using UnityEngine;



public class BulletManager : MonoBehaviour
{
    public float bulletSpeed;
    Rigidbody rb;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        ShootBullet();
    }

    public void ShootBullet()
    {
        rb.AddForce(Vector3.forward * bulletSpeed, ForceMode.Impulse);
    }

}
