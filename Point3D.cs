using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Point3D
    {

        private float x;
        private float y;
        private float z;

        public bool IsOnXYPlane {
            get
            {
                if (this.z == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set
            {

            } }

        public bool IsOnAxix
        {
            get
            {
                if (this.z==0 && this.x==0)
                {
                    return true;
                }
                else if(this.z==0 && this.y ==0)
                {
                    return true;
                }
                else if (this.x==0 && this.y ==0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set
            {

            }
        }

        public Point3D(float _x, float _y, float _z)
        {
            this.x = _x;
            this.y = _y;
            this.z = _z;
        }

        public void MoveAlongX(float _x)
        {
            this.x = _x;
        }
        public void CastToXY()
        {
            this.z = 0;
        }
    }
}
