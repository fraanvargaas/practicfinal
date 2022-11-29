using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
	public int MaxHealth;
	private int currentHealth;

	private Vector3 InitialPosition;

	public Image healthBar;

	public void UpdateHealtBar()
	{
		healthBar.fillAmount = Mathf.InverseLerp(0, MaxHealth, currentHealth);
	}

	private void Start()
	{
		InitialPosition = transform.position;
		currentHealth = MaxHealth;
		
	}

	public void TakeDamage(int damageTaken)
	{
		currentHealth -= damageTaken;

		if (currentHealth <= 0)
		{
			Die();
		}
		else
		{
			Debug.Log("me han echo da�o, salud restante " + currentHealth);
		}
		
	}

	public virtual void Die()
	{
	}
}