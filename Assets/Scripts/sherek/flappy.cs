using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class flappy : MonoBehaviour
{

    public float jumpForce = 5f;
    public Rigidbody2D rb;
    public bool isDead = false;
    public float score = 0;
    public GameObject fart;

    public TextMeshProUGUI scoreText;

    public Sprite spriteJump;
    public Sprite spriteFall;
    public SpriteRenderer spriteRenderer;

    public GameObject EndScreen;

    public AudioSource audioSource;
    public AudioClip fartSound;

    void Update()
    {
        if (!isDead)
        {
            score += Time.deltaTime;
            scoreText.text = "Pontos: " + Mathf.FloorToInt(score).ToString();
        }

        if (Input.GetButtonDown("Jump") && !isDead || Input.GetButtonDown("Fire1") && !isDead)
        {
            audioSource.PlayOneShot(fartSound);
            spriteRenderer.sprite = spriteJump;
            fart.SetActive(true);
            rb.velocity = Vector2.zero;
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);

            Invoke("ChangeSprite", .4f);
        }
    }

    void ChangeSprite()
    {
        fart.SetActive(false);
        spriteRenderer.sprite = spriteFall;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            isDead = true;
            EndScreen.SetActive(true);
            Time.timeScale = 0;
        }
    }

}
