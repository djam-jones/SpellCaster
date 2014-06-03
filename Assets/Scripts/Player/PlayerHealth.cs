using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public int startHealth;
	public int healthPerHeart;

	public int currentHealth;
	private int maxHealth;

	public GUITexture heartGUI;
	public Texture[] images;

	private ArrayList hearts = new ArrayList();

	public int maxHeartsPerRow = 10;
	private float spacingX;
	private float spacingY;

	void Start()
	{
		currentHealth = startHealth;

		spacingX = heartGUI.pixelInset.width + 5f;
		spacingY = -heartGUI.pixelInset.height;
		AddHearts(startHealth/healthPerHeart);
	}

	public void AddHearts(int add)
	{
		for(int i = 0; i < add; i++){
			Transform newHeart = ((GameObject)Instantiate(heartGUI.gameObject, transform.position, Quaternion.identity)).transform;
			newHeart.parent = this.transform;

			int y = Mathf.FloorToInt(hearts.Count/maxHeartsPerRow);
			int x = hearts.Count - y * maxHeartsPerRow;

			newHeart.GetComponent<GUITexture>().pixelInset = new Rect(x * spacingX, y * spacingY, 60, 55);
			hearts.Add(newHeart);
		}

		maxHealth += add * healthPerHeart;
		currentHealth = maxHealth;
		UpdateHearts();
	}

	public void ModifyHealth(int amount)
	{
		currentHealth += amount;
		currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
		UpdateHearts();
	}

	private void UpdateHearts()
	{
		bool restAreEmpty = false;
		int i = 0;
		foreach(Transform heart in hearts)
		{
			if(restAreEmpty)
			{
				heart.guiTexture.texture = images[0];
			}
			else{
				i += 1;
				if(currentHealth >= i * healthPerHeart)
				{
					heart.guiTexture.texture = images[images.Length-1];
				}
				else
				{
					int currentHeartHealth = (int)(healthPerHeart - (healthPerHeart * i - currentHealth));
					int healthPerImage = healthPerHeart / images.Length;
					int imageIndex = currentHeartHealth / healthPerImage;

					if(imageIndex == 0 && currentHeartHealth > 0)
					{
						imageIndex = 1;
					}

					heart.guiTexture.texture = images[imageIndex];
					restAreEmpty = true;
				}
			}
		}
	}
}