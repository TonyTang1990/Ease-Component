/*
 * Description:             TShakePosAnimation.cs
 * Author:                  TANGHUAN
 * Create Date:             2020/06/03
 */

using System;
using UnityEngine;

namespace TAnimation
{
    /// <summary>
    /// ��ֵλ�ö�������
    /// </summary>
    public class TShakePosAnimation : TShakeBaseAnimation
    {
        /// <summary>
        /// ��ʼ����λ��
        /// </summary>
        protected Vector3 mBeginLocalPos;

        /// <summary>
        /// ��Ӧ��ֵ������ʼ
        /// </summary>
        protected override void OnLerpAnimStart()
        {
            base.OnLerpAnimStart();
            mBeginLocalPos = transform.localPosition;
        }

        /// <summary>
        /// �ζ�λ��
        /// </summary>
        /// <param name="offset"></param>
        protected override void OnShake(Vector3 offset)
        {
            transform.localPosition = mBeginLocalPos + offset;
        }

        /// <summary>
        /// ����ʱ�ָ�
        /// </summary>
        protected override void Restore()
        {
            transform.localPosition = mBeginLocalPos;
        }
    }
}