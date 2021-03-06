﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Raavanan
{
    public class ShootingRangeTarget : MonoBehaviour
    {
        [SerializeField]
        private Animator mAnimator;

        public void HitTarget ()
        {
            mAnimator.SetBool("Down", true);
        }

        private void DisableTarget ()
        {
            Destroy(this.gameObject);
        }
    }
}