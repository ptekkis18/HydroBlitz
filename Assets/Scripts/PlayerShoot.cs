using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
   [Header("Bullet Variables")]
   public float bulletSpeed;
   public float bulletDamage;
   

   [Header("Initial Setup")]
   public Transform bulletSpawnTransform;
   public GameObject bulletPrefab;


   private void Update(){
    //fire bullet with right click
        if(Input.GetButtonDown("Fire2")){
            Shoot();
        }
   }


   void Shoot(){
    //generate a bullet object
        GameObject bullet = Instantiate(bulletPrefab,bulletSpawnTransform.position, Quaternion.identity, GameObject.FindGameObjectWithTag("WorldObjectHolder").transform);
    //Push it forward
        bullet.GetComponent<Rigidbody>().AddForce(bulletSpawnTransform.forward * bulletSpeed, ForceMode.Impulse);
    //set bullet damage be the same as bulletcontroller
        bullet.GetComponent<BulletController>().damage = bulletDamage;
   }
}
