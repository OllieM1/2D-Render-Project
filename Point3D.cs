using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _2D_Render_Project
{
    public class Point3D
    {
        public int x1 { get; set; }
        public int y1 { get; set; }
        public int z1 { get; set; }

        public Point3D( int x1, int y1, int z1)
        { 
            this .x1 = x1;
            this .y1 = y1;
            this .z1 = z1;
        }
            
        public Point getXYPoint()
        {
            return new Point(x1, y1);
        }

        public Point getZXPoint()
        { 
            return new Point(z1, x1);
        }

        public Point getZYPoint()
        { 
            return new Point(z1, y1);
        }


    }
}
