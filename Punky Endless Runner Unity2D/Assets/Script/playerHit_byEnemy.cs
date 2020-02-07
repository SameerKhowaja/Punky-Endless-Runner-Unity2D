using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerHit_byEnemy : MonoBehaviour
{
    public Canvas gameOverCanvas;
    public playerJump pj;
    public spawnEnemy se;
    public scoringWhenEnemyCollide swc;

    bool restart;

    private void Update()
    {
        if(restart == true)
        {
            StartCoroutine(RestartLvl());
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Enemy")
        {
            gameOverCanvas.enabled = true;
            pj.enabled = se.enabled = swc.enabled = false;
            restart = true;
        }
    }


    IEnumerator RestartLvl()
    {
        yield return new WaitForSeconds(1.5f);

        SceneManager.LoadScene("MainScene");
    }
}
