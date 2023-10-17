using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{

    public Button LostButton;
    public NavMeshAgent enemy;
    public Transform Player;
   
   void OnCollisionEnter(Collision collision)
   {
        if(collision.gameObject.CompareTag("Player"))
        {
            LostButton.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
   }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(Player.position);
    }
}
