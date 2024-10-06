using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ButtonAnimation : MonoBehaviour
{
   public GameObject leaf;
   public Ease easingAnimation;

   [Header("Scale")]
   public Vector3 scaleDownSize;
   public Vector3 originalSizeScale;
   public float animationSpeedScale;
   private bool isScaledDown = false;

   [Header("Zoom")]
   public Vector3 zoomInSize;
   public Vector3 originalSizeZoom;
   public float animationSpeedZoom;
   private bool isZoomin = false;

   [Header("Fly Right")]
   public Vector3 flyRight;
   public Vector3 originalPositionFlyRight;
   public float animationSpeedFlyRight;
   private bool isRight = false;

   [Header("Fly Left")]
   public Vector3 flyLeft;
   public Vector3 originalPositionFlyLeft;
   public float animationSpeedFlyLeft;
   private bool isLeft = false;

   [Header("Pulse")]
   public Vector3 PulseDownSize;
   public Vector3 originalSizePulse;
   public float animationSpeedPulse;

   //Scale
   public void SizeDownUI()
   {
        if (!isScaledDown)
        {
            leaf.transform.DOScale(scaleDownSize, animationSpeedScale).OnComplete(() => isScaledDown = true);
        }
        else
        {
            leaf.transform.DOScale(originalSizeScale, animationSpeedScale).OnComplete(() => isScaledDown = false);
        }

    }

    //Zoom
    public void ZoomInUI()
    {
        if (!isZoomin)
        {
            leaf.transform.DOScale(zoomInSize, animationSpeedZoom).OnComplete(() => isZoomin = true);
        }
        else
        {
            leaf.transform.DOScale(originalSizeZoom, animationSpeedZoom).OnComplete(() => isZoomin = false);
        }
    }

    //Fly Right
    public void FlyRight()
    {
        if (!isRight)
        {
            leaf.transform.DOLocalMove(flyRight, animationSpeedFlyRight).SetEase(easingAnimation).OnComplete(() => isRight = true);
        }
        else
        {
            leaf.transform.DOLocalMove(originalPositionFlyRight, animationSpeedFlyRight).SetEase(easingAnimation).OnComplete(() => isRight = false);
        }
    }

    //Fly Left
    public void FlyLeft()
    {
        if (!isLeft)
        {
            leaf.transform.DOLocalMove(flyLeft, animationSpeedFlyLeft).SetEase(easingAnimation).OnComplete(() => isLeft = true);
        }
        else
        {
            leaf.transform.DOLocalMove(originalPositionFlyLeft, animationSpeedFlyLeft).SetEase(easingAnimation).OnComplete(() => isLeft = false);
        }
    }

    //Shake
    public void Shake()
    {
        leaf.transform.DOShakePosition(0.5f, 10f, 10, 10f);
    }

    //Pulse
    public void Pulse()
    {
        leaf.transform.DOScale(PulseDownSize, animationSpeedPulse).OnComplete(() => leaf.transform.DOScale(originalSizePulse, animationSpeedPulse));
    }
}
