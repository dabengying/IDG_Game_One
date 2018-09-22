﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace IDG.FightClient
{


    [RequireComponent(typeof(NetObject))]
    public class CircleCollider2D_IDG : MonoBehaviour
    {

        public float r=1;
        public int num=8;
        // Use this for initialization
        void Start()
        {
            GetComponent<NetObject>().net.Shap = new CircleShap(new Ratio(r), num);
        }

        // Update is called once per frame
        void Update()
        {

        }
        public class CircleShap : ShapBase
        {

            public CircleShap(Ratio r,int num)
            {
               
                Ratio t360 = new Ratio(360);
                Ratio tmp = t360 / num;
                V2[] v2s = new V2[num];
                int i = 0;
                for (Ratio tr = new Ratio(0) ; tr < t360&&i<num; tr += tmp,i++)
                {
                    v2s[i] = V2.Parse(tr)*r;
                }
               
                Points = v2s;
            }

        }
    }
}