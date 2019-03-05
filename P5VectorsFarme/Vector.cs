using System;

namespace P5VectorsFramework
{
    public class Vector
    {
        private double _x;
        private double _y;
        private double _z;

        public double Length { get { return Math.Sqrt(_x * _x + _y * _y + _z * _z); } }

        public double AngleAlfa { get { return Math.Acos(_x / this.Length); } }
        public double AngleBeta { get { return Math.Acos(_y / this.Length); } }
        public double AngleGamma { get { return Math.Acos(_z / this.Length); } }


        public Vector()
        {
            _x = 0;
            _y = 0;
            _z = 0;
        }

        public Vector(double x, double y)
        {
            _x = x;
            _y = y;
            _z = 0;
        }

        public Vector(double x, double y, double z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public void Set(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public void Set(double x, double y, double z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public void Copy(Vector a)
        {
            this._x = a._x;
            this._y = a._y;
            this._z = a._z;
        }

        public static double AngleBetween(Vector a, Vector b)
        {
            return (a._x * b._x + a._y * b._y + a._z * b._z) / (a.Length * b.Length);
        }

        public void SetMag(double a)
        {
            _x = _x / this.Length * a;
            _y = _y / this.Length * a;
            _z = _z / this.Length * a;
        }

        public static Vector operator + (Vector a, Vector b)
        {
            return new Vector(a._x + b._x, a._y + b._y);
        }

        public static Vector operator - (Vector a, Vector b)
        {
            return new Vector(a._x + b._x, a._y + b._y);
        }

        public static Vector operator * (Vector a, int b)
        {
            return new Vector(a._x * b, a._y * b);
        }

        public static Vector operator / (Vector a, int b)
        {
            return new Vector(a._x / b, a._y / b);
        }

        public static Vector operator * (int a, Vector b)
        {
            return b * a;
        }
         
        public static Vector operator / (int a, Vector b)
        {
            return b / a;
        }
    }
}
