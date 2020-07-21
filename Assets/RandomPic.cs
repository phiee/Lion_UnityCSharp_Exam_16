using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class RandomPic : MonoBehaviour
{
	public Image randomImage;
	public Sprite s0;
	public Sprite s1;
	public Sprite s2;
	public Sprite s3;
	public Sprite s4;
	public Sprite s5;
	public Sprite s6;
	public Sprite s7;
	public Sprite s8;
	public Sprite s9;
	public Sprite[] images;

	void Start()
	{
		// 取得隨機值
		int random = Random.Range(1, 11);
	}

	void Update()
	{
		//void changeImage()
		//{
			//int num = UnityEngine.Random.Range(0, images.Length);
			//randomImage.sprite = images[num];
		//}
	}

}