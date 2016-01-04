using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession1
{
    class Vector3
    {
        protected float x, y, z;

        public Vector3()
        {
        }

        public Vector3(float nx, float ny, float nz)
        {
            x = nx;
            y = ny;
            z = nz;
        }

        //重载操作符
        public static bool operator ==(Vector3 v1,Vector3 v2)
        {
            return v1.x == v2.x && v1.y == v2.y && v1.z == v2.z;
        }

        public static bool operator !=(Vector3 v1,Vector3 v2)
        {
            return v1.x != v2.x || v1.y != v2.y || v1.z != v2.z;
        }

        public static Vector3 operator -(Vector3 v)
        {
            return new Vector3(-v.x,-v.y,-v.z);
        }

        public static Vector3 operator +(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.x+v2.x,v1.y+v2.y,v1.z+v2.z);
        }

        public static Vector3 operator -(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.x-v2.x,v1.y-v2.y,v1.z-v2.z);
        }

        //置为零向量
        public void Zero()
        {
            x = y = z = 0;
        }
        
    }
}
