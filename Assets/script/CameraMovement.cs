using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            rigidBody.velocity = new Vector2(10, rigidBody.velocity.y);

            //�����������ŵ�ֵ
            transform.localScale = new Vector2(1f, 1f);
        }
        //��ɫˮƽ�ƶ�
        //��סA�����ж����С��0��������ʼ�ƶ�
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            rigidBody.velocity = new Vector2(-10, rigidBody.velocity.y);

            //���new Vector2(-1f, 1f)  xֵΪ��������ͼƬ���з�ת��ʾ
            transform.localScale = new Vector2(-1f, 1f);
        }
        else
        
        {
            rigidBody.velocity = new Vector2(0, rigidBody.velocity.y);
        }


        if (Input.GetAxisRaw("Vertical") > 0)
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, 10);

            //�����������ŵ�ֵ
            transform.localScale = new Vector2(1f, 1f);
        }
        
        else if (Input.GetAxisRaw("Vertical") < 0)
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, -10);

            //���new Vector2(-1f, 1f)  xֵΪ��������ͼƬ���з�ת��ʾ
            transform.localScale = new Vector2(-1f, 1f);
        }
        else
       
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x,0);
        }

    }
}
