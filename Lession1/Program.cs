using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession1
{
    class Vector3
    {
        public float x, y, z;

        public Vector3()
        {
        }

        public Vector3(float nx, float ny, float nz)
        {
            x = nx;
            y = ny;
            z = nz;
        }

        public override string ToString()
        {
            return "x=" + x+" y="+y+" z="+z;
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

        //向量取反
        public static Vector3 operator -(Vector3 v)
        {
            return new Vector3(-v.x,-v.y,-v.z);
        }

        //向量加减
        public static Vector3 operator +(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.x+v2.x,v1.y+v2.y,v1.z+v2.z);
        }

        public static Vector3 operator -(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.x-v2.x,v1.y-v2.y,v1.z-v2.z);
        }

        //向量和标量的乘法
        public static Vector3 operator *(Vector3 v, float a)
        {
            return new Vector3(v.x*a,v.y*a,v.z*a);
        }
        public static Vector3 operator *(float a, Vector3 v)
        {
            return v * a;
        }
        //向量和标量的除法 标量不能除以向量
        public static Vector3 operator /(Vector3 v, float a)
        {
            return new Vector3(v.x*(1/a),v.y*(1/a),v.z*(1/a));
        }

        //向量的乘法 点乘
        public static float operator *(Vector3 v1, Vector3 v2)
        {
            return v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
        }

        //叉乘
        public static Vector3 CrossProduct(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.y*v2.z-v1.z*v2.y,v1.z*v2.x-v1.x*v2.z,v1.x*v2.y-v1.y*v2.x);
        }

        //求向量的模
        public float VectorMag()
        {
            return (float)Math.Sqrt(x*x+y*y+z*z);
        }
        //向量的标准化
        public Vector3 Normalize()
        {
            return new Vector3(x/VectorMag(),y/VectorMag(),z/VectorMag());
        }
        public void normalize()
        {
            x *= 1 / VectorMag();
            y *= 1 / VectorMag();
            z *= 1 / VectorMag();
        }
        //计算俩点间的距离
        public float Distance(Vector3 v1, Vector3 v2)
        {
            return (float)Math.Sqrt((v1.x-v2.x)*(v1.x-v2.x)+(v1.y-v2.y)*(v1.y-v2.y)+(v1.z-v2.z)*(v1.z-v2.z));
        }

        //置为零向量
        public void Zero()
        {
            x = y = z = 0;
        }

        public static void Main()
        {
            Vector3 v1 = new Vector3(1,1,1);
            Vector3 v2 = new Vector3(2,2,2);
            Console.WriteLine(v1 + v2);
            Console.ReadLine();
            
        }
        
        
    }
}
