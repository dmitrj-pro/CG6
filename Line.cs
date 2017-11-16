﻿using System;
namespace Render
{
	public class Point {
		public double x;
		public double y;
		public double z;

		public Point() { }
		public Point(double _x, double _y) {
			x = _x;
			y = _y;
			z = 0;
		}
		public Point(double _x, double _y, double _z){
			x = _x;
			y = _y;
			z = _z;
		}
		public Matrix ToMatrix2D() {
			Matrix p2 = new Matrix(3, 1);
			p2.Set(x, 0, 0);
			p2.Set(y, 0, 1);
			p2.Set(1, 0, 3);
			return p2;
		}
		public Matrix ToMatrix(){
			Matrix res = new Matrix(4, 1);
			res.Set(x, 0, 0);
			res.Set(y, 0, 1);
			res.Set(z, 0, 2);
			res.Set(1, 0, 3);
			return res;
		}
		/// <summary>
		/// Вывод на консоль координаты точки
		/// </summary>
		public void Print() {
			Console.Write("(");
			Console.Write(x);
			Console.Write(", ");
			Console.Write(y);
			Console.Write(", ");
			Console.Write(z);
			Console.WriteLine(")");
		}
		private void Save(Point x){
			this.x = x.x;
			this.y = x.y;
			this.z = x.z;
		}
		/// <summary>
		/// Сместить точку в двумерном пространстве
		/// </summary>
		/// <param name="x">Смещение по х</param>
		/// <param name="y">Смещение по у</param>
		public void Smestchenie(double x, double y) {
			Point tmp = ToMatrix().Mult(Matrix.Smestchenie(x, y)).ToPoint();
			Save(tmp);
		}
		/// <summary>
		/// Смещение точки в трехмерном пространстве
		/// </summary>
		/// <param name="x">Смещение по х</param>
		/// <param name="y">Смещение по у</param>
		/// <param name="z">Смещение по z</param>
		public void Smestchenie(double x, double y, double z) {
			Point tmp = ToMatrix().Mult(Matrix.Smestchenie(x, y, z)).ToPoint();
			Save(tmp);
		}
		/// <summary>
		/// Повернуть точку вокруг оси координат
		/// </summary>
		/// <param name="d">Угол поворота</param>
		public void Rotate2D(double d){
			Point tmp = ToMatrix().Mult(Matrix.Rotate2D(d)).ToPoint();
			Save(tmp);
		}
		/// <summary>
		/// Поворот вокруг оси OX
		/// </summary>
		/// <param name="x">The x coordinate.</param>
		public void Rotate3Dx(double x){
			Point tmp = ToMatrix().Mult(Matrix.Rotate3Dx(x)).ToPoint();
			Save(tmp);
		}
		/// <summary>
		/// Поворот вокруг оси OY
		/// </summary>
		/// <param name="d">Угол поворота</param>
		public void Rotate3Dy(double d){
			Save(ToMatrix().Mult(Matrix.Rotate3Dy(d)).ToPoint());
		}
		/// <summary>
		/// Повотор вокруг оси OZ
		/// </summary>
		/// <param name="z">Угол поворота</param>
		public void Rotate3Dz(double z) {
			Save(ToMatrix().Mult(Matrix.Rotate3Dz(z)).ToPoint());
		}
		/// <summary>
		/// Изменение размера точки (В 3D НЕ ПРИМЕНЯТЬ)
		/// </summary>
		/// <param name="size">Size.</param>
		public void Scale(double size) {
			Save(ToMatrix().Mult(Matrix.Size(size)).ToPoint());
		}
		/// <summary>
		/// Масштабирование в пространстве
		/// </summary>
		/// <param name="x">Новый масштаб по х</param>
		/// <param name="y">Новый масштаб по у</param>
		/// <param name="z">Новый масштаб по z</param>
		public void Scale(double x, double y, double z) {
			Save(ToMatrix().Mult(Matrix.Size3D(x, y, z)).ToPoint());
		}
	}

	public class Line {
		public Point start;
		public Point end;

		public Line() {
			start = new Point();
			end = new Point();
		}
		public Line(Point start, Point end) {
			this.end = end;
			this.start = start;
		}
		/// <summary>
		/// Сместить линию в двумерном пространстве
		/// </summary>
		/// <param name="x">Смещение по х</param>
		/// <param name="y">Смещение по у</param>
		public void Smestchenie(double x, double y){
			end.Smestchenie(x, y);
			start.Smestchenie(x, y);
		}
		/// <summary>
		/// Смещение линии в трехмерном пространстве
		/// </summary>
		/// <param name="x">Смещение по х</param>
		/// <param name="y">Смещение по у</param>
		/// <param name="z">Смещение по z</param>
		public void Smestchenie(double x, double y, double z) {
			end.Smestchenie(x, y, z);
			start.Smestchenie(x, y, z);
		}
		/// <summary>
		/// Поворот линии в ДВУМЕРНОМ прастарнстве
		/// </summary>
		/// <param name="d">Угол поворота</param>
		public void Rotate2D(double d){
			end.Rotate2D (d);
			start.Rotate2D (d);
		}
		/// <summary>
		/// Поворот линии вокруг оси OX
		/// </summary>
		/// <param name="d">Угол поворота</param>
		public void Rotate3Dx(double d){
			end.Rotate3Dx (d);
			start.Rotate3Dx (d);
		}
		/// <summary>
		/// Поворот линии вокруг оси OY
		/// </summary>
		/// <param name="d">Угол поворота</param>
		public void Rotate3Dy(double d){
			end.Rotate3Dy (d);
			start.Rotate3Dy (d);
		}
		/// <summary>
		/// Поворот линии вокруг оси OZ
		/// </summary>
		/// <param name="d">Угол поворота</param>
		public void Rotate3Dz(double d){
			end.Rotate3Dz (d);
			start.Rotate3Dz (d);
		}
		/// <summary>
		/// Изменение размера точки (В 3D НЕ ПРИМЕНЯТЬ)
		/// </summary>
		/// <param name="s">Size.</param>
		public void Scale(double s){
			end.Scale (s);
			start.Scale (s);
		}
		/// <summary>
		/// Масштабирование в пространстве
		/// </summary>
		/// <param name="x">Новый масштаб по х</param>
		/// <param name="y">Новый масштаб по у</param>
		/// <param name="z">Новый масштаб по z</param>
		public void Scale(double x, double y, double z) {
			end.Scale (x, y, z);
			start.Scale (x, y, z);
		}
	}
}