using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class BulletController : MonoBehaviour
{
    public float damage;
    public float lifeTime = 3; //bullet is alive for 3 seconds

    public void Update(){
        //update bullet life every second
        lifeTime -= Time.deltaTime;

        if(lifeTime < 0){
            //bullet is out of time - destroy it
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other){
        if(other.GetComponent<Enemy>() != null){ //if the bullets hits an enemy(Default Layer- for now)
            other.GetComponent<Enemy>().health -= damage; //Enemy takes Damage
        }

        //Destroy the bullet when it hits something
        Destroy(gameObject);
    }
}
