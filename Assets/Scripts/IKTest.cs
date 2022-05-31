using UnityEngine;
using System.Collections;

public class IKTest : MonoBehaviour {

  public Transform lookAtObject = null;
  public Transform handR = null;
  public Transform handL = null;
  public Transform waist = null;
  public Transform footR = null;
  public Transform footL = null;

  private Animator animator;

  void Start()
  {
    animator = GetComponent<Animator>();
  }

  void OnAnimatorIK()
  {
    if (lookAtObject != null) {
      animator.SetLookAtWeight(1.0f, 0.8f, 1.0f, 0.0f, 0f);
      animator.SetLookAtPosition(lookAtObject.position);
    }

    if (handR != null) {
      animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 1);
      animator.SetIKRotationWeight(AvatarIKGoal.RightHand, 1);
      animator.SetIKPosition(AvatarIKGoal.RightHand, handR.position);
      animator.SetIKRotation(AvatarIKGoal.RightHand, handR.rotation);
    }

    if (handL != null) {
      animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1);
      animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, 1);
      animator.SetIKPosition(AvatarIKGoal.LeftHand, handL.position);
      animator.SetIKRotation(AvatarIKGoal.LeftHand, handL.rotation);
    }

    if (waist != null) {
      animator.bodyPosition = waist.position;
      animator.bodyRotation = waist.rotation;
    }

    if (footR != null) {
      animator.SetIKPositionWeight(AvatarIKGoal.RightFoot, 1);
      animator.SetIKRotationWeight(AvatarIKGoal.RightFoot, 1);
      animator.SetIKPosition(AvatarIKGoal.RightFoot, footR.position);
      animator.SetIKRotation(AvatarIKGoal.RightFoot, footR.rotation);
    }

    if (footL != null) {
      animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, 1);
      animator.SetIKRotationWeight(AvatarIKGoal.LeftFoot, 1);
      animator.SetIKPosition(AvatarIKGoal.LeftFoot, footL.position);
      animator.SetIKRotation(AvatarIKGoal.LeftFoot, footL.rotation);
    }
  }
}
