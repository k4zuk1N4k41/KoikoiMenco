using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPoint : MonoBehaviour
{
    [SerializeField] GameObject targetPoint;      //���b�N�I���J�[�\��

    [SerializeField] float xSpeed;      //�������̈ړ����x
    [SerializeField] float ySpeed;      //�c�����̈ړ����x

    public bool isLocked;
    public bool GetResult = false;

    [SerializeField] CardInstanceInfo info;
    public GameObject cardObj;

    [SerializeField] Cardmean cardMean;
    [SerializeField] PowerGage gage;
    [SerializeField] LayerMask layerMask;

    // Update is called once per frame
    void Update()
    {
        //���b�N�I����Ԃ���Ȃ��Ƃ��ɓ�������悤�ɂ���
        if (!isLocked)
        {
            TargetMove();
        }

        //�X�y�[�X�L�[���������Ƃ��ɃJ�[�\���̏ꏊ���m�肷��
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isLocked = true;
            

            // �^�b�v�����ꏊ����Ray���쐬
            Ray ray = Camera.main.ScreenPointToRay(this.gameObject.transform.position);
            Vector2 vector2 = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y);

            // Raycast���쐬
            RaycastHit2D hit2d = Physics2D.Raycast(vector2, (Vector2)ray.direction, Mathf.Infinity);

            //Ray�������ɏՓ˂������Ƃ����m & �Փ˂����Ώۂ��������g���𔻕�
            if (hit2d && hit2d.transform.gameObject.CompareTag("Ura"))
            {
                gage.isGageStart = true;
                cardObj = hit2d.transform.gameObject;
                hit2d = Physics2D.Raycast(vector2, (Vector2)ray.direction, Mathf.Infinity, layerMask);
                Debug.Log(hit2d);

                if (hit2d)
                {
                    cardObj = hit2d.transform.gameObject;
                    cardMean = cardObj.GetComponent<Cardmean>();
                    info.CardAfter = cardMean;
                    GetResult = true;
                }

            }
        }
    }
    /// <summary>
    /// ���b�N�I���J�[�\���𓮂����֐�
    /// </summary>
    public void TargetMove()
    {
        //W�L�[�������Ă���Ԃ̏���
        if (Input.GetKey(KeyCode.W))
        {
            targetPoint.transform.position += new Vector3(0, ySpeed, 0);
        }
        //S�L�[�������Ă���Ԃ̏���
        else if (Input.GetKey(KeyCode.S))
        {
            targetPoint.transform.position += new Vector3(0, ySpeed * -1, 0);
        }
        //A�L�[�������Ă���Ԃ̏���
        else if (Input.GetKey(KeyCode.A))
        {
            targetPoint.transform.position += new Vector3(xSpeed * -1, 0, 0);
        }
        //D�L�[�������Ă���Ԃ̏���
        else if (Input.GetKey(KeyCode.D))
        {
            targetPoint.transform.position += new Vector3(xSpeed, 0, 0);
        }
    }
}
