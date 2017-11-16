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
