using UnityEngine;

public class PlayerTest:MonoBehaviour
{
	void FootL()
	{
		print("footL");
	}
	void FootR()
	{
		print("footR");
	}
	void Update()
	{
		Vector2 aaa = Vector2.down;

		GameObject player = GameObject.Find("RPG").transform.Find("RPG-Character").gameObject;
		player.transform.forward = aaa.normalized;
		Animator animator = player.GetComponent<Animator>();
		// animator.SetLayerWeight()
		// if(Input.GetKeyDown(KeyCode.S))
		// {
	
		// 	bool aa = animator.GetBool("isInMotion");
		// 	animator.SetBool("isInMotion" , !aa);
		// }
	}
}