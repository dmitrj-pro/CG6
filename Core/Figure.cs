using System;
using System.Collections.Generic;

namespace Render {
	public class Figure {
		private List<Line> lines;

		public void Add(Line l) {
			lines.Add(l);
		}

		public Figure(){
			lines = new List<Line>();
		}
		public List<Line> GetLines(){
			return lines;
		}
		/// <summary>
		/// Поворот фигуры вокруг оси OX
		/// </summary>
		/// <param name="d">Угол поворота</param>
		public void RotateX(double d){
			for (int i=0; i< lines.Count; i++) {
				lines [i].Rotate3Dx (d);
			}
		}
		/// <summary>
		/// Поворот фигуры вокруг оси OY
		/// </summary>
		/// <param name="d">Угол поворота</param>
		public void RotateY(double d){
			for (int i=0; i< lines.Count; i++) {
				lines [i].Rotate3Dy (d);
			}
		}
		/// <summary>
		/// Поворот фигуры вокруг оси OZ
		/// </summary>
		/// <param name="d">Угол поворота</param>
		public void RotateZ(double d){
			for (int i=0; i< lines.Count; i++) {
				lines [i].Rotate3Dz (d);
			}
		}

		/// <summary>
		/// Поворот фигуры вокруг прямой _line на угол angle
		/// </summary>
		/// <param name="_line">Линия, вокруг которой будем поворачивать</param>
		/// <param name="angle">Угол поворота</param>
		public void Rotate(Line _line, double angle){
			Point3d normalize;

			{
				double x = _line.start.x - _line.end.x;
				double y = _line.start.y - _line.end.y;
				double z = _line.start.z - _line.end.z;
				double length = Math.Sqrt (x * x + y * y + z * z);
				normalize = new Point3d (x / length, y / length, z / length);
			}
			double d = Math.Sqrt (normalize.y * normalize.y + normalize.z * normalize.z);
			double alpha = -Math.Asin (normalize.y / d);
			double beta = Math.Asin (normalize.x);
			for (int i = 0; i < lines.Count; i++) {
				lines [i].Smestchenie ((-1) * _line.start.x, (-1) * _line.start.y, (-1) * _line.start.z);

				lines [i].Rotate3Dx (alpha);
				lines [i].Rotate3Dy (beta);
				lines [i].Rotate3Dz (angle);
				lines [i].Rotate3Dy (-beta);
				lines [i].Rotate3Dx (-alpha);

				lines [i].Smestchenie (_line.start.x, _line.start.y, _line.start.z);
			}

					
		}

		/*
        private void axisRotate(myPoint pt1, myPoint pt2, double angle) // поворот вокруг оси
        {
            myPoint c = normalizeVector(pt1, pt2);
            double x = c.X, y = c.Y, z = c.Z;      
            double d = Math.Sqrt(y * y + z * z);
            double alpha = -Math.Asin(y / d);
            double beta = Math.Asin(x);

            foreach (myPoint p in points)
            {
                p.X -= pt1.X;
                p.Y -= pt1.Y;
                p.Z -= pt1.Z;

                rotateX(p, alpha);
                rotateY(p, beta);
                rotateZ(p, angle);
                rotateY(p, -beta);
                rotateX(p, -alpha);

                p.X += pt1.X;
                p.Y += pt1.Y;
                p.Z += pt1.Z;
            }
            */
		/// <summary>
		/// Смещение фигуры в трехмерном пространстве
		/// </summary>
		/// <param name="x">Смещение по х</param>
		/// <param name="y">Смещение по у</param>
		/// <param name="z">Смещение по z</param>
		public void Smestchenie(double x, double y, double z) {
			for (int i=0; i< lines.Count; i++) {
				lines [i].Smestchenie (x, y, z);
			}
		}
		/// <summary>
		/// Масштабирование в пространстве
		/// </summary>
		/// <param name="x">Новый масштаб по х</param>
		/// <param name="y">Новый масштаб по у</param>
		/// <param name="z">Новый масштаб по z</param>
		public void Scale(double x, double y, double z) {
			for (int i=0; i< lines.Count; i++) {
				lines [i].Scale (x, y, z);
			}
		}
	}
}
