using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillBoard : MonoBehaviour
{
    [SerializeField] private BillBoardType billBoard;
   public enum BillBoardType{LookAtCamera, CameraForward};


   void LateUpdate()
   {
        switch (billBoard){
            case BillBoardType.LookAtCamera:
                transform.LookAt(Camera.main.transform.position, Vector3.up);
                break;
            case BillBoardType.CameraForward:
                transform.forward = Camera.main.transform.forward;
                break;
            default:
                break;
        }
   }
}
