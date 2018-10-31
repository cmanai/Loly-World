using UnityEngine;
using System.Collections;
public class Shake2 : MonoBehaviour
{

    public float shake_decay;
    public float shake_intensity;









    void FixedUpdate()
    {
     //   Shake();
       // if (shake_intensity > 0)
        //{
         //   transform.position = new Vector3(originPosition.x + Random.insideUnitSphere.x * shake_intensity, transform.position.y, transform.position.z);
            transform.localScale = new Vector3(4.7f, 4.4f, 1.28f);
          
    
        
            Invoke("initialScale", 0.3f);
       
            //	camera.transform.position = originPosition + Random.insideUnitSphere * shake_intensity;
            /*camera.transform.rotation = new Quaternion(
                originRotation.x + Random.Range (-shake_intensity,shake_intensity) * 0.03f,
                originRotation.y + Random.Range (-shake_intensity,shake_intensity) * 0.03f,
                originRotation.z + Random.Range (-shake_intensity,shake_intensity) * 0.03f,
                originRotation.w + Random.Range (-shake_intensity,shake_intensity) * 0.03f);*/
          //  shake_intensity -= shake_decay;
        //}
    }
    public void initialScale()
    {
       
        transform.localScale = new Vector3(4.3008f, 4.02f, 1.28f);
    }
   
}