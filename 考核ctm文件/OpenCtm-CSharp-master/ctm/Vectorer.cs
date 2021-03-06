﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctm
{
    class Vectorer
    {

        public float x { set; get; }
        public float y { set; get; }
        public float z { set; get; }

        public Vectorer() { }
        public  Vectorer( float x,float y,float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;         
        }

        /// <summary>
        /// 得到空间两个点之间向量
        /// </summary>
        /// <param name="v1">第一个点的空间坐标位置</param>
        /// <param name="v2">第二个空间点的坐标位置</param>
        /// <returns>两个点构成的空间向量</returns>
        public Vectorer GetSubVector(Vectorer v1,Vectorer v2)
        {
            Vectorer subVector = new Vectorer();
            subVector.x = v2.x - v1.x;
            subVector.y = v2.y - v1.y;
            subVector.z = v2.z - v1.z;
            return subVector;
        }

       /// <summary>
       /// 计算一个平面的法向量
       /// </summary>
       /// <param name="v1">平面的一个向量</param>
       /// <param name="v2">平面的另一个向量</param>
       /// <returns>平面的法向量</returns>
        public Vectorer GetNormalVector(Vectorer v1,Vectorer v2)
        {
            Vectorer normalVector = new Vectorer();
            normalVector.x = v1.y * v2.z - v2.y * v1.z;
            normalVector.y = v2.x * v1.z - v1.x * v2.z;
            normalVector.z = v1.x * v2.y - v2.x * v1.y;
            return normalVector;
        }

        /// <summary>
        /// 单位化向量
        /// </summary>
        /// <param name="v">传进去的空间向量</param>
        /// <returns>单位化后的向量输出</returns>
        public Vectorer GetInitVector(Vectorer v)
        {
            Vectorer initVector = new Vectorer();
            float sum = (float)Math.Sqrt(v.x * v.x + v.y * v.y + v.z * v.z);
            initVector.x = v.x / sum;
            initVector.y = v.y / sum;
            initVector.z = v.z / sum;
            return initVector;

        }

    }
}
