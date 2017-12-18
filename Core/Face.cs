using System;
using System.Collections.Generic;

namespace Render
{
	class Coefficient_Of_Plane
	{
		public double A, B, C, D;
		public Coefficient_Of_Plane(){
			A = B = C = D = 0;
		}
	}

	public class Face
	{
		private List<Point3d> _points;

		public List<Point3d> Points (){ return _points; }

		public Face (List<Point3d> points){
			_points = points;
		}
		public Face (){
			_points = new List<Point3d> ();
		}
		public void Add(Point3d p){
			_points.Add (p);
		}
		public bool isFacial() { // является ли грань лицевой
			Point3d p1 = _points[1];
			Point3d p2 = _points[2];
			Point3d p3 = _points[0];
			double aX = p1.x - p3.x, aY = p1.y - p3.y, bX = p2.x - p3.x, bY = p2.y - p3.y;
			return (aY * bX - aX * bY < 0);
		}
		public bool Cont(Point3d p){
			for (int i = 0; i < _points.Count; i++) {
				if (_points [i].Equals (p))
					return true;
			}
			return false;
		}
		public virtual bool Equal(Face f){
			int c = 0;
			if (_points.Count != f._points.Count)
				return false;
			
			for (int i = 0; i < _points.Count; i++) {
				for (int j = 0; j < f._points.Count; j++) {
					if (_points [i].Equals (f._points [j])) {
						c++;
						break;
					}
				}
			}
			return c == _points.Count;
		}
		public bool isIn(Point3d p){
			Matrix m = new Matrix (3, 3);
			Point3d p1 = _points[0];
			Point3d p2 = _points[1];
			Point3d p3 = _points[2];

			m.Set (p.x - p1.x, 0, 0);
			m.Set (p.y - p1.y, 0, 1);
			m.Set (p.z - p1.z, 0, 2);
			m.Set (p2.x - p1.x, 1, 0);
			m.Set (p2.y - p1.y, 1, 1);
			m.Set (p2.z - p1.z, 1, 2);
			m.Set (p3.x - p1.x, 2, 0);
			m.Set (p3.y - p1.y, 2, 1);
			m.Set (p3.z - p1.z, 2, 2);

			return m.Det() == 0;

		}
		public void Println(){
			for (int i = 0; i < _points.Count; i++) {
				_points [i].Print ();
			}
			Console.WriteLine ();
		}
		public Point3d Normal(){
			Matrix m = new Matrix (3, 3);
			Point3d p1 = _points[0];
			Point3d p2 = _points[1];
			Point3d p3 = _points[2];

			m.Set (p2.x - p1.x, 1, 0);
			m.Set (p2.y - p1.y, 1, 1);
			m.Set (p2.z - p1.z, 1, 2);
			m.Set (p3.x - p1.x, 2, 0);
			m.Set (p3.y - p1.y, 2, 1);
			m.Set (p3.z - p1.z, 2, 2);

			// Почти уравнение плоскости
			var x = m.Get (1, 1) * m.Get (2, 2) - m.Get (1, 2) * m.Get (2, 1);
			var y = m.Get (0, 1) * m.Get (2, 2) - m.Get (1, 2) * m.Get (2, 0);
			var z = m.Get (1, 0) * m.Get (2, 1) - m.Get (1, 1) * m.Get (2, 0);

			Point3d res = new Point3d (x, y, z);
			return res;
		}

