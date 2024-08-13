using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextDamage : MonoBehaviour
{
    public float damage;
    public TMP_Text damageText;
    void Start()
    {
        Destroy(gameObject,3);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y+3 * Time.deltaTime,gameObject.transform.position.z);
    }

    public void SetDamageText(float _damage)
    {
        damage = _damage;
        damageText.text = damage.ToString();
    }
}
