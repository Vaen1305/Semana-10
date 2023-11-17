using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Transform _compTransform;
    private SpriteRenderer _compSpriteRenderer;
    public float speed;
    public int directionX;
    public int directionY;

    void Awake()
    {
        _compTransform = GetComponent<Transform>();
        _compSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        _compTransform.position = new Vector2(_compTransform.position.x + speed * directionX * Time.deltaTime, _compTransform.position.y + speed * directionY * Time.deltaTime);

        if (_compTransform.position.x > 8.05f)
        {
            directionX = -1;
            _compSpriteRenderer.flipX = true;
            _compTransform.position = new Vector2(8.05f, _compTransform.position.y);
        }

        if (_compTransform.position.x < -8.05f)
        {
            directionX = 1;
            _compSpriteRenderer.flipX = false;
            _compTransform.position = new Vector2(-8.05f, _compTransform.position.y);
        }

        if (_compTransform.position.y > 4.24f)
        {
            directionY = -1;
            _compTransform.position = new Vector2(_compTransform.position.x, 4.24f);
        }

        if (_compTransform.position.y < -4.24f)
        {
            directionY = 1;
            _compTransform.position = new Vector2(_compTransform.position.x, -4.24f);
        }
    }
}
