﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
	internal class Point
	{
		/*double x;// Smallcamal
		double y;
		public double X//Prop
		{
			get 
			{ 
				return x; 
			} 
			set 
			{ 
				if (value >200) value= 200;
				x = value;//ключевое слово Value дает принимаемое значение
			} 
		}

		public double Y
		{
			get
			{
				return y;
			}
			set
			{
				if (value > 150) value = 150;
				y = value;
			}
		}
		public double GetX()
		{

		return x; 
		}
		public double GetY()
		{
			return y;
		}
		public void SetX(double x)
		{
			if(x > 200) x = 200;
			this.x = x;
		}
		public void SetY(double y)
		{
			if (y > 150) y = 150;
			this.y = y;
		}*/
		public double X { get; set; } // авто свойсьва
		public double Y { get; set; } // авто свойства	


		public Point(double x = 0, double y = 0)
		{
			this.X = x;
			Y = y;
			Console.WriteLine($"DefaultConstructor:{this.GetHashCode()}");
		}

		public Point(Point other)
		{
			this.X = other.X;
			this.Y = other.Y;
			Console.WriteLine($"CopyConstructor:{GetHashCode()}");
		}
		~Point()
		{
			Console.WriteLine($"Destructor:\t{this.GetHashCode()}");
		}

		public static Point operator +(Point left, Point right)
		{
			Point res = new Point();
			res.X = left.X + right.X;
			res.Y = left.Y + right.Y;
			return res;
		}

		public static Point operator -(Point left,Point right )
		{
			return new Point
			(
				left.X - right.X,
				left.Y - right.Y
				);
		}

		public static Point operator++(Point obj)
		{
			obj.X++;
			obj.Y++;
			return obj;
		}

		public static bool operator ==(Point left, Point right)
		{
			return left.X==right.X && left.Y== right.Y;
		}
		public static bool operator !=(Point left, Point right)
		{
			return !(left == right);
		}

		public void Print()
		{
			Console.WriteLine($"X={X}\tY={Y}");
		}
		/*public double Distance(Point other)
		{ 

		}*/
	}
}
