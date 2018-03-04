using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public float maxHealth;
    public float maxMana;
    public float manaRegen;
    public float AttackSpeed;
    public float damage;

    [HideInInspector]
    public float crrHealth;
    [HideInInspector]
    public float crrMana;

	// Use this for initialization
	void Awake ()
    {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TakeDamage(float ammount)
    {

    }

    public void AddHealth()
    {
        maxHealth += maxHealth * 0.1f;
    }

    public void AddManaRegen()
    {

    }

    public void AddAttackSpeed()
    {

    }

    public void AddDamage()
    {
           
    }

}