		private bool CheckInside(Point3d point1, Point3d point2, Point3d point3, int x, int y) {
			double fxyC, fxy;
			fxyC = point3.y * (point2.x - point1.x) - point3.x * (point2.y - point1.y) + point1.x * (point2.y - point1.y) - point1.y * (point2.x - point1.x);
			//fxyC = point3.Y * (point2.X - point1.X) - point3.X * (point2.Y - point1.Y) + point1.X * (point2.Y - point1.Y) - point1.Y * (point2.X - point1.X);
			//fxy =  y * (point2.X - point1.X) - x * (point2.Y - point1.Y) + point1.X * (point2.Y - point1.Y) - point1.Y * (point2.X - point1.X);
			fxy =  y * (point2.x - point1.x) - x * (point2.y - point1.y) + point1.x * (point2.y - point1.y) - point1.y * (point2.x - point1.x);
			if (((fxyC <= 0) && (fxy <= 0)) || ((fxyC >= 0) && (fxy >= 0)))
				return true;
			else
				return false;
		}
		//Subroutine to check any point(x,y) inside the triangle
		public bool Inside(int x, int y) {
			bool res = false;
			for (int i = 0; i < _points.Count; i++) {
				Point3d pt1 = _points[i % _points.Count];
				Point3d pt2 = _points[(i +1 )% _points.Count];
				Point3d pt3 = _points[(i +2 )% _points.Count];

				bool check = CheckInside(pt1, pt2, pt3, x, y) && CheckInside(pt2, pt3, pt1, x, y) && CheckInside(pt3, pt1, pt2, x, y);
				if (check == true)
					res = true;
			}
			return res;
		}
		static public double MaxValue(){
			return 400;
		}
		public double DepthValue(int x,int y){
			double z = MaxValue ();
			for (int i = 0; i < _points.Count; i++) {
				Point3d pt1 = _points[(i)% _points.Count];
				Point3d pt2 = _points[(i + 1 )% _points.Count];
				Point3d pt3 = _points[(i + 2 )% _points.Count];

				Coefficient_Of_Plane surface;
				surface = new Coefficient_Of_Plane();
				surface.A = (pt2.z - pt3.z) * (pt1.y - pt2.y) - (pt1.z - pt2.z) * (pt2.y - pt3.y);
				surface.B = (pt2.x - pt3.x) * (pt1.z - pt2.z) - (pt1.x - pt2.x) * (pt2.z - pt3.z);
				surface.C = (pt2.y - pt3.y) * (pt1.x - pt2.x) - (pt1.y - pt2.y) * (pt2.x - pt3.x);
				surface.D = - pt1.x * (pt2.y * pt3.z - pt2.z * pt3.y) + pt1.y * (pt2.x * pt3.z - pt2.z * pt3.x) - pt1.z * (pt2.x * pt3.y - pt2.y * pt3.x);

				/*pt.A = (pt2.z - pt3.z) * (pt1.y - pt2.y) - (pt1.z - pt2.z) * (pt2.y - pt3.y);
				pt.B = (pt2.x - pt3.x) * (pt1.z - pt2.z) - (pt1.x - pt2.x) * (pt2.z - pt3.z);
				pt.C = (pt2.y - pt3.y) * (pt1.x - pt2.x) - (pt1.y - pt2.y) * (pt2.x - pt3.x);
				pt.D = - pt1.x * (pt2.y * pt3.z - pt2.z * pt3.y) + pt1.y * (pt2.x * pt3.z - pt2.z * pt3.x) - pt1.z * (pt2.x * pt3.y - pt2.y * pt3.x);

				/*surface.A = (pt3.z - pt2.z) * (pt1.y - pt2.y) - (pt2.z - pt1.z) * (pt2.y - pt3.y);
				surface.B = (pt2.x - pt3.x) * (pt2.z - pt1.z) - (pt1.x - pt2.x) * (pt3.z - pt2.z);
				surface.C = (pt2.y - pt3.y) * (pt1.x - pt2.x) - (pt1.y - pt2.y) * (pt2.x - pt3.x);
				surface.D = - pt1.x * (pt2.y * pt2.z - pt3.z * pt3.y) + pt1.y * (pt2.x * pt2.z - pt3.z * pt3.x) - pt1.z * (pt2.x * pt3.y - pt2.y * pt3.x);*/

				if (surface.B != 0)
					z = (surface.A * x + surface.C * y + surface.D) / surface.B;
				else 
					z = (surface.A * x + surface.C * y + surface.D) / 0.001;
			}
			return z;
		}

	}
}

