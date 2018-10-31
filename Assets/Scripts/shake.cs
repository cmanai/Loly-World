using UnityEngine;
using System.Collections;
public class shake : MonoBehaviour
{ 	

	private Vector3 originPosition;

	public float shake_decay;
	public float shake_intensity;




    

	
		

	void FixedUpdate (){
        Shake();
		if (shake_intensity > 0){
            transform.position = new Vector3(originPosition.x + Random.insideUnitSphere.x * shake_intensity, transform.position.y, transform.position.z);
            //	camera.transform.position = originPosition + Random.insideUnitSphere * shake_intensity;
			/*camera.transform.rotation = new Quaternion(
				originRotation.x + Random.Range (-shake_intensity,shake_intensity) * 0.03f,
				originRotation.y + Random.Range (-shake_intensity,shake_intensity) * 0.03f,
				originRotation.z + Random.Range (-shake_intensity,shake_intensity) * 0.03f,
				originRotation.w + Random.Range (-shake_intensity,shake_intensity) * 0.03f);*/
			shake_intensity -= shake_decay;
		}
	}
	
	void Shake(){
		originPosition = transform.position;
	
		shake_intensity = 0.06f;
		shake_decay = 0.02f;
	}
}