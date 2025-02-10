using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health;

    private void Update(){
        //if the enemy's health is 0 remove him from the game
        if(health <= 0){
            Destroy(gameObject);
        }
    }
}
