﻿using System;
using UnityEngine;

namespace MarioWorldForAll
{

    public class Enemy : BaseMoveMob 

    {
        // [SerializeField] private LayerMask layerMask;
        [SerializeField] private LayerMask bulletLayer;

        //[SerializeField] private Transform rayCastPoint;
       //  [SerializeField] private float rayCastHeigth;

       // [HideInInspector]
       // public bool isRayCasting = true;

        //private void Update()
        //{
        //    Raycasting();
        //}

        //private void Raycasting()
        //{
        //    if (isRayCasting)
        //    {
        //        RaycastHit2D hit = Physics2D.Raycast(rayCastPoint.position, Vector2.down, rayCastHeigth, layerMask);
        //        Debug.DrawLine(rayCastPoint.position, new Vector2(rayCastPoint.position.x, rayCastPoint.position.y - rayCastHeigth), Color.green);

        //        if (hit.collider != null)
        //        {
        //            DestroyOnDown();
        //            isRayCasting = false;
        //        }
        //    }
        //}

        /*public ov void RayCastHit()
        {
            Destroy(gameObject);
        }*/

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.layer == bulletLayer)
            {
                Kill();
            }
        }

        public virtual void Kill()
        {
            Debug.Log("Kill");
        }
    }
}