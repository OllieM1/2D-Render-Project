using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Render_Project
{
    public class Vector3D
    { 
        public double i {  get; set; }
        public double j { get; set; }
        public double k { get; set; }


        public Vector3D(double i, double j, double k) 
        {
            this.i = i;
            this.j = j;
            this.k = k;
        }


        public Vector3D(Point3D p1, Point3D p2)
        {
            i = p2.x1 - p1.x1;
            j = p2.y1 - p1.y1;
            k = p2.z1 - p1.z1;
        }
    
        public double magnitude()
        {             
            return Math.Pow(i * i + j * j + k * k, 0.5);
        }

        public Vector3D scale(int factor)
        {
            return new Vector3D(i * factor, j * factor, k * factor);
        }

        public Vector3D unit() 
        {
            double mag = magnitude();
            return new Vector3D(i /  mag, j / mag, k / mag);
        }

        public static double dotproduct(Vector3D v1, Vector3D v2) 
        { 
            return v1.i*v2.i + v1.j*v2.j + v1.k*v2.k;                        
        }

        public static double anglescos(Vector3D v1, Vector3D v2)
        {
            return dotproduct(v1,v2)/(v1.magnitude()*v2.magnitude());
        }


    }

}
