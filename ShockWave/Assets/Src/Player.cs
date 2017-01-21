using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	[SerializeField]
	float impactRadius = 5.0F;
	[SerializeField]
	float impactPower = 10.0F;
	[SerializeField]
	float speed = 10f;

	Animator animator;

	Transform weapon;

	Rigidbody mRigidbody;

	void Start ()
    {
		this.mRigidbody = this.GetComponent<Rigidbody> ();
		this.weapon = this.transform.GetChild(0);
		this.animator = GetComponent<Animator> ();
	}

	void FixedUpdate ()
    {
		if(Input.GetButtonDown (GlobalReference.Inputs.Basic_Attack))
		{
			animator.SetTrigger(GlobalReference.Animations.Basic_Attack);
			DoImpact();
		}

		float horizontal = Input.GetAxis("Horizontal"), vertical = Input.GetAxis("Vertical");

		animator.SetFloat(GlobalReference.Animations.Speed, Mathf.Abs(horizontal)+Mathf.Abs(vertical));

		if(horizontal < -0.15 || horizontal > 0.15 || vertical < -0.15 || vertical > 0.15)
		{
			float myAngle = Mathf.Atan2 (Input.GetAxis ("Horizontal"),Input.GetAxis ("Vertical")) * Mathf.Rad2Deg;
			transform.eulerAngles = new Vector3(0,Mathf.LerpAngle(this.transform.eulerAngles.y, myAngle, 5*Time.deltaTime), 0);
			mRigidbody.AddForce(Vector3.right * horizontal * (speed/5), ForceMode.Impulse); 
			mRigidbody.AddForce(Vector3.forward * vertical * (speed/5), ForceMode.Impulse);
		}
	}

	void DoImpact()
	{
		Vector3 explosionPos = weapon.position;
		Collider[] colliders = Physics.OverlapSphere(explosionPos, impactRadius);
		foreach (Collider hit in colliders) 
		{
			Rigidbody rb = hit.GetComponent<Rigidbody>();
			
			if (rb != null)
			{
				if(hit.name != this.transform.name)
					rb.AddExplosionForce(impactPower, explosionPos, impactRadius, 0, ForceMode.VelocityChange);
			}
		}
	}
}
