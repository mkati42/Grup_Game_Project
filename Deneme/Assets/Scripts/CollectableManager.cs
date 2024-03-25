using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableManager : MonoBehaviour
{
    [SerializeField] private GameObject _box;
    private float   boxHealth = 100f;
    private int     randomNumber;     
    [SerializeField] private GameObject _speed;
    [SerializeField] private GameObject _damage;
    [SerializeField] private GameObject _health;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takeDamage(float damage)
    {
        boxHealth -= damage;
        if (boxHealth <= 0)
            crushBox();
        else
            StartCoroutine("Vibrate");
    }

    void crushBox()
    {
        randomNumber = Random.Range(1, 4);
        if (randomNumber == 1)
        {
            _speed.transform.position = _box.transform.position;
            _speed.SetActive(true);
        }

        else if (randomNumber == 2)
        {
            _health.transform.position = _box.transform.position;
            _health.SetActive(true);
        }

        else if (randomNumber == 3)
        {
            _damage.transform.position = _box.transform.position;
            _damage.SetActive(true);
        }
        _box.SetActive(false);
    }

    public void objectActiveFalse(string name)
    {
        if (name == "speed")
            _speed.SetActive(false);
        else if (name == "damage_plus")
            _health.SetActive(false);
        if (name == "heath")
            _damage.SetActive(false);
    }

    IEnumerator Vibrate()
    {
        // Zamanla titreşim efekti
        float duration = 0.2f;
        float magnitude = 0.05f;

        Vector3 originalPos = transform.position;
        float elapsed = 0.0f;

        while (elapsed < duration)
        {
            float x = originalPos.x + Mathf.Sin(Time.time * 100) * magnitude;
            transform.position = new Vector3(x, originalPos.y, originalPos.z);
            elapsed += Time.deltaTime;
            yield return null;
        }

        transform.position = originalPos;
    }
}
