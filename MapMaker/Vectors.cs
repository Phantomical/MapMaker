using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapMaker
{
	public struct Vec2
	{
		public float X;
		public float Y;

		public Vec2(float x, float y)
		{
			X = x;
			Y = y;
		}

		#region 2D
		public Vec2 Xx
		{
			get { return new Vec2(X, X); }
			set { X = value.X; X = value.Y; }
		}
		public Vec2 Xy
		{
			get { return new Vec2(X, Y); }
			set { X = value.X; Y = value.Y; }
		}
		public Vec2 Yx
		{
			get { return new Vec2(Y, X); }
			set { Y = value.X; X = value.Y; }
		}
		public Vec2 Yy
		{
			get { return new Vec2(Y, Y); }
			set { Y = value.X; Y = value.Y; }
		}
		#endregion

	}

	public struct Vec3
	{
		public float X, Y, Z;

		public Vec3(float x, float y, float z)
		{
			X = x;
			Y = y;
			Z = z;
		}

		#region 2D
		public Vec2 Xx
		{
			get { return new Vec2(X, X); }
			set { X = value.X; X = value.Y; }
		}
		public Vec2 Xy
		{
			get { return new Vec2(X, Y); }
			set { X = value.X; Y = value.Y; }
		}
		public Vec2 Xz
		{
			get { return new Vec2(X, Z); }
			set { X = value.X; Z = value.Y; }
		}
		public Vec2 Yx
		{
			get { return new Vec2(Y, X); }
			set { Y = value.X; X = value.Y; }
		}
		public Vec2 Yy
		{
			get { return new Vec2(Y, Y); }
			set { Y = value.X; Y = value.Y; }
		}
		public Vec2 Yz
		{
			get { return new Vec2(Y, Z); }
			set { Y = value.X; Z = value.Y; }
		}
		public Vec2 Zx
		{
			get { return new Vec2(Z, X); }
			set { Z = value.X; X = value.Y; }
		}
		public Vec2 Zy
		{
			get { return new Vec2(Z, Y); }
			set { Z = value.X; Y = value.Y; }
		}
		public Vec2 Zz
		{
			get { return new Vec2(Z, Z); }
			set { Z = value.X; Z = value.Y; }
		}
		#endregion

		#region 3D
		public Vec3 Xxx
		{
			get { return new Vec3(X, X, X); }
			set { X = value.X; X = value.Y; X = value.Z; }
		}
		public Vec3 Xxy
		{
			get { return new Vec3(X, X, Y); }
			set { X = value.X; X = value.Y; Y = value.Z; }
		}
		public Vec3 Xxz
		{
			get { return new Vec3(X, X, Z); }
			set { X = value.X; X = value.Y; Z = value.Z; }
		}
		public Vec3 Xyx
		{
			get { return new Vec3(X, Y, X); }
			set { X = value.X; Y = value.Y; X = value.Z; }
		}
		public Vec3 Xyy
		{
			get { return new Vec3(X, Y, Y); }
			set { X = value.X; Y = value.Y; Y = value.Z; }
		}
		public Vec3 Xyz
		{
			get { return new Vec3(X, Y, Z); }
			set { X = value.X; Y = value.Y; Z = value.Z; }
		}
		public Vec3 Xzx
		{
			get { return new Vec3(X, Z, X); }
			set { X = value.X; Z = value.Y; X = value.Z; }
		}
		public Vec3 Xzy
		{
			get { return new Vec3(X, Z, Y); }
			set { X = value.X; Z = value.Y; Y = value.Z; }
		}
		public Vec3 Xzz
		{
			get { return new Vec3(X, Z, Z); }
			set { X = value.X; Z = value.Y; Z = value.Z; }
		}
		public Vec3 Yxx
		{
			get { return new Vec3(Y, X, X); }
			set { Y = value.X; X = value.Y; X = value.Z; }
		}
		public Vec3 Yxy
		{
			get { return new Vec3(Y, X, Y); }
			set { Y = value.X; X = value.Y; Y = value.Z; }
		}
		public Vec3 Yxz
		{
			get { return new Vec3(Y, X, Z); }
			set { Y = value.X; X = value.Y; Z = value.Z; }
		}
		public Vec3 Yyx
		{
			get { return new Vec3(Y, Y, X); }
			set { Y = value.X; Y = value.Y; X = value.Z; }
		}
		public Vec3 Yyy
		{
			get { return new Vec3(Y, Y, Y); }
			set { Y = value.X; Y = value.Y; Y = value.Z; }
		}
		public Vec3 Yyz
		{
			get { return new Vec3(Y, Y, Z); }
			set { Y = value.X; Y = value.Y; Z = value.Z; }
		}
		public Vec3 Yzx
		{
			get { return new Vec3(Y, Z, X); }
			set { Y = value.X; Z = value.Y; X = value.Z; }
		}
		public Vec3 Yzy
		{
			get { return new Vec3(Y, Z, Y); }
			set { Y = value.X; Z = value.Y; Y = value.Z; }
		}
		public Vec3 Yzz
		{
			get { return new Vec3(Y, Z, Z); }
			set { Y = value.X; Z = value.Y; Z = value.Z; }
		}
		public Vec3 Zxx
		{
			get { return new Vec3(Z, X, X); }
			set { Z = value.X; X = value.Y; X = value.Z; }
		}
		public Vec3 Zxy
		{
			get { return new Vec3(Z, X, Y); }
			set { Z = value.X; X = value.Y; Y = value.Z; }
		}
		public Vec3 Zxz
		{
			get { return new Vec3(Z, X, Z); }
			set { Z = value.X; X = value.Y; Z = value.Z; }
		}
		public Vec3 Zyx
		{
			get { return new Vec3(Z, Y, X); }
			set { Z = value.X; Y = value.Y; X = value.Z; }
		}
		public Vec3 Zyy
		{
			get { return new Vec3(Z, Y, Y); }
			set { Z = value.X; Y = value.Y; Y = value.Z; }
		}
		public Vec3 Zyz
		{
			get { return new Vec3(Z, Y, Z); }
			set { Z = value.X; Y = value.Y; Z = value.Z; }
		}
		public Vec3 Zzx
		{
			get { return new Vec3(Z, Z, X); }
			set { Z = value.X; Z = value.Y; X = value.Z; }
		}
		public Vec3 Zzy
		{
			get { return new Vec3(Z, Z, Y); }
			set { Z = value.X; Z = value.Y; Y = value.Z; }
		}
		public Vec3 Zzz
		{
			get { return new Vec3(Z, Z, Z); }
			set { Z = value.X; Z = value.Y; Z = value.Z; }
		}
		#endregion

	}

	public struct Vec4
	{
		public float X, Y, Z, W;

		public float R
		{
			get
			{
				return X;
			}
			set
			{
				X = value;
			}
		}
		public float G
		{
			get
			{
				return Y;
			}
			set
			{
				Y = value;
			}
		}
		public float B
		{
			get
			{
				return Z;
			}
			set
			{
				Z = value;
			}
		}
		public float A
		{
			get
			{
				return W;
			}
			set
			{
				W = value;
			}
		}

		public Vec4(float x, float y, float z, float w)
		{
			X = x;
			Y = y;
			Z = z;
			W = w;
		}

		#region XYZW
		#region 2D
		public Vec2 Xx
		{
			get { return new Vec2(X, X); }
			set { X = value.X; X = value.Y; }
		}
		public Vec2 Xy
		{
			get { return new Vec2(X, Y); }
			set { X = value.X; Y = value.Y; }
		}
		public Vec2 Xz
		{
			get { return new Vec2(X, Z); }
			set { X = value.X; Z = value.Y; }
		}
		public Vec2 Xw
		{
			get { return new Vec2(X, W); }
			set { X = value.X; W = value.Y; }
		}
		public Vec2 Yx
		{
			get { return new Vec2(Y, X); }
			set { Y = value.X; X = value.Y; }
		}
		public Vec2 Yy
		{
			get { return new Vec2(Y, Y); }
			set { Y = value.X; Y = value.Y; }
		}
		public Vec2 Yz
		{
			get { return new Vec2(Y, Z); }
			set { Y = value.X; Z = value.Y; }
		}
		public Vec2 Yw
		{
			get { return new Vec2(Y, W); }
			set { Y = value.X; W = value.Y; }
		}
		public Vec2 Zx
		{
			get { return new Vec2(Z, X); }
			set { Z = value.X; X = value.Y; }
		}
		public Vec2 Zy
		{
			get { return new Vec2(Z, Y); }
			set { Z = value.X; Y = value.Y; }
		}
		public Vec2 Zz
		{
			get { return new Vec2(Z, Z); }
			set { Z = value.X; Z = value.Y; }
		}
		public Vec2 Zw
		{
			get { return new Vec2(Z, W); }
			set { Z = value.X; W = value.Y; }
		}
		public Vec2 Wx
		{
			get { return new Vec2(W, X); }
			set { W = value.X; X = value.Y; }
		}
		public Vec2 Wy
		{
			get { return new Vec2(W, Y); }
			set { W = value.X; Y = value.Y; }
		}
		public Vec2 Wz
		{
			get { return new Vec2(W, Z); }
			set { W = value.X; Z = value.Y; }
		}
		public Vec2 Ww
		{
			get { return new Vec2(W, W); }
			set { W = value.X; W = value.Y; }
		}
		#endregion

		#region 3D
		public Vec3 Xxx
		{
			get { return new Vec3(X, X, X); }
			set { X = value.X; X = value.Y; X = value.Z; }
		}
		public Vec3 Xxy
		{
			get { return new Vec3(X, X, Y); }
			set { X = value.X; X = value.Y; Y = value.Z; }
		}
		public Vec3 Xxz
		{
			get { return new Vec3(X, X, Z); }
			set { X = value.X; X = value.Y; Z = value.Z; }
		}
		public Vec3 Xxw
		{
			get { return new Vec3(X, X, W); }
			set { X = value.X; X = value.Y; W = value.Z; }
		}
		public Vec3 Xyx
		{
			get { return new Vec3(X, Y, X); }
			set { X = value.X; Y = value.Y; X = value.Z; }
		}
		public Vec3 Xyy
		{
			get { return new Vec3(X, Y, Y); }
			set { X = value.X; Y = value.Y; Y = value.Z; }
		}
		public Vec3 Xyz
		{
			get { return new Vec3(X, Y, Z); }
			set { X = value.X; Y = value.Y; Z = value.Z; }
		}
		public Vec3 Xyw
		{
			get { return new Vec3(X, Y, W); }
			set { X = value.X; Y = value.Y; W = value.Z; }
		}
		public Vec3 Xzx
		{
			get { return new Vec3(X, Z, X); }
			set { X = value.X; Z = value.Y; X = value.Z; }
		}
		public Vec3 Xzy
		{
			get { return new Vec3(X, Z, Y); }
			set { X = value.X; Z = value.Y; Y = value.Z; }
		}
		public Vec3 Xzz
		{
			get { return new Vec3(X, Z, Z); }
			set { X = value.X; Z = value.Y; Z = value.Z; }
		}
		public Vec3 Xzw
		{
			get { return new Vec3(X, Z, W); }
			set { X = value.X; Z = value.Y; W = value.Z; }
		}
		public Vec3 Xwx
		{
			get { return new Vec3(X, W, X); }
			set { X = value.X; W = value.Y; X = value.Z; }
		}
		public Vec3 Xwy
		{
			get { return new Vec3(X, W, Y); }
			set { X = value.X; W = value.Y; Y = value.Z; }
		}
		public Vec3 Xwz
		{
			get { return new Vec3(X, W, Z); }
			set { X = value.X; W = value.Y; Z = value.Z; }
		}
		public Vec3 Xww
		{
			get { return new Vec3(X, W, W); }
			set { X = value.X; W = value.Y; W = value.Z; }
		}
		public Vec3 Yxx
		{
			get { return new Vec3(Y, X, X); }
			set { Y = value.X; X = value.Y; X = value.Z; }
		}
		public Vec3 Yxy
		{
			get { return new Vec3(Y, X, Y); }
			set { Y = value.X; X = value.Y; Y = value.Z; }
		}
		public Vec3 Yxz
		{
			get { return new Vec3(Y, X, Z); }
			set { Y = value.X; X = value.Y; Z = value.Z; }
		}
		public Vec3 Yxw
		{
			get { return new Vec3(Y, X, W); }
			set { Y = value.X; X = value.Y; W = value.Z; }
		}
		public Vec3 Yyx
		{
			get { return new Vec3(Y, Y, X); }
			set { Y = value.X; Y = value.Y; X = value.Z; }
		}
		public Vec3 Yyy
		{
			get { return new Vec3(Y, Y, Y); }
			set { Y = value.X; Y = value.Y; Y = value.Z; }
		}
		public Vec3 Yyz
		{
			get { return new Vec3(Y, Y, Z); }
			set { Y = value.X; Y = value.Y; Z = value.Z; }
		}
		public Vec3 Yyw
		{
			get { return new Vec3(Y, Y, W); }
			set { Y = value.X; Y = value.Y; W = value.Z; }
		}
		public Vec3 Yzx
		{
			get { return new Vec3(Y, Z, X); }
			set { Y = value.X; Z = value.Y; X = value.Z; }
		}
		public Vec3 Yzy
		{
			get { return new Vec3(Y, Z, Y); }
			set { Y = value.X; Z = value.Y; Y = value.Z; }
		}
		public Vec3 Yzz
		{
			get { return new Vec3(Y, Z, Z); }
			set { Y = value.X; Z = value.Y; Z = value.Z; }
		}
		public Vec3 Yzw
		{
			get { return new Vec3(Y, Z, W); }
			set { Y = value.X; Z = value.Y; W = value.Z; }
		}
		public Vec3 Ywx
		{
			get { return new Vec3(Y, W, X); }
			set { Y = value.X; W = value.Y; X = value.Z; }
		}
		public Vec3 Ywy
		{
			get { return new Vec3(Y, W, Y); }
			set { Y = value.X; W = value.Y; Y = value.Z; }
		}
		public Vec3 Ywz
		{
			get { return new Vec3(Y, W, Z); }
			set { Y = value.X; W = value.Y; Z = value.Z; }
		}
		public Vec3 Yww
		{
			get { return new Vec3(Y, W, W); }
			set { Y = value.X; W = value.Y; W = value.Z; }
		}
		public Vec3 Zxx
		{
			get { return new Vec3(Z, X, X); }
			set { Z = value.X; X = value.Y; X = value.Z; }
		}
		public Vec3 Zxy
		{
			get { return new Vec3(Z, X, Y); }
			set { Z = value.X; X = value.Y; Y = value.Z; }
		}
		public Vec3 Zxz
		{
			get { return new Vec3(Z, X, Z); }
			set { Z = value.X; X = value.Y; Z = value.Z; }
		}
		public Vec3 Zxw
		{
			get { return new Vec3(Z, X, W); }
			set { Z = value.X; X = value.Y; W = value.Z; }
		}
		public Vec3 Zyx
		{
			get { return new Vec3(Z, Y, X); }
			set { Z = value.X; Y = value.Y; X = value.Z; }
		}
		public Vec3 Zyy
		{
			get { return new Vec3(Z, Y, Y); }
			set { Z = value.X; Y = value.Y; Y = value.Z; }
		}
		public Vec3 Zyz
		{
			get { return new Vec3(Z, Y, Z); }
			set { Z = value.X; Y = value.Y; Z = value.Z; }
		}
		public Vec3 Zyw
		{
			get { return new Vec3(Z, Y, W); }
			set { Z = value.X; Y = value.Y; W = value.Z; }
		}
		public Vec3 Zzx
		{
			get { return new Vec3(Z, Z, X); }
			set { Z = value.X; Z = value.Y; X = value.Z; }
		}
		public Vec3 Zzy
		{
			get { return new Vec3(Z, Z, Y); }
			set { Z = value.X; Z = value.Y; Y = value.Z; }
		}
		public Vec3 Zzz
		{
			get { return new Vec3(Z, Z, Z); }
			set { Z = value.X; Z = value.Y; Z = value.Z; }
		}
		public Vec3 Zzw
		{
			get { return new Vec3(Z, Z, W); }
			set { Z = value.X; Z = value.Y; W = value.Z; }
		}
		public Vec3 Zwx
		{
			get { return new Vec3(Z, W, X); }
			set { Z = value.X; W = value.Y; X = value.Z; }
		}
		public Vec3 Zwy
		{
			get { return new Vec3(Z, W, Y); }
			set { Z = value.X; W = value.Y; Y = value.Z; }
		}
		public Vec3 Zwz
		{
			get { return new Vec3(Z, W, Z); }
			set { Z = value.X; W = value.Y; Z = value.Z; }
		}
		public Vec3 Zww
		{
			get { return new Vec3(Z, W, W); }
			set { Z = value.X; W = value.Y; W = value.Z; }
		}
		public Vec3 Wxx
		{
			get { return new Vec3(W, X, X); }
			set { W = value.X; X = value.Y; X = value.Z; }
		}
		public Vec3 Wxy
		{
			get { return new Vec3(W, X, Y); }
			set { W = value.X; X = value.Y; Y = value.Z; }
		}
		public Vec3 Wxz
		{
			get { return new Vec3(W, X, Z); }
			set { W = value.X; X = value.Y; Z = value.Z; }
		}
		public Vec3 Wxw
		{
			get { return new Vec3(W, X, W); }
			set { W = value.X; X = value.Y; W = value.Z; }
		}
		public Vec3 Wyx
		{
			get { return new Vec3(W, Y, X); }
			set { W = value.X; Y = value.Y; X = value.Z; }
		}
		public Vec3 Wyy
		{
			get { return new Vec3(W, Y, Y); }
			set { W = value.X; Y = value.Y; Y = value.Z; }
		}
		public Vec3 Wyz
		{
			get { return new Vec3(W, Y, Z); }
			set { W = value.X; Y = value.Y; Z = value.Z; }
		}
		public Vec3 Wyw
		{
			get { return new Vec3(W, Y, W); }
			set { W = value.X; Y = value.Y; W = value.Z; }
		}
		public Vec3 Wzx
		{
			get { return new Vec3(W, Z, X); }
			set { W = value.X; Z = value.Y; X = value.Z; }
		}
		public Vec3 Wzy
		{
			get { return new Vec3(W, Z, Y); }
			set { W = value.X; Z = value.Y; Y = value.Z; }
		}
		public Vec3 Wzz
		{
			get { return new Vec3(W, Z, Z); }
			set { W = value.X; Z = value.Y; Z = value.Z; }
		}
		public Vec3 Wzw
		{
			get { return new Vec3(W, Z, W); }
			set { W = value.X; Z = value.Y; W = value.Z; }
		}
		public Vec3 Wwx
		{
			get { return new Vec3(W, W, X); }
			set { W = value.X; W = value.Y; X = value.Z; }
		}
		public Vec3 Wwy
		{
			get { return new Vec3(W, W, Y); }
			set { W = value.X; W = value.Y; Y = value.Z; }
		}
		public Vec3 Wwz
		{
			get { return new Vec3(W, W, Z); }
			set { W = value.X; W = value.Y; Z = value.Z; }
		}
		public Vec3 Www
		{
			get { return new Vec3(W, W, W); }
			set { W = value.X; W = value.Y; W = value.Z; }
		}
		#endregion

		#region 4D
		public Vec4 Xxxx
		{
			get { return new Vec4(X, X, X, X); }
			set { X = value.X; X = value.Y; X = value.Z; X = value.W; }
		}
		public Vec4 Xxxy
		{
			get { return new Vec4(X, X, X, Y); }
			set { X = value.X; X = value.Y; X = value.Z; Y = value.W; }
		}
		public Vec4 Xxxz
		{
			get { return new Vec4(X, X, X, Z); }
			set { X = value.X; X = value.Y; X = value.Z; Z = value.W; }
		}
		public Vec4 Xxxw
		{
			get { return new Vec4(X, X, X, W); }
			set { X = value.X; X = value.Y; X = value.Z; W = value.W; }
		}
		public Vec4 Xxyx
		{
			get { return new Vec4(X, X, Y, X); }
			set { X = value.X; X = value.Y; Y = value.Z; X = value.W; }
		}
		public Vec4 Xxyy
		{
			get { return new Vec4(X, X, Y, Y); }
			set { X = value.X; X = value.Y; Y = value.Z; Y = value.W; }
		}
		public Vec4 Xxyz
		{
			get { return new Vec4(X, X, Y, Z); }
			set { X = value.X; X = value.Y; Y = value.Z; Z = value.W; }
		}
		public Vec4 Xxyw
		{
			get { return new Vec4(X, X, Y, W); }
			set { X = value.X; X = value.Y; Y = value.Z; W = value.W; }
		}
		public Vec4 Xxzx
		{
			get { return new Vec4(X, X, Z, X); }
			set { X = value.X; X = value.Y; Z = value.Z; X = value.W; }
		}
		public Vec4 Xxzy
		{
			get { return new Vec4(X, X, Z, Y); }
			set { X = value.X; X = value.Y; Z = value.Z; Y = value.W; }
		}
		public Vec4 Xxzz
		{
			get { return new Vec4(X, X, Z, Z); }
			set { X = value.X; X = value.Y; Z = value.Z; Z = value.W; }
		}
		public Vec4 Xxzw
		{
			get { return new Vec4(X, X, Z, W); }
			set { X = value.X; X = value.Y; Z = value.Z; W = value.W; }
		}
		public Vec4 Xxwx
		{
			get { return new Vec4(X, X, W, X); }
			set { X = value.X; X = value.Y; W = value.Z; X = value.W; }
		}
		public Vec4 Xxwy
		{
			get { return new Vec4(X, X, W, Y); }
			set { X = value.X; X = value.Y; W = value.Z; Y = value.W; }
		}
		public Vec4 Xxwz
		{
			get { return new Vec4(X, X, W, Z); }
			set { X = value.X; X = value.Y; W = value.Z; Z = value.W; }
		}
		public Vec4 Xxww
		{
			get { return new Vec4(X, X, W, W); }
			set { X = value.X; X = value.Y; W = value.Z; W = value.W; }
		}
		public Vec4 Xyxx
		{
			get { return new Vec4(X, Y, X, X); }
			set { X = value.X; Y = value.Y; X = value.Z; X = value.W; }
		}
		public Vec4 Xyxy
		{
			get { return new Vec4(X, Y, X, Y); }
			set { X = value.X; Y = value.Y; X = value.Z; Y = value.W; }
		}
		public Vec4 Xyxz
		{
			get { return new Vec4(X, Y, X, Z); }
			set { X = value.X; Y = value.Y; X = value.Z; Z = value.W; }
		}
		public Vec4 Xyxw
		{
			get { return new Vec4(X, Y, X, W); }
			set { X = value.X; Y = value.Y; X = value.Z; W = value.W; }
		}
		public Vec4 Xyyx
		{
			get { return new Vec4(X, Y, Y, X); }
			set { X = value.X; Y = value.Y; Y = value.Z; X = value.W; }
		}
		public Vec4 Xyyy
		{
			get { return new Vec4(X, Y, Y, Y); }
			set { X = value.X; Y = value.Y; Y = value.Z; Y = value.W; }
		}
		public Vec4 Xyyz
		{
			get { return new Vec4(X, Y, Y, Z); }
			set { X = value.X; Y = value.Y; Y = value.Z; Z = value.W; }
		}
		public Vec4 Xyyw
		{
			get { return new Vec4(X, Y, Y, W); }
			set { X = value.X; Y = value.Y; Y = value.Z; W = value.W; }
		}
		public Vec4 Xyzx
		{
			get { return new Vec4(X, Y, Z, X); }
			set { X = value.X; Y = value.Y; Z = value.Z; X = value.W; }
		}
		public Vec4 Xyzy
		{
			get { return new Vec4(X, Y, Z, Y); }
			set { X = value.X; Y = value.Y; Z = value.Z; Y = value.W; }
		}
		public Vec4 Xyzz
		{
			get { return new Vec4(X, Y, Z, Z); }
			set { X = value.X; Y = value.Y; Z = value.Z; Z = value.W; }
		}
		public Vec4 Xyzw
		{
			get { return new Vec4(X, Y, Z, W); }
			set { X = value.X; Y = value.Y; Z = value.Z; W = value.W; }
		}
		public Vec4 Xywx
		{
			get { return new Vec4(X, Y, W, X); }
			set { X = value.X; Y = value.Y; W = value.Z; X = value.W; }
		}
		public Vec4 Xywy
		{
			get { return new Vec4(X, Y, W, Y); }
			set { X = value.X; Y = value.Y; W = value.Z; Y = value.W; }
		}
		public Vec4 Xywz
		{
			get { return new Vec4(X, Y, W, Z); }
			set { X = value.X; Y = value.Y; W = value.Z; Z = value.W; }
		}
		public Vec4 Xyww
		{
			get { return new Vec4(X, Y, W, W); }
			set { X = value.X; Y = value.Y; W = value.Z; W = value.W; }
		}
		public Vec4 Xzxx
		{
			get { return new Vec4(X, Z, X, X); }
			set { X = value.X; Z = value.Y; X = value.Z; X = value.W; }
		}
		public Vec4 Xzxy
		{
			get { return new Vec4(X, Z, X, Y); }
			set { X = value.X; Z = value.Y; X = value.Z; Y = value.W; }
		}
		public Vec4 Xzxz
		{
			get { return new Vec4(X, Z, X, Z); }
			set { X = value.X; Z = value.Y; X = value.Z; Z = value.W; }
		}
		public Vec4 Xzxw
		{
			get { return new Vec4(X, Z, X, W); }
			set { X = value.X; Z = value.Y; X = value.Z; W = value.W; }
		}
		public Vec4 Xzyx
		{
			get { return new Vec4(X, Z, Y, X); }
			set { X = value.X; Z = value.Y; Y = value.Z; X = value.W; }
		}
		public Vec4 Xzyy
		{
			get { return new Vec4(X, Z, Y, Y); }
			set { X = value.X; Z = value.Y; Y = value.Z; Y = value.W; }
		}
		public Vec4 Xzyz
		{
			get { return new Vec4(X, Z, Y, Z); }
			set { X = value.X; Z = value.Y; Y = value.Z; Z = value.W; }
		}
		public Vec4 Xzyw
		{
			get { return new Vec4(X, Z, Y, W); }
			set { X = value.X; Z = value.Y; Y = value.Z; W = value.W; }
		}
		public Vec4 Xzzx
		{
			get { return new Vec4(X, Z, Z, X); }
			set { X = value.X; Z = value.Y; Z = value.Z; X = value.W; }
		}
		public Vec4 Xzzy
		{
			get { return new Vec4(X, Z, Z, Y); }
			set { X = value.X; Z = value.Y; Z = value.Z; Y = value.W; }
		}
		public Vec4 Xzzz
		{
			get { return new Vec4(X, Z, Z, Z); }
			set { X = value.X; Z = value.Y; Z = value.Z; Z = value.W; }
		}
		public Vec4 Xzzw
		{
			get { return new Vec4(X, Z, Z, W); }
			set { X = value.X; Z = value.Y; Z = value.Z; W = value.W; }
		}
		public Vec4 Xzwx
		{
			get { return new Vec4(X, Z, W, X); }
			set { X = value.X; Z = value.Y; W = value.Z; X = value.W; }
		}
		public Vec4 Xzwy
		{
			get { return new Vec4(X, Z, W, Y); }
			set { X = value.X; Z = value.Y; W = value.Z; Y = value.W; }
		}
		public Vec4 Xzwz
		{
			get { return new Vec4(X, Z, W, Z); }
			set { X = value.X; Z = value.Y; W = value.Z; Z = value.W; }
		}
		public Vec4 Xzww
		{
			get { return new Vec4(X, Z, W, W); }
			set { X = value.X; Z = value.Y; W = value.Z; W = value.W; }
		}
		public Vec4 Xwxx
		{
			get { return new Vec4(X, W, X, X); }
			set { X = value.X; W = value.Y; X = value.Z; X = value.W; }
		}
		public Vec4 Xwxy
		{
			get { return new Vec4(X, W, X, Y); }
			set { X = value.X; W = value.Y; X = value.Z; Y = value.W; }
		}
		public Vec4 Xwxz
		{
			get { return new Vec4(X, W, X, Z); }
			set { X = value.X; W = value.Y; X = value.Z; Z = value.W; }
		}
		public Vec4 Xwxw
		{
			get { return new Vec4(X, W, X, W); }
			set { X = value.X; W = value.Y; X = value.Z; W = value.W; }
		}
		public Vec4 Xwyx
		{
			get { return new Vec4(X, W, Y, X); }
			set { X = value.X; W = value.Y; Y = value.Z; X = value.W; }
		}
		public Vec4 Xwyy
		{
			get { return new Vec4(X, W, Y, Y); }
			set { X = value.X; W = value.Y; Y = value.Z; Y = value.W; }
		}
		public Vec4 Xwyz
		{
			get { return new Vec4(X, W, Y, Z); }
			set { X = value.X; W = value.Y; Y = value.Z; Z = value.W; }
		}
		public Vec4 Xwyw
		{
			get { return new Vec4(X, W, Y, W); }
			set { X = value.X; W = value.Y; Y = value.Z; W = value.W; }
		}
		public Vec4 Xwzx
		{
			get { return new Vec4(X, W, Z, X); }
			set { X = value.X; W = value.Y; Z = value.Z; X = value.W; }
		}
		public Vec4 Xwzy
		{
			get { return new Vec4(X, W, Z, Y); }
			set { X = value.X; W = value.Y; Z = value.Z; Y = value.W; }
		}
		public Vec4 Xwzz
		{
			get { return new Vec4(X, W, Z, Z); }
			set { X = value.X; W = value.Y; Z = value.Z; Z = value.W; }
		}
		public Vec4 Xwzw
		{
			get { return new Vec4(X, W, Z, W); }
			set { X = value.X; W = value.Y; Z = value.Z; W = value.W; }
		}
		public Vec4 Xwwx
		{
			get { return new Vec4(X, W, W, X); }
			set { X = value.X; W = value.Y; W = value.Z; X = value.W; }
		}
		public Vec4 Xwwy
		{
			get { return new Vec4(X, W, W, Y); }
			set { X = value.X; W = value.Y; W = value.Z; Y = value.W; }
		}
		public Vec4 Xwwz
		{
			get { return new Vec4(X, W, W, Z); }
			set { X = value.X; W = value.Y; W = value.Z; Z = value.W; }
		}
		public Vec4 Xwww
		{
			get { return new Vec4(X, W, W, W); }
			set { X = value.X; W = value.Y; W = value.Z; W = value.W; }
		}
		public Vec4 Yxxx
		{
			get { return new Vec4(Y, X, X, X); }
			set { Y = value.X; X = value.Y; X = value.Z; X = value.W; }
		}
		public Vec4 Yxxy
		{
			get { return new Vec4(Y, X, X, Y); }
			set { Y = value.X; X = value.Y; X = value.Z; Y = value.W; }
		}
		public Vec4 Yxxz
		{
			get { return new Vec4(Y, X, X, Z); }
			set { Y = value.X; X = value.Y; X = value.Z; Z = value.W; }
		}
		public Vec4 Yxxw
		{
			get { return new Vec4(Y, X, X, W); }
			set { Y = value.X; X = value.Y; X = value.Z; W = value.W; }
		}
		public Vec4 Yxyx
		{
			get { return new Vec4(Y, X, Y, X); }
			set { Y = value.X; X = value.Y; Y = value.Z; X = value.W; }
		}
		public Vec4 Yxyy
		{
			get { return new Vec4(Y, X, Y, Y); }
			set { Y = value.X; X = value.Y; Y = value.Z; Y = value.W; }
		}
		public Vec4 Yxyz
		{
			get { return new Vec4(Y, X, Y, Z); }
			set { Y = value.X; X = value.Y; Y = value.Z; Z = value.W; }
		}
		public Vec4 Yxyw
		{
			get { return new Vec4(Y, X, Y, W); }
			set { Y = value.X; X = value.Y; Y = value.Z; W = value.W; }
		}
		public Vec4 Yxzx
		{
			get { return new Vec4(Y, X, Z, X); }
			set { Y = value.X; X = value.Y; Z = value.Z; X = value.W; }
		}
		public Vec4 Yxzy
		{
			get { return new Vec4(Y, X, Z, Y); }
			set { Y = value.X; X = value.Y; Z = value.Z; Y = value.W; }
		}
		public Vec4 Yxzz
		{
			get { return new Vec4(Y, X, Z, Z); }
			set { Y = value.X; X = value.Y; Z = value.Z; Z = value.W; }
		}
		public Vec4 Yxzw
		{
			get { return new Vec4(Y, X, Z, W); }
			set { Y = value.X; X = value.Y; Z = value.Z; W = value.W; }
		}
		public Vec4 Yxwx
		{
			get { return new Vec4(Y, X, W, X); }
			set { Y = value.X; X = value.Y; W = value.Z; X = value.W; }
		}
		public Vec4 Yxwy
		{
			get { return new Vec4(Y, X, W, Y); }
			set { Y = value.X; X = value.Y; W = value.Z; Y = value.W; }
		}
		public Vec4 Yxwz
		{
			get { return new Vec4(Y, X, W, Z); }
			set { Y = value.X; X = value.Y; W = value.Z; Z = value.W; }
		}
		public Vec4 Yxww
		{
			get { return new Vec4(Y, X, W, W); }
			set { Y = value.X; X = value.Y; W = value.Z; W = value.W; }
		}
		public Vec4 Yyxx
		{
			get { return new Vec4(Y, Y, X, X); }
			set { Y = value.X; Y = value.Y; X = value.Z; X = value.W; }
		}
		public Vec4 Yyxy
		{
			get { return new Vec4(Y, Y, X, Y); }
			set { Y = value.X; Y = value.Y; X = value.Z; Y = value.W; }
		}
		public Vec4 Yyxz
		{
			get { return new Vec4(Y, Y, X, Z); }
			set { Y = value.X; Y = value.Y; X = value.Z; Z = value.W; }
		}
		public Vec4 Yyxw
		{
			get { return new Vec4(Y, Y, X, W); }
			set { Y = value.X; Y = value.Y; X = value.Z; W = value.W; }
		}
		public Vec4 Yyyx
		{
			get { return new Vec4(Y, Y, Y, X); }
			set { Y = value.X; Y = value.Y; Y = value.Z; X = value.W; }
		}
		public Vec4 Yyyy
		{
			get { return new Vec4(Y, Y, Y, Y); }
			set { Y = value.X; Y = value.Y; Y = value.Z; Y = value.W; }
		}
		public Vec4 Yyyz
		{
			get { return new Vec4(Y, Y, Y, Z); }
			set { Y = value.X; Y = value.Y; Y = value.Z; Z = value.W; }
		}
		public Vec4 Yyyw
		{
			get { return new Vec4(Y, Y, Y, W); }
			set { Y = value.X; Y = value.Y; Y = value.Z; W = value.W; }
		}
		public Vec4 Yyzx
		{
			get { return new Vec4(Y, Y, Z, X); }
			set { Y = value.X; Y = value.Y; Z = value.Z; X = value.W; }
		}
		public Vec4 Yyzy
		{
			get { return new Vec4(Y, Y, Z, Y); }
			set { Y = value.X; Y = value.Y; Z = value.Z; Y = value.W; }
		}
		public Vec4 Yyzz
		{
			get { return new Vec4(Y, Y, Z, Z); }
			set { Y = value.X; Y = value.Y; Z = value.Z; Z = value.W; }
		}
		public Vec4 Yyzw
		{
			get { return new Vec4(Y, Y, Z, W); }
			set { Y = value.X; Y = value.Y; Z = value.Z; W = value.W; }
		}
		public Vec4 Yywx
		{
			get { return new Vec4(Y, Y, W, X); }
			set { Y = value.X; Y = value.Y; W = value.Z; X = value.W; }
		}
		public Vec4 Yywy
		{
			get { return new Vec4(Y, Y, W, Y); }
			set { Y = value.X; Y = value.Y; W = value.Z; Y = value.W; }
		}
		public Vec4 Yywz
		{
			get { return new Vec4(Y, Y, W, Z); }
			set { Y = value.X; Y = value.Y; W = value.Z; Z = value.W; }
		}
		public Vec4 Yyww
		{
			get { return new Vec4(Y, Y, W, W); }
			set { Y = value.X; Y = value.Y; W = value.Z; W = value.W; }
		}
		public Vec4 Yzxx
		{
			get { return new Vec4(Y, Z, X, X); }
			set { Y = value.X; Z = value.Y; X = value.Z; X = value.W; }
		}
		public Vec4 Yzxy
		{
			get { return new Vec4(Y, Z, X, Y); }
			set { Y = value.X; Z = value.Y; X = value.Z; Y = value.W; }
		}
		public Vec4 Yzxz
		{
			get { return new Vec4(Y, Z, X, Z); }
			set { Y = value.X; Z = value.Y; X = value.Z; Z = value.W; }
		}
		public Vec4 Yzxw
		{
			get { return new Vec4(Y, Z, X, W); }
			set { Y = value.X; Z = value.Y; X = value.Z; W = value.W; }
		}
		public Vec4 Yzyx
		{
			get { return new Vec4(Y, Z, Y, X); }
			set { Y = value.X; Z = value.Y; Y = value.Z; X = value.W; }
		}
		public Vec4 Yzyy
		{
			get { return new Vec4(Y, Z, Y, Y); }
			set { Y = value.X; Z = value.Y; Y = value.Z; Y = value.W; }
		}
		public Vec4 Yzyz
		{
			get { return new Vec4(Y, Z, Y, Z); }
			set { Y = value.X; Z = value.Y; Y = value.Z; Z = value.W; }
		}
		public Vec4 Yzyw
		{
			get { return new Vec4(Y, Z, Y, W); }
			set { Y = value.X; Z = value.Y; Y = value.Z; W = value.W; }
		}
		public Vec4 Yzzx
		{
			get { return new Vec4(Y, Z, Z, X); }
			set { Y = value.X; Z = value.Y; Z = value.Z; X = value.W; }
		}
		public Vec4 Yzzy
		{
			get { return new Vec4(Y, Z, Z, Y); }
			set { Y = value.X; Z = value.Y; Z = value.Z; Y = value.W; }
		}
		public Vec4 Yzzz
		{
			get { return new Vec4(Y, Z, Z, Z); }
			set { Y = value.X; Z = value.Y; Z = value.Z; Z = value.W; }
		}
		public Vec4 Yzzw
		{
			get { return new Vec4(Y, Z, Z, W); }
			set { Y = value.X; Z = value.Y; Z = value.Z; W = value.W; }
		}
		public Vec4 Yzwx
		{
			get { return new Vec4(Y, Z, W, X); }
			set { Y = value.X; Z = value.Y; W = value.Z; X = value.W; }
		}
		public Vec4 Yzwy
		{
			get { return new Vec4(Y, Z, W, Y); }
			set { Y = value.X; Z = value.Y; W = value.Z; Y = value.W; }
		}
		public Vec4 Yzwz
		{
			get { return new Vec4(Y, Z, W, Z); }
			set { Y = value.X; Z = value.Y; W = value.Z; Z = value.W; }
		}
		public Vec4 Yzww
		{
			get { return new Vec4(Y, Z, W, W); }
			set { Y = value.X; Z = value.Y; W = value.Z; W = value.W; }
		}
		public Vec4 Ywxx
		{
			get { return new Vec4(Y, W, X, X); }
			set { Y = value.X; W = value.Y; X = value.Z; X = value.W; }
		}
		public Vec4 Ywxy
		{
			get { return new Vec4(Y, W, X, Y); }
			set { Y = value.X; W = value.Y; X = value.Z; Y = value.W; }
		}
		public Vec4 Ywxz
		{
			get { return new Vec4(Y, W, X, Z); }
			set { Y = value.X; W = value.Y; X = value.Z; Z = value.W; }
		}
		public Vec4 Ywxw
		{
			get { return new Vec4(Y, W, X, W); }
			set { Y = value.X; W = value.Y; X = value.Z; W = value.W; }
		}
		public Vec4 Ywyx
		{
			get { return new Vec4(Y, W, Y, X); }
			set { Y = value.X; W = value.Y; Y = value.Z; X = value.W; }
		}
		public Vec4 Ywyy
		{
			get { return new Vec4(Y, W, Y, Y); }
			set { Y = value.X; W = value.Y; Y = value.Z; Y = value.W; }
		}
		public Vec4 Ywyz
		{
			get { return new Vec4(Y, W, Y, Z); }
			set { Y = value.X; W = value.Y; Y = value.Z; Z = value.W; }
		}
		public Vec4 Ywyw
		{
			get { return new Vec4(Y, W, Y, W); }
			set { Y = value.X; W = value.Y; Y = value.Z; W = value.W; }
		}
		public Vec4 Ywzx
		{
			get { return new Vec4(Y, W, Z, X); }
			set { Y = value.X; W = value.Y; Z = value.Z; X = value.W; }
		}
		public Vec4 Ywzy
		{
			get { return new Vec4(Y, W, Z, Y); }
			set { Y = value.X; W = value.Y; Z = value.Z; Y = value.W; }
		}
		public Vec4 Ywzz
		{
			get { return new Vec4(Y, W, Z, Z); }
			set { Y = value.X; W = value.Y; Z = value.Z; Z = value.W; }
		}
		public Vec4 Ywzw
		{
			get { return new Vec4(Y, W, Z, W); }
			set { Y = value.X; W = value.Y; Z = value.Z; W = value.W; }
		}
		public Vec4 Ywwx
		{
			get { return new Vec4(Y, W, W, X); }
			set { Y = value.X; W = value.Y; W = value.Z; X = value.W; }
		}
		public Vec4 Ywwy
		{
			get { return new Vec4(Y, W, W, Y); }
			set { Y = value.X; W = value.Y; W = value.Z; Y = value.W; }
		}
		public Vec4 Ywwz
		{
			get { return new Vec4(Y, W, W, Z); }
			set { Y = value.X; W = value.Y; W = value.Z; Z = value.W; }
		}
		public Vec4 Ywww
		{
			get { return new Vec4(Y, W, W, W); }
			set { Y = value.X; W = value.Y; W = value.Z; W = value.W; }
		}
		public Vec4 Zxxx
		{
			get { return new Vec4(Z, X, X, X); }
			set { Z = value.X; X = value.Y; X = value.Z; X = value.W; }
		}
		public Vec4 Zxxy
		{
			get { return new Vec4(Z, X, X, Y); }
			set { Z = value.X; X = value.Y; X = value.Z; Y = value.W; }
		}
		public Vec4 Zxxz
		{
			get { return new Vec4(Z, X, X, Z); }
			set { Z = value.X; X = value.Y; X = value.Z; Z = value.W; }
		}
		public Vec4 Zxxw
		{
			get { return new Vec4(Z, X, X, W); }
			set { Z = value.X; X = value.Y; X = value.Z; W = value.W; }
		}
		public Vec4 Zxyx
		{
			get { return new Vec4(Z, X, Y, X); }
			set { Z = value.X; X = value.Y; Y = value.Z; X = value.W; }
		}
		public Vec4 Zxyy
		{
			get { return new Vec4(Z, X, Y, Y); }
			set { Z = value.X; X = value.Y; Y = value.Z; Y = value.W; }
		}
		public Vec4 Zxyz
		{
			get { return new Vec4(Z, X, Y, Z); }
			set { Z = value.X; X = value.Y; Y = value.Z; Z = value.W; }
		}
		public Vec4 Zxyw
		{
			get { return new Vec4(Z, X, Y, W); }
			set { Z = value.X; X = value.Y; Y = value.Z; W = value.W; }
		}
		public Vec4 Zxzx
		{
			get { return new Vec4(Z, X, Z, X); }
			set { Z = value.X; X = value.Y; Z = value.Z; X = value.W; }
		}
		public Vec4 Zxzy
		{
			get { return new Vec4(Z, X, Z, Y); }
			set { Z = value.X; X = value.Y; Z = value.Z; Y = value.W; }
		}
		public Vec4 Zxzz
		{
			get { return new Vec4(Z, X, Z, Z); }
			set { Z = value.X; X = value.Y; Z = value.Z; Z = value.W; }
		}
		public Vec4 Zxzw
		{
			get { return new Vec4(Z, X, Z, W); }
			set { Z = value.X; X = value.Y; Z = value.Z; W = value.W; }
		}
		public Vec4 Zxwx
		{
			get { return new Vec4(Z, X, W, X); }
			set { Z = value.X; X = value.Y; W = value.Z; X = value.W; }
		}
		public Vec4 Zxwy
		{
			get { return new Vec4(Z, X, W, Y); }
			set { Z = value.X; X = value.Y; W = value.Z; Y = value.W; }
		}
		public Vec4 Zxwz
		{
			get { return new Vec4(Z, X, W, Z); }
			set { Z = value.X; X = value.Y; W = value.Z; Z = value.W; }
		}
		public Vec4 Zxww
		{
			get { return new Vec4(Z, X, W, W); }
			set { Z = value.X; X = value.Y; W = value.Z; W = value.W; }
		}
		public Vec4 Zyxx
		{
			get { return new Vec4(Z, Y, X, X); }
			set { Z = value.X; Y = value.Y; X = value.Z; X = value.W; }
		}
		public Vec4 Zyxy
		{
			get { return new Vec4(Z, Y, X, Y); }
			set { Z = value.X; Y = value.Y; X = value.Z; Y = value.W; }
		}
		public Vec4 Zyxz
		{
			get { return new Vec4(Z, Y, X, Z); }
			set { Z = value.X; Y = value.Y; X = value.Z; Z = value.W; }
		}
		public Vec4 Zyxw
		{
			get { return new Vec4(Z, Y, X, W); }
			set { Z = value.X; Y = value.Y; X = value.Z; W = value.W; }
		}
		public Vec4 Zyyx
		{
			get { return new Vec4(Z, Y, Y, X); }
			set { Z = value.X; Y = value.Y; Y = value.Z; X = value.W; }
		}
		public Vec4 Zyyy
		{
			get { return new Vec4(Z, Y, Y, Y); }
			set { Z = value.X; Y = value.Y; Y = value.Z; Y = value.W; }
		}
		public Vec4 Zyyz
		{
			get { return new Vec4(Z, Y, Y, Z); }
			set { Z = value.X; Y = value.Y; Y = value.Z; Z = value.W; }
		}
		public Vec4 Zyyw
		{
			get { return new Vec4(Z, Y, Y, W); }
			set { Z = value.X; Y = value.Y; Y = value.Z; W = value.W; }
		}
		public Vec4 Zyzx
		{
			get { return new Vec4(Z, Y, Z, X); }
			set { Z = value.X; Y = value.Y; Z = value.Z; X = value.W; }
		}
		public Vec4 Zyzy
		{
			get { return new Vec4(Z, Y, Z, Y); }
			set { Z = value.X; Y = value.Y; Z = value.Z; Y = value.W; }
		}
		public Vec4 Zyzz
		{
			get { return new Vec4(Z, Y, Z, Z); }
			set { Z = value.X; Y = value.Y; Z = value.Z; Z = value.W; }
		}
		public Vec4 Zyzw
		{
			get { return new Vec4(Z, Y, Z, W); }
			set { Z = value.X; Y = value.Y; Z = value.Z; W = value.W; }
		}
		public Vec4 Zywx
		{
			get { return new Vec4(Z, Y, W, X); }
			set { Z = value.X; Y = value.Y; W = value.Z; X = value.W; }
		}
		public Vec4 Zywy
		{
			get { return new Vec4(Z, Y, W, Y); }
			set { Z = value.X; Y = value.Y; W = value.Z; Y = value.W; }
		}
		public Vec4 Zywz
		{
			get { return new Vec4(Z, Y, W, Z); }
			set { Z = value.X; Y = value.Y; W = value.Z; Z = value.W; }
		}
		public Vec4 Zyww
		{
			get { return new Vec4(Z, Y, W, W); }
			set { Z = value.X; Y = value.Y; W = value.Z; W = value.W; }
		}
		public Vec4 Zzxx
		{
			get { return new Vec4(Z, Z, X, X); }
			set { Z = value.X; Z = value.Y; X = value.Z; X = value.W; }
		}
		public Vec4 Zzxy
		{
			get { return new Vec4(Z, Z, X, Y); }
			set { Z = value.X; Z = value.Y; X = value.Z; Y = value.W; }
		}
		public Vec4 Zzxz
		{
			get { return new Vec4(Z, Z, X, Z); }
			set { Z = value.X; Z = value.Y; X = value.Z; Z = value.W; }
		}
		public Vec4 Zzxw
		{
			get { return new Vec4(Z, Z, X, W); }
			set { Z = value.X; Z = value.Y; X = value.Z; W = value.W; }
		}
		public Vec4 Zzyx
		{
			get { return new Vec4(Z, Z, Y, X); }
			set { Z = value.X; Z = value.Y; Y = value.Z; X = value.W; }
		}
		public Vec4 Zzyy
		{
			get { return new Vec4(Z, Z, Y, Y); }
			set { Z = value.X; Z = value.Y; Y = value.Z; Y = value.W; }
		}
		public Vec4 Zzyz
		{
			get { return new Vec4(Z, Z, Y, Z); }
			set { Z = value.X; Z = value.Y; Y = value.Z; Z = value.W; }
		}
		public Vec4 Zzyw
		{
			get { return new Vec4(Z, Z, Y, W); }
			set { Z = value.X; Z = value.Y; Y = value.Z; W = value.W; }
		}
		public Vec4 Zzzx
		{
			get { return new Vec4(Z, Z, Z, X); }
			set { Z = value.X; Z = value.Y; Z = value.Z; X = value.W; }
		}
		public Vec4 Zzzy
		{
			get { return new Vec4(Z, Z, Z, Y); }
			set { Z = value.X; Z = value.Y; Z = value.Z; Y = value.W; }
		}
		public Vec4 Zzzz
		{
			get { return new Vec4(Z, Z, Z, Z); }
			set { Z = value.X; Z = value.Y; Z = value.Z; Z = value.W; }
		}
		public Vec4 Zzzw
		{
			get { return new Vec4(Z, Z, Z, W); }
			set { Z = value.X; Z = value.Y; Z = value.Z; W = value.W; }
		}
		public Vec4 Zzwx
		{
			get { return new Vec4(Z, Z, W, X); }
			set { Z = value.X; Z = value.Y; W = value.Z; X = value.W; }
		}
		public Vec4 Zzwy
		{
			get { return new Vec4(Z, Z, W, Y); }
			set { Z = value.X; Z = value.Y; W = value.Z; Y = value.W; }
		}
		public Vec4 Zzwz
		{
			get { return new Vec4(Z, Z, W, Z); }
			set { Z = value.X; Z = value.Y; W = value.Z; Z = value.W; }
		}
		public Vec4 Zzww
		{
			get { return new Vec4(Z, Z, W, W); }
			set { Z = value.X; Z = value.Y; W = value.Z; W = value.W; }
		}
		public Vec4 Zwxx
		{
			get { return new Vec4(Z, W, X, X); }
			set { Z = value.X; W = value.Y; X = value.Z; X = value.W; }
		}
		public Vec4 Zwxy
		{
			get { return new Vec4(Z, W, X, Y); }
			set { Z = value.X; W = value.Y; X = value.Z; Y = value.W; }
		}
		public Vec4 Zwxz
		{
			get { return new Vec4(Z, W, X, Z); }
			set { Z = value.X; W = value.Y; X = value.Z; Z = value.W; }
		}
		public Vec4 Zwxw
		{
			get { return new Vec4(Z, W, X, W); }
			set { Z = value.X; W = value.Y; X = value.Z; W = value.W; }
		}
		public Vec4 Zwyx
		{
			get { return new Vec4(Z, W, Y, X); }
			set { Z = value.X; W = value.Y; Y = value.Z; X = value.W; }
		}
		public Vec4 Zwyy
		{
			get { return new Vec4(Z, W, Y, Y); }
			set { Z = value.X; W = value.Y; Y = value.Z; Y = value.W; }
		}
		public Vec4 Zwyz
		{
			get { return new Vec4(Z, W, Y, Z); }
			set { Z = value.X; W = value.Y; Y = value.Z; Z = value.W; }
		}
		public Vec4 Zwyw
		{
			get { return new Vec4(Z, W, Y, W); }
			set { Z = value.X; W = value.Y; Y = value.Z; W = value.W; }
		}
		public Vec4 Zwzx
		{
			get { return new Vec4(Z, W, Z, X); }
			set { Z = value.X; W = value.Y; Z = value.Z; X = value.W; }
		}
		public Vec4 Zwzy
		{
			get { return new Vec4(Z, W, Z, Y); }
			set { Z = value.X; W = value.Y; Z = value.Z; Y = value.W; }
		}
		public Vec4 Zwzz
		{
			get { return new Vec4(Z, W, Z, Z); }
			set { Z = value.X; W = value.Y; Z = value.Z; Z = value.W; }
		}
		public Vec4 Zwzw
		{
			get { return new Vec4(Z, W, Z, W); }
			set { Z = value.X; W = value.Y; Z = value.Z; W = value.W; }
		}
		public Vec4 Zwwx
		{
			get { return new Vec4(Z, W, W, X); }
			set { Z = value.X; W = value.Y; W = value.Z; X = value.W; }
		}
		public Vec4 Zwwy
		{
			get { return new Vec4(Z, W, W, Y); }
			set { Z = value.X; W = value.Y; W = value.Z; Y = value.W; }
		}
		public Vec4 Zwwz
		{
			get { return new Vec4(Z, W, W, Z); }
			set { Z = value.X; W = value.Y; W = value.Z; Z = value.W; }
		}
		public Vec4 Zwww
		{
			get { return new Vec4(Z, W, W, W); }
			set { Z = value.X; W = value.Y; W = value.Z; W = value.W; }
		}
		public Vec4 Wxxx
		{
			get { return new Vec4(W, X, X, X); }
			set { W = value.X; X = value.Y; X = value.Z; X = value.W; }
		}
		public Vec4 Wxxy
		{
			get { return new Vec4(W, X, X, Y); }
			set { W = value.X; X = value.Y; X = value.Z; Y = value.W; }
		}
		public Vec4 Wxxz
		{
			get { return new Vec4(W, X, X, Z); }
			set { W = value.X; X = value.Y; X = value.Z; Z = value.W; }
		}
		public Vec4 Wxxw
		{
			get { return new Vec4(W, X, X, W); }
			set { W = value.X; X = value.Y; X = value.Z; W = value.W; }
		}
		public Vec4 Wxyx
		{
			get { return new Vec4(W, X, Y, X); }
			set { W = value.X; X = value.Y; Y = value.Z; X = value.W; }
		}
		public Vec4 Wxyy
		{
			get { return new Vec4(W, X, Y, Y); }
			set { W = value.X; X = value.Y; Y = value.Z; Y = value.W; }
		}
		public Vec4 Wxyz
		{
			get { return new Vec4(W, X, Y, Z); }
			set { W = value.X; X = value.Y; Y = value.Z; Z = value.W; }
		}
		public Vec4 Wxyw
		{
			get { return new Vec4(W, X, Y, W); }
			set { W = value.X; X = value.Y; Y = value.Z; W = value.W; }
		}
		public Vec4 Wxzx
		{
			get { return new Vec4(W, X, Z, X); }
			set { W = value.X; X = value.Y; Z = value.Z; X = value.W; }
		}
		public Vec4 Wxzy
		{
			get { return new Vec4(W, X, Z, Y); }
			set { W = value.X; X = value.Y; Z = value.Z; Y = value.W; }
		}
		public Vec4 Wxzz
		{
			get { return new Vec4(W, X, Z, Z); }
			set { W = value.X; X = value.Y; Z = value.Z; Z = value.W; }
		}
		public Vec4 Wxzw
		{
			get { return new Vec4(W, X, Z, W); }
			set { W = value.X; X = value.Y; Z = value.Z; W = value.W; }
		}
		public Vec4 Wxwx
		{
			get { return new Vec4(W, X, W, X); }
			set { W = value.X; X = value.Y; W = value.Z; X = value.W; }
		}
		public Vec4 Wxwy
		{
			get { return new Vec4(W, X, W, Y); }
			set { W = value.X; X = value.Y; W = value.Z; Y = value.W; }
		}
		public Vec4 Wxwz
		{
			get { return new Vec4(W, X, W, Z); }
			set { W = value.X; X = value.Y; W = value.Z; Z = value.W; }
		}
		public Vec4 Wxww
		{
			get { return new Vec4(W, X, W, W); }
			set { W = value.X; X = value.Y; W = value.Z; W = value.W; }
		}
		public Vec4 Wyxx
		{
			get { return new Vec4(W, Y, X, X); }
			set { W = value.X; Y = value.Y; X = value.Z; X = value.W; }
		}
		public Vec4 Wyxy
		{
			get { return new Vec4(W, Y, X, Y); }
			set { W = value.X; Y = value.Y; X = value.Z; Y = value.W; }
		}
		public Vec4 Wyxz
		{
			get { return new Vec4(W, Y, X, Z); }
			set { W = value.X; Y = value.Y; X = value.Z; Z = value.W; }
		}
		public Vec4 Wyxw
		{
			get { return new Vec4(W, Y, X, W); }
			set { W = value.X; Y = value.Y; X = value.Z; W = value.W; }
		}
		public Vec4 Wyyx
		{
			get { return new Vec4(W, Y, Y, X); }
			set { W = value.X; Y = value.Y; Y = value.Z; X = value.W; }
		}
		public Vec4 Wyyy
		{
			get { return new Vec4(W, Y, Y, Y); }
			set { W = value.X; Y = value.Y; Y = value.Z; Y = value.W; }
		}
		public Vec4 Wyyz
		{
			get { return new Vec4(W, Y, Y, Z); }
			set { W = value.X; Y = value.Y; Y = value.Z; Z = value.W; }
		}
		public Vec4 Wyyw
		{
			get { return new Vec4(W, Y, Y, W); }
			set { W = value.X; Y = value.Y; Y = value.Z; W = value.W; }
		}
		public Vec4 Wyzx
		{
			get { return new Vec4(W, Y, Z, X); }
			set { W = value.X; Y = value.Y; Z = value.Z; X = value.W; }
		}
		public Vec4 Wyzy
		{
			get { return new Vec4(W, Y, Z, Y); }
			set { W = value.X; Y = value.Y; Z = value.Z; Y = value.W; }
		}
		public Vec4 Wyzz
		{
			get { return new Vec4(W, Y, Z, Z); }
			set { W = value.X; Y = value.Y; Z = value.Z; Z = value.W; }
		}
		public Vec4 Wyzw
		{
			get { return new Vec4(W, Y, Z, W); }
			set { W = value.X; Y = value.Y; Z = value.Z; W = value.W; }
		}
		public Vec4 Wywx
		{
			get { return new Vec4(W, Y, W, X); }
			set { W = value.X; Y = value.Y; W = value.Z; X = value.W; }
		}
		public Vec4 Wywy
		{
			get { return new Vec4(W, Y, W, Y); }
			set { W = value.X; Y = value.Y; W = value.Z; Y = value.W; }
		}
		public Vec4 Wywz
		{
			get { return new Vec4(W, Y, W, Z); }
			set { W = value.X; Y = value.Y; W = value.Z; Z = value.W; }
		}
		public Vec4 Wyww
		{
			get { return new Vec4(W, Y, W, W); }
			set { W = value.X; Y = value.Y; W = value.Z; W = value.W; }
		}
		public Vec4 Wzxx
		{
			get { return new Vec4(W, Z, X, X); }
			set { W = value.X; Z = value.Y; X = value.Z; X = value.W; }
		}
		public Vec4 Wzxy
		{
			get { return new Vec4(W, Z, X, Y); }
			set { W = value.X; Z = value.Y; X = value.Z; Y = value.W; }
		}
		public Vec4 Wzxz
		{
			get { return new Vec4(W, Z, X, Z); }
			set { W = value.X; Z = value.Y; X = value.Z; Z = value.W; }
		}
		public Vec4 Wzxw
		{
			get { return new Vec4(W, Z, X, W); }
			set { W = value.X; Z = value.Y; X = value.Z; W = value.W; }
		}
		public Vec4 Wzyx
		{
			get { return new Vec4(W, Z, Y, X); }
			set { W = value.X; Z = value.Y; Y = value.Z; X = value.W; }
		}
		public Vec4 Wzyy
		{
			get { return new Vec4(W, Z, Y, Y); }
			set { W = value.X; Z = value.Y; Y = value.Z; Y = value.W; }
		}
		public Vec4 Wzyz
		{
			get { return new Vec4(W, Z, Y, Z); }
			set { W = value.X; Z = value.Y; Y = value.Z; Z = value.W; }
		}
		public Vec4 Wzyw
		{
			get { return new Vec4(W, Z, Y, W); }
			set { W = value.X; Z = value.Y; Y = value.Z; W = value.W; }
		}
		public Vec4 Wzzx
		{
			get { return new Vec4(W, Z, Z, X); }
			set { W = value.X; Z = value.Y; Z = value.Z; X = value.W; }
		}
		public Vec4 Wzzy
		{
			get { return new Vec4(W, Z, Z, Y); }
			set { W = value.X; Z = value.Y; Z = value.Z; Y = value.W; }
		}
		public Vec4 Wzzz
		{
			get { return new Vec4(W, Z, Z, Z); }
			set { W = value.X; Z = value.Y; Z = value.Z; Z = value.W; }
		}
		public Vec4 Wzzw
		{
			get { return new Vec4(W, Z, Z, W); }
			set { W = value.X; Z = value.Y; Z = value.Z; W = value.W; }
		}
		public Vec4 Wzwx
		{
			get { return new Vec4(W, Z, W, X); }
			set { W = value.X; Z = value.Y; W = value.Z; X = value.W; }
		}
		public Vec4 Wzwy
		{
			get { return new Vec4(W, Z, W, Y); }
			set { W = value.X; Z = value.Y; W = value.Z; Y = value.W; }
		}
		public Vec4 Wzwz
		{
			get { return new Vec4(W, Z, W, Z); }
			set { W = value.X; Z = value.Y; W = value.Z; Z = value.W; }
		}
		public Vec4 Wzww
		{
			get { return new Vec4(W, Z, W, W); }
			set { W = value.X; Z = value.Y; W = value.Z; W = value.W; }
		}
		public Vec4 Wwxx
		{
			get { return new Vec4(W, W, X, X); }
			set { W = value.X; W = value.Y; X = value.Z; X = value.W; }
		}
		public Vec4 Wwxy
		{
			get { return new Vec4(W, W, X, Y); }
			set { W = value.X; W = value.Y; X = value.Z; Y = value.W; }
		}
		public Vec4 Wwxz
		{
			get { return new Vec4(W, W, X, Z); }
			set { W = value.X; W = value.Y; X = value.Z; Z = value.W; }
		}
		public Vec4 Wwxw
		{
			get { return new Vec4(W, W, X, W); }
			set { W = value.X; W = value.Y; X = value.Z; W = value.W; }
		}
		public Vec4 Wwyx
		{
			get { return new Vec4(W, W, Y, X); }
			set { W = value.X; W = value.Y; Y = value.Z; X = value.W; }
		}
		public Vec4 Wwyy
		{
			get { return new Vec4(W, W, Y, Y); }
			set { W = value.X; W = value.Y; Y = value.Z; Y = value.W; }
		}
		public Vec4 Wwyz
		{
			get { return new Vec4(W, W, Y, Z); }
			set { W = value.X; W = value.Y; Y = value.Z; Z = value.W; }
		}
		public Vec4 Wwyw
		{
			get { return new Vec4(W, W, Y, W); }
			set { W = value.X; W = value.Y; Y = value.Z; W = value.W; }
		}
		public Vec4 Wwzx
		{
			get { return new Vec4(W, W, Z, X); }
			set { W = value.X; W = value.Y; Z = value.Z; X = value.W; }
		}
		public Vec4 Wwzy
		{
			get { return new Vec4(W, W, Z, Y); }
			set { W = value.X; W = value.Y; Z = value.Z; Y = value.W; }
		}
		public Vec4 Wwzz
		{
			get { return new Vec4(W, W, Z, Z); }
			set { W = value.X; W = value.Y; Z = value.Z; Z = value.W; }
		}
		public Vec4 Wwzw
		{
			get { return new Vec4(W, W, Z, W); }
			set { W = value.X; W = value.Y; Z = value.Z; W = value.W; }
		}
		public Vec4 Wwwx
		{
			get { return new Vec4(W, W, W, X); }
			set { W = value.X; W = value.Y; W = value.Z; X = value.W; }
		}
		public Vec4 Wwwy
		{
			get { return new Vec4(W, W, W, Y); }
			set { W = value.X; W = value.Y; W = value.Z; Y = value.W; }
		}
		public Vec4 Wwwz
		{
			get { return new Vec4(W, W, W, Z); }
			set { W = value.X; W = value.Y; W = value.Z; Z = value.W; }
		}
		public Vec4 Wwww
		{
			get { return new Vec4(W, W, W, W); }
			set { W = value.X; W = value.Y; W = value.Z; W = value.W; }
		}
		#endregion
		#endregion

		#region RGBA
		#region 2D
		public Vec2 Rr
		{
			get { return new Vec2(R, R); }
			set { R = value.X; R = value.Y; }
		}
		public Vec2 Rg
		{
			get { return new Vec2(R, G); }
			set { R = value.X; G = value.Y; }
		}
		public Vec2 Rb
		{
			get { return new Vec2(R, B); }
			set { R = value.X; B = value.Y; }
		}
		public Vec2 Ra
		{
			get { return new Vec2(R, A); }
			set { R = value.X; A = value.Y; }
		}
		public Vec2 Gr
		{
			get { return new Vec2(G, R); }
			set { G = value.X; R = value.Y; }
		}
		public Vec2 Gg
		{
			get { return new Vec2(G, G); }
			set { G = value.X; G = value.Y; }
		}
		public Vec2 Gb
		{
			get { return new Vec2(G, B); }
			set { G = value.X; B = value.Y; }
		}
		public Vec2 Ga
		{
			get { return new Vec2(G, A); }
			set { G = value.X; A = value.Y; }
		}
		public Vec2 Br
		{
			get { return new Vec2(B, R); }
			set { B = value.X; R = value.Y; }
		}
		public Vec2 Bg
		{
			get { return new Vec2(B, G); }
			set { B = value.X; G = value.Y; }
		}
		public Vec2 Bb
		{
			get { return new Vec2(B, B); }
			set { B = value.X; B = value.Y; }
		}
		public Vec2 Ba
		{
			get { return new Vec2(B, A); }
			set { B = value.X; A = value.Y; }
		}
		public Vec2 Ar
		{
			get { return new Vec2(A, R); }
			set { A = value.X; R = value.Y; }
		}
		public Vec2 Ag
		{
			get { return new Vec2(A, G); }
			set { A = value.X; G = value.Y; }
		}
		public Vec2 Ab
		{
			get { return new Vec2(A, B); }
			set { A = value.X; B = value.Y; }
		}
		public Vec2 Aa
		{
			get { return new Vec2(A, A); }
			set { A = value.X; A = value.Y; }
		}
		#endregion

		#region 3D
		public Vec3 Rrr
		{
			get { return new Vec3(R, R, R); }
			set { R = value.X; R = value.Y; R = value.Z; }
		}
		public Vec3 Rrg
		{
			get { return new Vec3(R, R, G); }
			set { R = value.X; R = value.Y; G = value.Z; }
		}
		public Vec3 Rrb
		{
			get { return new Vec3(R, R, B); }
			set { R = value.X; R = value.Y; B = value.Z; }
		}
		public Vec3 Rra
		{
			get { return new Vec3(R, R, A); }
			set { R = value.X; R = value.Y; A = value.Z; }
		}
		public Vec3 Rgr
		{
			get { return new Vec3(R, G, R); }
			set { R = value.X; G = value.Y; R = value.Z; }
		}
		public Vec3 Rgg
		{
			get { return new Vec3(R, G, G); }
			set { R = value.X; G = value.Y; G = value.Z; }
		}
		public Vec3 Rgb
		{
			get { return new Vec3(R, G, B); }
			set { R = value.X; G = value.Y; B = value.Z; }
		}
		public Vec3 Rga
		{
			get { return new Vec3(R, G, A); }
			set { R = value.X; G = value.Y; A = value.Z; }
		}
		public Vec3 Rbr
		{
			get { return new Vec3(R, B, R); }
			set { R = value.X; B = value.Y; R = value.Z; }
		}
		public Vec3 Rbg
		{
			get { return new Vec3(R, B, G); }
			set { R = value.X; B = value.Y; G = value.Z; }
		}
		public Vec3 Rbb
		{
			get { return new Vec3(R, B, B); }
			set { R = value.X; B = value.Y; B = value.Z; }
		}
		public Vec3 Rba
		{
			get { return new Vec3(R, B, A); }
			set { R = value.X; B = value.Y; A = value.Z; }
		}
		public Vec3 Rar
		{
			get { return new Vec3(R, A, R); }
			set { R = value.X; A = value.Y; R = value.Z; }
		}
		public Vec3 Rag
		{
			get { return new Vec3(R, A, G); }
			set { R = value.X; A = value.Y; G = value.Z; }
		}
		public Vec3 Rab
		{
			get { return new Vec3(R, A, B); }
			set { R = value.X; A = value.Y; B = value.Z; }
		}
		public Vec3 Raa
		{
			get { return new Vec3(R, A, A); }
			set { R = value.X; A = value.Y; A = value.Z; }
		}
		public Vec3 Grr
		{
			get { return new Vec3(G, R, R); }
			set { G = value.X; R = value.Y; R = value.Z; }
		}
		public Vec3 Grg
		{
			get { return new Vec3(G, R, G); }
			set { G = value.X; R = value.Y; G = value.Z; }
		}
		public Vec3 Grb
		{
			get { return new Vec3(G, R, B); }
			set { G = value.X; R = value.Y; B = value.Z; }
		}
		public Vec3 Gra
		{
			get { return new Vec3(G, R, A); }
			set { G = value.X; R = value.Y; A = value.Z; }
		}
		public Vec3 Ggr
		{
			get { return new Vec3(G, G, R); }
			set { G = value.X; G = value.Y; R = value.Z; }
		}
		public Vec3 Ggg
		{
			get { return new Vec3(G, G, G); }
			set { G = value.X; G = value.Y; G = value.Z; }
		}
		public Vec3 Ggb
		{
			get { return new Vec3(G, G, B); }
			set { G = value.X; G = value.Y; B = value.Z; }
		}
		public Vec3 Gga
		{
			get { return new Vec3(G, G, A); }
			set { G = value.X; G = value.Y; A = value.Z; }
		}
		public Vec3 Gbr
		{
			get { return new Vec3(G, B, R); }
			set { G = value.X; B = value.Y; R = value.Z; }
		}
		public Vec3 Gbg
		{
			get { return new Vec3(G, B, G); }
			set { G = value.X; B = value.Y; G = value.Z; }
		}
		public Vec3 Gbb
		{
			get { return new Vec3(G, B, B); }
			set { G = value.X; B = value.Y; B = value.Z; }
		}
		public Vec3 Gba
		{
			get { return new Vec3(G, B, A); }
			set { G = value.X; B = value.Y; A = value.Z; }
		}
		public Vec3 Gar
		{
			get { return new Vec3(G, A, R); }
			set { G = value.X; A = value.Y; R = value.Z; }
		}
		public Vec3 Gag
		{
			get { return new Vec3(G, A, G); }
			set { G = value.X; A = value.Y; G = value.Z; }
		}
		public Vec3 Gab
		{
			get { return new Vec3(G, A, B); }
			set { G = value.X; A = value.Y; B = value.Z; }
		}
		public Vec3 Gaa
		{
			get { return new Vec3(G, A, A); }
			set { G = value.X; A = value.Y; A = value.Z; }
		}
		public Vec3 Brr
		{
			get { return new Vec3(B, R, R); }
			set { B = value.X; R = value.Y; R = value.Z; }
		}
		public Vec3 Brg
		{
			get { return new Vec3(B, R, G); }
			set { B = value.X; R = value.Y; G = value.Z; }
		}
		public Vec3 Brb
		{
			get { return new Vec3(B, R, B); }
			set { B = value.X; R = value.Y; B = value.Z; }
		}
		public Vec3 Bra
		{
			get { return new Vec3(B, R, A); }
			set { B = value.X; R = value.Y; A = value.Z; }
		}
		public Vec3 Bgr
		{
			get { return new Vec3(B, G, R); }
			set { B = value.X; G = value.Y; R = value.Z; }
		}
		public Vec3 Bgg
		{
			get { return new Vec3(B, G, G); }
			set { B = value.X; G = value.Y; G = value.Z; }
		}
		public Vec3 Bgb
		{
			get { return new Vec3(B, G, B); }
			set { B = value.X; G = value.Y; B = value.Z; }
		}
		public Vec3 Bga
		{
			get { return new Vec3(B, G, A); }
			set { B = value.X; G = value.Y; A = value.Z; }
		}
		public Vec3 Bbr
		{
			get { return new Vec3(B, B, R); }
			set { B = value.X; B = value.Y; R = value.Z; }
		}
		public Vec3 Bbg
		{
			get { return new Vec3(B, B, G); }
			set { B = value.X; B = value.Y; G = value.Z; }
		}
		public Vec3 Bbb
		{
			get { return new Vec3(B, B, B); }
			set { B = value.X; B = value.Y; B = value.Z; }
		}
		public Vec3 Bba
		{
			get { return new Vec3(B, B, A); }
			set { B = value.X; B = value.Y; A = value.Z; }
		}
		public Vec3 Bar
		{
			get { return new Vec3(B, A, R); }
			set { B = value.X; A = value.Y; R = value.Z; }
		}
		public Vec3 Bag
		{
			get { return new Vec3(B, A, G); }
			set { B = value.X; A = value.Y; G = value.Z; }
		}
		public Vec3 Bab
		{
			get { return new Vec3(B, A, B); }
			set { B = value.X; A = value.Y; B = value.Z; }
		}
		public Vec3 Baa
		{
			get { return new Vec3(B, A, A); }
			set { B = value.X; A = value.Y; A = value.Z; }
		}
		public Vec3 Arr
		{
			get { return new Vec3(A, R, R); }
			set { A = value.X; R = value.Y; R = value.Z; }
		}
		public Vec3 Arg
		{
			get { return new Vec3(A, R, G); }
			set { A = value.X; R = value.Y; G = value.Z; }
		}
		public Vec3 Arb
		{
			get { return new Vec3(A, R, B); }
			set { A = value.X; R = value.Y; B = value.Z; }
		}
		public Vec3 Ara
		{
			get { return new Vec3(A, R, A); }
			set { A = value.X; R = value.Y; A = value.Z; }
		}
		public Vec3 Agr
		{
			get { return new Vec3(A, G, R); }
			set { A = value.X; G = value.Y; R = value.Z; }
		}
		public Vec3 Agg
		{
			get { return new Vec3(A, G, G); }
			set { A = value.X; G = value.Y; G = value.Z; }
		}
		public Vec3 Agb
		{
			get { return new Vec3(A, G, B); }
			set { A = value.X; G = value.Y; B = value.Z; }
		}
		public Vec3 Aga
		{
			get { return new Vec3(A, G, A); }
			set { A = value.X; G = value.Y; A = value.Z; }
		}
		public Vec3 Abr
		{
			get { return new Vec3(A, B, R); }
			set { A = value.X; B = value.Y; R = value.Z; }
		}
		public Vec3 Abg
		{
			get { return new Vec3(A, B, G); }
			set { A = value.X; B = value.Y; G = value.Z; }
		}
		public Vec3 Abb
		{
			get { return new Vec3(A, B, B); }
			set { A = value.X; B = value.Y; B = value.Z; }
		}
		public Vec3 Aba
		{
			get { return new Vec3(A, B, A); }
			set { A = value.X; B = value.Y; A = value.Z; }
		}
		public Vec3 Aar
		{
			get { return new Vec3(A, A, R); }
			set { A = value.X; A = value.Y; R = value.Z; }
		}
		public Vec3 Aag
		{
			get { return new Vec3(A, A, G); }
			set { A = value.X; A = value.Y; G = value.Z; }
		}
		public Vec3 Aab
		{
			get { return new Vec3(A, A, B); }
			set { A = value.X; A = value.Y; B = value.Z; }
		}
		public Vec3 Aaa
		{
			get { return new Vec3(A, A, A); }
			set { A = value.X; A = value.Y; A = value.Z; }
		}
		#endregion

		#region 4D
		public Vec4 Rrrr
		{
			get { return new Vec4(R, R, R, R); }
			set { R = value.X; R = value.Y; R = value.Z; R = value.W; }
		}
		public Vec4 Rrrg
		{
			get { return new Vec4(R, R, R, G); }
			set { R = value.X; R = value.Y; R = value.Z; G = value.W; }
		}
		public Vec4 Rrrb
		{
			get { return new Vec4(R, R, R, B); }
			set { R = value.X; R = value.Y; R = value.Z; B = value.W; }
		}
		public Vec4 Rrra
		{
			get { return new Vec4(R, R, R, A); }
			set { R = value.X; R = value.Y; R = value.Z; A = value.W; }
		}
		public Vec4 Rrgr
		{
			get { return new Vec4(R, R, G, R); }
			set { R = value.X; R = value.Y; G = value.Z; R = value.W; }
		}
		public Vec4 Rrgg
		{
			get { return new Vec4(R, R, G, G); }
			set { R = value.X; R = value.Y; G = value.Z; G = value.W; }
		}
		public Vec4 Rrgb
		{
			get { return new Vec4(R, R, G, B); }
			set { R = value.X; R = value.Y; G = value.Z; B = value.W; }
		}
		public Vec4 Rrga
		{
			get { return new Vec4(R, R, G, A); }
			set { R = value.X; R = value.Y; G = value.Z; A = value.W; }
		}
		public Vec4 Rrbr
		{
			get { return new Vec4(R, R, B, R); }
			set { R = value.X; R = value.Y; B = value.Z; R = value.W; }
		}
		public Vec4 Rrbg
		{
			get { return new Vec4(R, R, B, G); }
			set { R = value.X; R = value.Y; B = value.Z; G = value.W; }
		}
		public Vec4 Rrbb
		{
			get { return new Vec4(R, R, B, B); }
			set { R = value.X; R = value.Y; B = value.Z; B = value.W; }
		}
		public Vec4 Rrba
		{
			get { return new Vec4(R, R, B, A); }
			set { R = value.X; R = value.Y; B = value.Z; A = value.W; }
		}
		public Vec4 Rrar
		{
			get { return new Vec4(R, R, A, R); }
			set { R = value.X; R = value.Y; A = value.Z; R = value.W; }
		}
		public Vec4 Rrag
		{
			get { return new Vec4(R, R, A, G); }
			set { R = value.X; R = value.Y; A = value.Z; G = value.W; }
		}
		public Vec4 Rrab
		{
			get { return new Vec4(R, R, A, B); }
			set { R = value.X; R = value.Y; A = value.Z; B = value.W; }
		}
		public Vec4 Rraa
		{
			get { return new Vec4(R, R, A, A); }
			set { R = value.X; R = value.Y; A = value.Z; A = value.W; }
		}
		public Vec4 Rgrr
		{
			get { return new Vec4(R, G, R, R); }
			set { R = value.X; G = value.Y; R = value.Z; R = value.W; }
		}
		public Vec4 Rgrg
		{
			get { return new Vec4(R, G, R, G); }
			set { R = value.X; G = value.Y; R = value.Z; G = value.W; }
		}
		public Vec4 Rgrb
		{
			get { return new Vec4(R, G, R, B); }
			set { R = value.X; G = value.Y; R = value.Z; B = value.W; }
		}
		public Vec4 Rgra
		{
			get { return new Vec4(R, G, R, A); }
			set { R = value.X; G = value.Y; R = value.Z; A = value.W; }
		}
		public Vec4 Rggr
		{
			get { return new Vec4(R, G, G, R); }
			set { R = value.X; G = value.Y; G = value.Z; R = value.W; }
		}
		public Vec4 Rggg
		{
			get { return new Vec4(R, G, G, G); }
			set { R = value.X; G = value.Y; G = value.Z; G = value.W; }
		}
		public Vec4 Rggb
		{
			get { return new Vec4(R, G, G, B); }
			set { R = value.X; G = value.Y; G = value.Z; B = value.W; }
		}
		public Vec4 Rgga
		{
			get { return new Vec4(R, G, G, A); }
			set { R = value.X; G = value.Y; G = value.Z; A = value.W; }
		}
		public Vec4 Rgbr
		{
			get { return new Vec4(R, G, B, R); }
			set { R = value.X; G = value.Y; B = value.Z; R = value.W; }
		}
		public Vec4 Rgbg
		{
			get { return new Vec4(R, G, B, G); }
			set { R = value.X; G = value.Y; B = value.Z; G = value.W; }
		}
		public Vec4 Rgbb
		{
			get { return new Vec4(R, G, B, B); }
			set { R = value.X; G = value.Y; B = value.Z; B = value.W; }
		}
		public Vec4 Rgba
		{
			get { return new Vec4(R, G, B, A); }
			set { R = value.X; G = value.Y; B = value.Z; A = value.W; }
		}
		public Vec4 Rgar
		{
			get { return new Vec4(R, G, A, R); }
			set { R = value.X; G = value.Y; A = value.Z; R = value.W; }
		}
		public Vec4 Rgag
		{
			get { return new Vec4(R, G, A, G); }
			set { R = value.X; G = value.Y; A = value.Z; G = value.W; }
		}
		public Vec4 Rgab
		{
			get { return new Vec4(R, G, A, B); }
			set { R = value.X; G = value.Y; A = value.Z; B = value.W; }
		}
		public Vec4 Rgaa
		{
			get { return new Vec4(R, G, A, A); }
			set { R = value.X; G = value.Y; A = value.Z; A = value.W; }
		}
		public Vec4 Rbrr
		{
			get { return new Vec4(R, B, R, R); }
			set { R = value.X; B = value.Y; R = value.Z; R = value.W; }
		}
		public Vec4 Rbrg
		{
			get { return new Vec4(R, B, R, G); }
			set { R = value.X; B = value.Y; R = value.Z; G = value.W; }
		}
		public Vec4 Rbrb
		{
			get { return new Vec4(R, B, R, B); }
			set { R = value.X; B = value.Y; R = value.Z; B = value.W; }
		}
		public Vec4 Rbra
		{
			get { return new Vec4(R, B, R, A); }
			set { R = value.X; B = value.Y; R = value.Z; A = value.W; }
		}
		public Vec4 Rbgr
		{
			get { return new Vec4(R, B, G, R); }
			set { R = value.X; B = value.Y; G = value.Z; R = value.W; }
		}
		public Vec4 Rbgg
		{
			get { return new Vec4(R, B, G, G); }
			set { R = value.X; B = value.Y; G = value.Z; G = value.W; }
		}
		public Vec4 Rbgb
		{
			get { return new Vec4(R, B, G, B); }
			set { R = value.X; B = value.Y; G = value.Z; B = value.W; }
		}
		public Vec4 Rbga
		{
			get { return new Vec4(R, B, G, A); }
			set { R = value.X; B = value.Y; G = value.Z; A = value.W; }
		}
		public Vec4 Rbbr
		{
			get { return new Vec4(R, B, B, R); }
			set { R = value.X; B = value.Y; B = value.Z; R = value.W; }
		}
		public Vec4 Rbbg
		{
			get { return new Vec4(R, B, B, G); }
			set { R = value.X; B = value.Y; B = value.Z; G = value.W; }
		}
		public Vec4 Rbbb
		{
			get { return new Vec4(R, B, B, B); }
			set { R = value.X; B = value.Y; B = value.Z; B = value.W; }
		}
		public Vec4 Rbba
		{
			get { return new Vec4(R, B, B, A); }
			set { R = value.X; B = value.Y; B = value.Z; A = value.W; }
		}
		public Vec4 Rbar
		{
			get { return new Vec4(R, B, A, R); }
			set { R = value.X; B = value.Y; A = value.Z; R = value.W; }
		}
		public Vec4 Rbag
		{
			get { return new Vec4(R, B, A, G); }
			set { R = value.X; B = value.Y; A = value.Z; G = value.W; }
		}
		public Vec4 Rbab
		{
			get { return new Vec4(R, B, A, B); }
			set { R = value.X; B = value.Y; A = value.Z; B = value.W; }
		}
		public Vec4 Rbaa
		{
			get { return new Vec4(R, B, A, A); }
			set { R = value.X; B = value.Y; A = value.Z; A = value.W; }
		}
		public Vec4 Rarr
		{
			get { return new Vec4(R, A, R, R); }
			set { R = value.X; A = value.Y; R = value.Z; R = value.W; }
		}
		public Vec4 Rarg
		{
			get { return new Vec4(R, A, R, G); }
			set { R = value.X; A = value.Y; R = value.Z; G = value.W; }
		}
		public Vec4 Rarb
		{
			get { return new Vec4(R, A, R, B); }
			set { R = value.X; A = value.Y; R = value.Z; B = value.W; }
		}
		public Vec4 Rara
		{
			get { return new Vec4(R, A, R, A); }
			set { R = value.X; A = value.Y; R = value.Z; A = value.W; }
		}
		public Vec4 Ragr
		{
			get { return new Vec4(R, A, G, R); }
			set { R = value.X; A = value.Y; G = value.Z; R = value.W; }
		}
		public Vec4 Ragg
		{
			get { return new Vec4(R, A, G, G); }
			set { R = value.X; A = value.Y; G = value.Z; G = value.W; }
		}
		public Vec4 Ragb
		{
			get { return new Vec4(R, A, G, B); }
			set { R = value.X; A = value.Y; G = value.Z; B = value.W; }
		}
		public Vec4 Raga
		{
			get { return new Vec4(R, A, G, A); }
			set { R = value.X; A = value.Y; G = value.Z; A = value.W; }
		}
		public Vec4 Rabr
		{
			get { return new Vec4(R, A, B, R); }
			set { R = value.X; A = value.Y; B = value.Z; R = value.W; }
		}
		public Vec4 Rabg
		{
			get { return new Vec4(R, A, B, G); }
			set { R = value.X; A = value.Y; B = value.Z; G = value.W; }
		}
		public Vec4 Rabb
		{
			get { return new Vec4(R, A, B, B); }
			set { R = value.X; A = value.Y; B = value.Z; B = value.W; }
		}
		public Vec4 Raba
		{
			get { return new Vec4(R, A, B, A); }
			set { R = value.X; A = value.Y; B = value.Z; A = value.W; }
		}
		public Vec4 Raar
		{
			get { return new Vec4(R, A, A, R); }
			set { R = value.X; A = value.Y; A = value.Z; R = value.W; }
		}
		public Vec4 Raag
		{
			get { return new Vec4(R, A, A, G); }
			set { R = value.X; A = value.Y; A = value.Z; G = value.W; }
		}
		public Vec4 Raab
		{
			get { return new Vec4(R, A, A, B); }
			set { R = value.X; A = value.Y; A = value.Z; B = value.W; }
		}
		public Vec4 Raaa
		{
			get { return new Vec4(R, A, A, A); }
			set { R = value.X; A = value.Y; A = value.Z; A = value.W; }
		}
		public Vec4 Grrr
		{
			get { return new Vec4(G, R, R, R); }
			set { G = value.X; R = value.Y; R = value.Z; R = value.W; }
		}
		public Vec4 Grrg
		{
			get { return new Vec4(G, R, R, G); }
			set { G = value.X; R = value.Y; R = value.Z; G = value.W; }
		}
		public Vec4 Grrb
		{
			get { return new Vec4(G, R, R, B); }
			set { G = value.X; R = value.Y; R = value.Z; B = value.W; }
		}
		public Vec4 Grra
		{
			get { return new Vec4(G, R, R, A); }
			set { G = value.X; R = value.Y; R = value.Z; A = value.W; }
		}
		public Vec4 Grgr
		{
			get { return new Vec4(G, R, G, R); }
			set { G = value.X; R = value.Y; G = value.Z; R = value.W; }
		}
		public Vec4 Grgg
		{
			get { return new Vec4(G, R, G, G); }
			set { G = value.X; R = value.Y; G = value.Z; G = value.W; }
		}
		public Vec4 Grgb
		{
			get { return new Vec4(G, R, G, B); }
			set { G = value.X; R = value.Y; G = value.Z; B = value.W; }
		}
		public Vec4 Grga
		{
			get { return new Vec4(G, R, G, A); }
			set { G = value.X; R = value.Y; G = value.Z; A = value.W; }
		}
		public Vec4 Grbr
		{
			get { return new Vec4(G, R, B, R); }
			set { G = value.X; R = value.Y; B = value.Z; R = value.W; }
		}
		public Vec4 Grbg
		{
			get { return new Vec4(G, R, B, G); }
			set { G = value.X; R = value.Y; B = value.Z; G = value.W; }
		}
		public Vec4 Grbb
		{
			get { return new Vec4(G, R, B, B); }
			set { G = value.X; R = value.Y; B = value.Z; B = value.W; }
		}
		public Vec4 Grba
		{
			get { return new Vec4(G, R, B, A); }
			set { G = value.X; R = value.Y; B = value.Z; A = value.W; }
		}
		public Vec4 Grar
		{
			get { return new Vec4(G, R, A, R); }
			set { G = value.X; R = value.Y; A = value.Z; R = value.W; }
		}
		public Vec4 Grag
		{
			get { return new Vec4(G, R, A, G); }
			set { G = value.X; R = value.Y; A = value.Z; G = value.W; }
		}
		public Vec4 Grab
		{
			get { return new Vec4(G, R, A, B); }
			set { G = value.X; R = value.Y; A = value.Z; B = value.W; }
		}
		public Vec4 Graa
		{
			get { return new Vec4(G, R, A, A); }
			set { G = value.X; R = value.Y; A = value.Z; A = value.W; }
		}
		public Vec4 Ggrr
		{
			get { return new Vec4(G, G, R, R); }
			set { G = value.X; G = value.Y; R = value.Z; R = value.W; }
		}
		public Vec4 Ggrg
		{
			get { return new Vec4(G, G, R, G); }
			set { G = value.X; G = value.Y; R = value.Z; G = value.W; }
		}
		public Vec4 Ggrb
		{
			get { return new Vec4(G, G, R, B); }
			set { G = value.X; G = value.Y; R = value.Z; B = value.W; }
		}
		public Vec4 Ggra
		{
			get { return new Vec4(G, G, R, A); }
			set { G = value.X; G = value.Y; R = value.Z; A = value.W; }
		}
		public Vec4 Gggr
		{
			get { return new Vec4(G, G, G, R); }
			set { G = value.X; G = value.Y; G = value.Z; R = value.W; }
		}
		public Vec4 Gggg
		{
			get { return new Vec4(G, G, G, G); }
			set { G = value.X; G = value.Y; G = value.Z; G = value.W; }
		}
		public Vec4 Gggb
		{
			get { return new Vec4(G, G, G, B); }
			set { G = value.X; G = value.Y; G = value.Z; B = value.W; }
		}
		public Vec4 Ggga
		{
			get { return new Vec4(G, G, G, A); }
			set { G = value.X; G = value.Y; G = value.Z; A = value.W; }
		}
		public Vec4 Ggbr
		{
			get { return new Vec4(G, G, B, R); }
			set { G = value.X; G = value.Y; B = value.Z; R = value.W; }
		}
		public Vec4 Ggbg
		{
			get { return new Vec4(G, G, B, G); }
			set { G = value.X; G = value.Y; B = value.Z; G = value.W; }
		}
		public Vec4 Ggbb
		{
			get { return new Vec4(G, G, B, B); }
			set { G = value.X; G = value.Y; B = value.Z; B = value.W; }
		}
		public Vec4 Ggba
		{
			get { return new Vec4(G, G, B, A); }
			set { G = value.X; G = value.Y; B = value.Z; A = value.W; }
		}
		public Vec4 Ggar
		{
			get { return new Vec4(G, G, A, R); }
			set { G = value.X; G = value.Y; A = value.Z; R = value.W; }
		}
		public Vec4 Ggag
		{
			get { return new Vec4(G, G, A, G); }
			set { G = value.X; G = value.Y; A = value.Z; G = value.W; }
		}
		public Vec4 Ggab
		{
			get { return new Vec4(G, G, A, B); }
			set { G = value.X; G = value.Y; A = value.Z; B = value.W; }
		}
		public Vec4 Ggaa
		{
			get { return new Vec4(G, G, A, A); }
			set { G = value.X; G = value.Y; A = value.Z; A = value.W; }
		}
		public Vec4 Gbrr
		{
			get { return new Vec4(G, B, R, R); }
			set { G = value.X; B = value.Y; R = value.Z; R = value.W; }
		}
		public Vec4 Gbrg
		{
			get { return new Vec4(G, B, R, G); }
			set { G = value.X; B = value.Y; R = value.Z; G = value.W; }
		}
		public Vec4 Gbrb
		{
			get { return new Vec4(G, B, R, B); }
			set { G = value.X; B = value.Y; R = value.Z; B = value.W; }
		}
		public Vec4 Gbra
		{
			get { return new Vec4(G, B, R, A); }
			set { G = value.X; B = value.Y; R = value.Z; A = value.W; }
		}
		public Vec4 Gbgr
		{
			get { return new Vec4(G, B, G, R); }
			set { G = value.X; B = value.Y; G = value.Z; R = value.W; }
		}
		public Vec4 Gbgg
		{
			get { return new Vec4(G, B, G, G); }
			set { G = value.X; B = value.Y; G = value.Z; G = value.W; }
		}
		public Vec4 Gbgb
		{
			get { return new Vec4(G, B, G, B); }
			set { G = value.X; B = value.Y; G = value.Z; B = value.W; }
		}
		public Vec4 Gbga
		{
			get { return new Vec4(G, B, G, A); }
			set { G = value.X; B = value.Y; G = value.Z; A = value.W; }
		}
		public Vec4 Gbbr
		{
			get { return new Vec4(G, B, B, R); }
			set { G = value.X; B = value.Y; B = value.Z; R = value.W; }
		}
		public Vec4 Gbbg
		{
			get { return new Vec4(G, B, B, G); }
			set { G = value.X; B = value.Y; B = value.Z; G = value.W; }
		}
		public Vec4 Gbbb
		{
			get { return new Vec4(G, B, B, B); }
			set { G = value.X; B = value.Y; B = value.Z; B = value.W; }
		}
		public Vec4 Gbba
		{
			get { return new Vec4(G, B, B, A); }
			set { G = value.X; B = value.Y; B = value.Z; A = value.W; }
		}
		public Vec4 Gbar
		{
			get { return new Vec4(G, B, A, R); }
			set { G = value.X; B = value.Y; A = value.Z; R = value.W; }
		}
		public Vec4 Gbag
		{
			get { return new Vec4(G, B, A, G); }
			set { G = value.X; B = value.Y; A = value.Z; G = value.W; }
		}
		public Vec4 Gbab
		{
			get { return new Vec4(G, B, A, B); }
			set { G = value.X; B = value.Y; A = value.Z; B = value.W; }
		}
		public Vec4 Gbaa
		{
			get { return new Vec4(G, B, A, A); }
			set { G = value.X; B = value.Y; A = value.Z; A = value.W; }
		}
		public Vec4 Garr
		{
			get { return new Vec4(G, A, R, R); }
			set { G = value.X; A = value.Y; R = value.Z; R = value.W; }
		}
		public Vec4 Garg
		{
			get { return new Vec4(G, A, R, G); }
			set { G = value.X; A = value.Y; R = value.Z; G = value.W; }
		}
		public Vec4 Garb
		{
			get { return new Vec4(G, A, R, B); }
			set { G = value.X; A = value.Y; R = value.Z; B = value.W; }
		}
		public Vec4 Gara
		{
			get { return new Vec4(G, A, R, A); }
			set { G = value.X; A = value.Y; R = value.Z; A = value.W; }
		}
		public Vec4 Gagr
		{
			get { return new Vec4(G, A, G, R); }
			set { G = value.X; A = value.Y; G = value.Z; R = value.W; }
		}
		public Vec4 Gagg
		{
			get { return new Vec4(G, A, G, G); }
			set { G = value.X; A = value.Y; G = value.Z; G = value.W; }
		}
		public Vec4 Gagb
		{
			get { return new Vec4(G, A, G, B); }
			set { G = value.X; A = value.Y; G = value.Z; B = value.W; }
		}
		public Vec4 Gaga
		{
			get { return new Vec4(G, A, G, A); }
			set { G = value.X; A = value.Y; G = value.Z; A = value.W; }
		}
		public Vec4 Gabr
		{
			get { return new Vec4(G, A, B, R); }
			set { G = value.X; A = value.Y; B = value.Z; R = value.W; }
		}
		public Vec4 Gabg
		{
			get { return new Vec4(G, A, B, G); }
			set { G = value.X; A = value.Y; B = value.Z; G = value.W; }
		}
		public Vec4 Gabb
		{
			get { return new Vec4(G, A, B, B); }
			set { G = value.X; A = value.Y; B = value.Z; B = value.W; }
		}
		public Vec4 Gaba
		{
			get { return new Vec4(G, A, B, A); }
			set { G = value.X; A = value.Y; B = value.Z; A = value.W; }
		}
		public Vec4 Gaar
		{
			get { return new Vec4(G, A, A, R); }
			set { G = value.X; A = value.Y; A = value.Z; R = value.W; }
		}
		public Vec4 Gaag
		{
			get { return new Vec4(G, A, A, G); }
			set { G = value.X; A = value.Y; A = value.Z; G = value.W; }
		}
		public Vec4 Gaab
		{
			get { return new Vec4(G, A, A, B); }
			set { G = value.X; A = value.Y; A = value.Z; B = value.W; }
		}
		public Vec4 Gaaa
		{
			get { return new Vec4(G, A, A, A); }
			set { G = value.X; A = value.Y; A = value.Z; A = value.W; }
		}
		public Vec4 Brrr
		{
			get { return new Vec4(B, R, R, R); }
			set { B = value.X; R = value.Y; R = value.Z; R = value.W; }
		}
		public Vec4 Brrg
		{
			get { return new Vec4(B, R, R, G); }
			set { B = value.X; R = value.Y; R = value.Z; G = value.W; }
		}
		public Vec4 Brrb
		{
			get { return new Vec4(B, R, R, B); }
			set { B = value.X; R = value.Y; R = value.Z; B = value.W; }
		}
		public Vec4 Brra
		{
			get { return new Vec4(B, R, R, A); }
			set { B = value.X; R = value.Y; R = value.Z; A = value.W; }
		}
		public Vec4 Brgr
		{
			get { return new Vec4(B, R, G, R); }
			set { B = value.X; R = value.Y; G = value.Z; R = value.W; }
		}
		public Vec4 Brgg
		{
			get { return new Vec4(B, R, G, G); }
			set { B = value.X; R = value.Y; G = value.Z; G = value.W; }
		}
		public Vec4 Brgb
		{
			get { return new Vec4(B, R, G, B); }
			set { B = value.X; R = value.Y; G = value.Z; B = value.W; }
		}
		public Vec4 Brga
		{
			get { return new Vec4(B, R, G, A); }
			set { B = value.X; R = value.Y; G = value.Z; A = value.W; }
		}
		public Vec4 Brbr
		{
			get { return new Vec4(B, R, B, R); }
			set { B = value.X; R = value.Y; B = value.Z; R = value.W; }
		}
		public Vec4 Brbg
		{
			get { return new Vec4(B, R, B, G); }
			set { B = value.X; R = value.Y; B = value.Z; G = value.W; }
		}
		public Vec4 Brbb
		{
			get { return new Vec4(B, R, B, B); }
			set { B = value.X; R = value.Y; B = value.Z; B = value.W; }
		}
		public Vec4 Brba
		{
			get { return new Vec4(B, R, B, A); }
			set { B = value.X; R = value.Y; B = value.Z; A = value.W; }
		}
		public Vec4 Brar
		{
			get { return new Vec4(B, R, A, R); }
			set { B = value.X; R = value.Y; A = value.Z; R = value.W; }
		}
		public Vec4 Brag
		{
			get { return new Vec4(B, R, A, G); }
			set { B = value.X; R = value.Y; A = value.Z; G = value.W; }
		}
		public Vec4 Brab
		{
			get { return new Vec4(B, R, A, B); }
			set { B = value.X; R = value.Y; A = value.Z; B = value.W; }
		}
		public Vec4 Braa
		{
			get { return new Vec4(B, R, A, A); }
			set { B = value.X; R = value.Y; A = value.Z; A = value.W; }
		}
		public Vec4 Bgrr
		{
			get { return new Vec4(B, G, R, R); }
			set { B = value.X; G = value.Y; R = value.Z; R = value.W; }
		}
		public Vec4 Bgrg
		{
			get { return new Vec4(B, G, R, G); }
			set { B = value.X; G = value.Y; R = value.Z; G = value.W; }
		}
		public Vec4 Bgrb
		{
			get { return new Vec4(B, G, R, B); }
			set { B = value.X; G = value.Y; R = value.Z; B = value.W; }
		}
		public Vec4 Bgra
		{
			get { return new Vec4(B, G, R, A); }
			set { B = value.X; G = value.Y; R = value.Z; A = value.W; }
		}
		public Vec4 Bggr
		{
			get { return new Vec4(B, G, G, R); }
			set { B = value.X; G = value.Y; G = value.Z; R = value.W; }
		}
		public Vec4 Bggg
		{
			get { return new Vec4(B, G, G, G); }
			set { B = value.X; G = value.Y; G = value.Z; G = value.W; }
		}
		public Vec4 Bggb
		{
			get { return new Vec4(B, G, G, B); }
			set { B = value.X; G = value.Y; G = value.Z; B = value.W; }
		}
		public Vec4 Bgga
		{
			get { return new Vec4(B, G, G, A); }
			set { B = value.X; G = value.Y; G = value.Z; A = value.W; }
		}
		public Vec4 Bgbr
		{
			get { return new Vec4(B, G, B, R); }
			set { B = value.X; G = value.Y; B = value.Z; R = value.W; }
		}
		public Vec4 Bgbg
		{
			get { return new Vec4(B, G, B, G); }
			set { B = value.X; G = value.Y; B = value.Z; G = value.W; }
		}
		public Vec4 Bgbb
		{
			get { return new Vec4(B, G, B, B); }
			set { B = value.X; G = value.Y; B = value.Z; B = value.W; }
		}
		public Vec4 Bgba
		{
			get { return new Vec4(B, G, B, A); }
			set { B = value.X; G = value.Y; B = value.Z; A = value.W; }
		}
		public Vec4 Bgar
		{
			get { return new Vec4(B, G, A, R); }
			set { B = value.X; G = value.Y; A = value.Z; R = value.W; }
		}
		public Vec4 Bgag
		{
			get { return new Vec4(B, G, A, G); }
			set { B = value.X; G = value.Y; A = value.Z; G = value.W; }
		}
		public Vec4 Bgab
		{
			get { return new Vec4(B, G, A, B); }
			set { B = value.X; G = value.Y; A = value.Z; B = value.W; }
		}
		public Vec4 Bgaa
		{
			get { return new Vec4(B, G, A, A); }
			set { B = value.X; G = value.Y; A = value.Z; A = value.W; }
		}
		public Vec4 Bbrr
		{
			get { return new Vec4(B, B, R, R); }
			set { B = value.X; B = value.Y; R = value.Z; R = value.W; }
		}
		public Vec4 Bbrg
		{
			get { return new Vec4(B, B, R, G); }
			set { B = value.X; B = value.Y; R = value.Z; G = value.W; }
		}
		public Vec4 Bbrb
		{
			get { return new Vec4(B, B, R, B); }
			set { B = value.X; B = value.Y; R = value.Z; B = value.W; }
		}
		public Vec4 Bbra
		{
			get { return new Vec4(B, B, R, A); }
			set { B = value.X; B = value.Y; R = value.Z; A = value.W; }
		}
		public Vec4 Bbgr
		{
			get { return new Vec4(B, B, G, R); }
			set { B = value.X; B = value.Y; G = value.Z; R = value.W; }
		}
		public Vec4 Bbgg
		{
			get { return new Vec4(B, B, G, G); }
			set { B = value.X; B = value.Y; G = value.Z; G = value.W; }
		}
		public Vec4 Bbgb
		{
			get { return new Vec4(B, B, G, B); }
			set { B = value.X; B = value.Y; G = value.Z; B = value.W; }
		}
		public Vec4 Bbga
		{
			get { return new Vec4(B, B, G, A); }
			set { B = value.X; B = value.Y; G = value.Z; A = value.W; }
		}
		public Vec4 Bbbr
		{
			get { return new Vec4(B, B, B, R); }
			set { B = value.X; B = value.Y; B = value.Z; R = value.W; }
		}
		public Vec4 Bbbg
		{
			get { return new Vec4(B, B, B, G); }
			set { B = value.X; B = value.Y; B = value.Z; G = value.W; }
		}
		public Vec4 Bbbb
		{
			get { return new Vec4(B, B, B, B); }
			set { B = value.X; B = value.Y; B = value.Z; B = value.W; }
		}
		public Vec4 Bbba
		{
			get { return new Vec4(B, B, B, A); }
			set { B = value.X; B = value.Y; B = value.Z; A = value.W; }
		}
		public Vec4 Bbar
		{
			get { return new Vec4(B, B, A, R); }
			set { B = value.X; B = value.Y; A = value.Z; R = value.W; }
		}
		public Vec4 Bbag
		{
			get { return new Vec4(B, B, A, G); }
			set { B = value.X; B = value.Y; A = value.Z; G = value.W; }
		}
		public Vec4 Bbab
		{
			get { return new Vec4(B, B, A, B); }
			set { B = value.X; B = value.Y; A = value.Z; B = value.W; }
		}
		public Vec4 Bbaa
		{
			get { return new Vec4(B, B, A, A); }
			set { B = value.X; B = value.Y; A = value.Z; A = value.W; }
		}
		public Vec4 Barr
		{
			get { return new Vec4(B, A, R, R); }
			set { B = value.X; A = value.Y; R = value.Z; R = value.W; }
		}
		public Vec4 Barg
		{
			get { return new Vec4(B, A, R, G); }
			set { B = value.X; A = value.Y; R = value.Z; G = value.W; }
		}
		public Vec4 Barb
		{
			get { return new Vec4(B, A, R, B); }
			set { B = value.X; A = value.Y; R = value.Z; B = value.W; }
		}
		public Vec4 Bara
		{
			get { return new Vec4(B, A, R, A); }
			set { B = value.X; A = value.Y; R = value.Z; A = value.W; }
		}
		public Vec4 Bagr
		{
			get { return new Vec4(B, A, G, R); }
			set { B = value.X; A = value.Y; G = value.Z; R = value.W; }
		}
		public Vec4 Bagg
		{
			get { return new Vec4(B, A, G, G); }
			set { B = value.X; A = value.Y; G = value.Z; G = value.W; }
		}
		public Vec4 Bagb
		{
			get { return new Vec4(B, A, G, B); }
			set { B = value.X; A = value.Y; G = value.Z; B = value.W; }
		}
		public Vec4 Baga
		{
			get { return new Vec4(B, A, G, A); }
			set { B = value.X; A = value.Y; G = value.Z; A = value.W; }
		}
		public Vec4 Babr
		{
			get { return new Vec4(B, A, B, R); }
			set { B = value.X; A = value.Y; B = value.Z; R = value.W; }
		}
		public Vec4 Babg
		{
			get { return new Vec4(B, A, B, G); }
			set { B = value.X; A = value.Y; B = value.Z; G = value.W; }
		}
		public Vec4 Babb
		{
			get { return new Vec4(B, A, B, B); }
			set { B = value.X; A = value.Y; B = value.Z; B = value.W; }
		}
		public Vec4 Baba
		{
			get { return new Vec4(B, A, B, A); }
			set { B = value.X; A = value.Y; B = value.Z; A = value.W; }
		}
		public Vec4 Baar
		{
			get { return new Vec4(B, A, A, R); }
			set { B = value.X; A = value.Y; A = value.Z; R = value.W; }
		}
		public Vec4 Baag
		{
			get { return new Vec4(B, A, A, G); }
			set { B = value.X; A = value.Y; A = value.Z; G = value.W; }
		}
		public Vec4 Baab
		{
			get { return new Vec4(B, A, A, B); }
			set { B = value.X; A = value.Y; A = value.Z; B = value.W; }
		}
		public Vec4 Baaa
		{
			get { return new Vec4(B, A, A, A); }
			set { B = value.X; A = value.Y; A = value.Z; A = value.W; }
		}
		public Vec4 Arrr
		{
			get { return new Vec4(A, R, R, R); }
			set { A = value.X; R = value.Y; R = value.Z; R = value.W; }
		}
		public Vec4 Arrg
		{
			get { return new Vec4(A, R, R, G); }
			set { A = value.X; R = value.Y; R = value.Z; G = value.W; }
		}
		public Vec4 Arrb
		{
			get { return new Vec4(A, R, R, B); }
			set { A = value.X; R = value.Y; R = value.Z; B = value.W; }
		}
		public Vec4 Arra
		{
			get { return new Vec4(A, R, R, A); }
			set { A = value.X; R = value.Y; R = value.Z; A = value.W; }
		}
		public Vec4 Argr
		{
			get { return new Vec4(A, R, G, R); }
			set { A = value.X; R = value.Y; G = value.Z; R = value.W; }
		}
		public Vec4 Argg
		{
			get { return new Vec4(A, R, G, G); }
			set { A = value.X; R = value.Y; G = value.Z; G = value.W; }
		}
		public Vec4 Argb
		{
			get { return new Vec4(A, R, G, B); }
			set { A = value.X; R = value.Y; G = value.Z; B = value.W; }
		}
		public Vec4 Arga
		{
			get { return new Vec4(A, R, G, A); }
			set { A = value.X; R = value.Y; G = value.Z; A = value.W; }
		}
		public Vec4 Arbr
		{
			get { return new Vec4(A, R, B, R); }
			set { A = value.X; R = value.Y; B = value.Z; R = value.W; }
		}
		public Vec4 Arbg
		{
			get { return new Vec4(A, R, B, G); }
			set { A = value.X; R = value.Y; B = value.Z; G = value.W; }
		}
		public Vec4 Arbb
		{
			get { return new Vec4(A, R, B, B); }
			set { A = value.X; R = value.Y; B = value.Z; B = value.W; }
		}
		public Vec4 Arba
		{
			get { return new Vec4(A, R, B, A); }
			set { A = value.X; R = value.Y; B = value.Z; A = value.W; }
		}
		public Vec4 Arar
		{
			get { return new Vec4(A, R, A, R); }
			set { A = value.X; R = value.Y; A = value.Z; R = value.W; }
		}
		public Vec4 Arag
		{
			get { return new Vec4(A, R, A, G); }
			set { A = value.X; R = value.Y; A = value.Z; G = value.W; }
		}
		public Vec4 Arab
		{
			get { return new Vec4(A, R, A, B); }
			set { A = value.X; R = value.Y; A = value.Z; B = value.W; }
		}
		public Vec4 Araa
		{
			get { return new Vec4(A, R, A, A); }
			set { A = value.X; R = value.Y; A = value.Z; A = value.W; }
		}
		public Vec4 Agrr
		{
			get { return new Vec4(A, G, R, R); }
			set { A = value.X; G = value.Y; R = value.Z; R = value.W; }
		}
		public Vec4 Agrg
		{
			get { return new Vec4(A, G, R, G); }
			set { A = value.X; G = value.Y; R = value.Z; G = value.W; }
		}
		public Vec4 Agrb
		{
			get { return new Vec4(A, G, R, B); }
			set { A = value.X; G = value.Y; R = value.Z; B = value.W; }
		}
		public Vec4 Agra
		{
			get { return new Vec4(A, G, R, A); }
			set { A = value.X; G = value.Y; R = value.Z; A = value.W; }
		}
		public Vec4 Aggr
		{
			get { return new Vec4(A, G, G, R); }
			set { A = value.X; G = value.Y; G = value.Z; R = value.W; }
		}
		public Vec4 Aggg
		{
			get { return new Vec4(A, G, G, G); }
			set { A = value.X; G = value.Y; G = value.Z; G = value.W; }
		}
		public Vec4 Aggb
		{
			get { return new Vec4(A, G, G, B); }
			set { A = value.X; G = value.Y; G = value.Z; B = value.W; }
		}
		public Vec4 Agga
		{
			get { return new Vec4(A, G, G, A); }
			set { A = value.X; G = value.Y; G = value.Z; A = value.W; }
		}
		public Vec4 Agbr
		{
			get { return new Vec4(A, G, B, R); }
			set { A = value.X; G = value.Y; B = value.Z; R = value.W; }
		}
		public Vec4 Agbg
		{
			get { return new Vec4(A, G, B, G); }
			set { A = value.X; G = value.Y; B = value.Z; G = value.W; }
		}
		public Vec4 Agbb
		{
			get { return new Vec4(A, G, B, B); }
			set { A = value.X; G = value.Y; B = value.Z; B = value.W; }
		}
		public Vec4 Agba
		{
			get { return new Vec4(A, G, B, A); }
			set { A = value.X; G = value.Y; B = value.Z; A = value.W; }
		}
		public Vec4 Agar
		{
			get { return new Vec4(A, G, A, R); }
			set { A = value.X; G = value.Y; A = value.Z; R = value.W; }
		}
		public Vec4 Agag
		{
			get { return new Vec4(A, G, A, G); }
			set { A = value.X; G = value.Y; A = value.Z; G = value.W; }
		}
		public Vec4 Agab
		{
			get { return new Vec4(A, G, A, B); }
			set { A = value.X; G = value.Y; A = value.Z; B = value.W; }
		}
		public Vec4 Agaa
		{
			get { return new Vec4(A, G, A, A); }
			set { A = value.X; G = value.Y; A = value.Z; A = value.W; }
		}
		public Vec4 Abrr
		{
			get { return new Vec4(A, B, R, R); }
			set { A = value.X; B = value.Y; R = value.Z; R = value.W; }
		}
		public Vec4 Abrg
		{
			get { return new Vec4(A, B, R, G); }
			set { A = value.X; B = value.Y; R = value.Z; G = value.W; }
		}
		public Vec4 Abrb
		{
			get { return new Vec4(A, B, R, B); }
			set { A = value.X; B = value.Y; R = value.Z; B = value.W; }
		}
		public Vec4 Abra
		{
			get { return new Vec4(A, B, R, A); }
			set { A = value.X; B = value.Y; R = value.Z; A = value.W; }
		}
		public Vec4 Abgr
		{
			get { return new Vec4(A, B, G, R); }
			set { A = value.X; B = value.Y; G = value.Z; R = value.W; }
		}
		public Vec4 Abgg
		{
			get { return new Vec4(A, B, G, G); }
			set { A = value.X; B = value.Y; G = value.Z; G = value.W; }
		}
		public Vec4 Abgb
		{
			get { return new Vec4(A, B, G, B); }
			set { A = value.X; B = value.Y; G = value.Z; B = value.W; }
		}
		public Vec4 Abga
		{
			get { return new Vec4(A, B, G, A); }
			set { A = value.X; B = value.Y; G = value.Z; A = value.W; }
		}
		public Vec4 Abbr
		{
			get { return new Vec4(A, B, B, R); }
			set { A = value.X; B = value.Y; B = value.Z; R = value.W; }
		}
		public Vec4 Abbg
		{
			get { return new Vec4(A, B, B, G); }
			set { A = value.X; B = value.Y; B = value.Z; G = value.W; }
		}
		public Vec4 Abbb
		{
			get { return new Vec4(A, B, B, B); }
			set { A = value.X; B = value.Y; B = value.Z; B = value.W; }
		}
		public Vec4 Abba
		{
			get { return new Vec4(A, B, B, A); }
			set { A = value.X; B = value.Y; B = value.Z; A = value.W; }
		}
		public Vec4 Abar
		{
			get { return new Vec4(A, B, A, R); }
			set { A = value.X; B = value.Y; A = value.Z; R = value.W; }
		}
		public Vec4 Abag
		{
			get { return new Vec4(A, B, A, G); }
			set { A = value.X; B = value.Y; A = value.Z; G = value.W; }
		}
		public Vec4 Abab
		{
			get { return new Vec4(A, B, A, B); }
			set { A = value.X; B = value.Y; A = value.Z; B = value.W; }
		}
		public Vec4 Abaa
		{
			get { return new Vec4(A, B, A, A); }
			set { A = value.X; B = value.Y; A = value.Z; A = value.W; }
		}
		public Vec4 Aarr
		{
			get { return new Vec4(A, A, R, R); }
			set { A = value.X; A = value.Y; R = value.Z; R = value.W; }
		}
		public Vec4 Aarg
		{
			get { return new Vec4(A, A, R, G); }
			set { A = value.X; A = value.Y; R = value.Z; G = value.W; }
		}
		public Vec4 Aarb
		{
			get { return new Vec4(A, A, R, B); }
			set { A = value.X; A = value.Y; R = value.Z; B = value.W; }
		}
		public Vec4 Aara
		{
			get { return new Vec4(A, A, R, A); }
			set { A = value.X; A = value.Y; R = value.Z; A = value.W; }
		}
		public Vec4 Aagr
		{
			get { return new Vec4(A, A, G, R); }
			set { A = value.X; A = value.Y; G = value.Z; R = value.W; }
		}
		public Vec4 Aagg
		{
			get { return new Vec4(A, A, G, G); }
			set { A = value.X; A = value.Y; G = value.Z; G = value.W; }
		}
		public Vec4 Aagb
		{
			get { return new Vec4(A, A, G, B); }
			set { A = value.X; A = value.Y; G = value.Z; B = value.W; }
		}
		public Vec4 Aaga
		{
			get { return new Vec4(A, A, G, A); }
			set { A = value.X; A = value.Y; G = value.Z; A = value.W; }
		}
		public Vec4 Aabr
		{
			get { return new Vec4(A, A, B, R); }
			set { A = value.X; A = value.Y; B = value.Z; R = value.W; }
		}
		public Vec4 Aabg
		{
			get { return new Vec4(A, A, B, G); }
			set { A = value.X; A = value.Y; B = value.Z; G = value.W; }
		}
		public Vec4 Aabb
		{
			get { return new Vec4(A, A, B, B); }
			set { A = value.X; A = value.Y; B = value.Z; B = value.W; }
		}
		public Vec4 Aaba
		{
			get { return new Vec4(A, A, B, A); }
			set { A = value.X; A = value.Y; B = value.Z; A = value.W; }
		}
		public Vec4 Aaar
		{
			get { return new Vec4(A, A, A, R); }
			set { A = value.X; A = value.Y; A = value.Z; R = value.W; }
		}
		public Vec4 Aaag
		{
			get { return new Vec4(A, A, A, G); }
			set { A = value.X; A = value.Y; A = value.Z; G = value.W; }
		}
		public Vec4 Aaab
		{
			get { return new Vec4(A, A, A, B); }
			set { A = value.X; A = value.Y; A = value.Z; B = value.W; }
		}
		public Vec4 Aaaa
		{
			get { return new Vec4(A, A, A, A); }
			set { A = value.X; A = value.Y; A = value.Z; A = value.W; }
		}
		#endregion
		#endregion

		#region Operators
		public static Vec4 operator +(Vec4 lhs, Vec4 rhs)
		{
			return new Vec4(lhs.X + rhs.X, lhs.Y + rhs.Y, lhs.Z + rhs.Z, lhs.W + rhs.W);
		}
		public static Vec4 operator -(Vec4 lhs, Vec4 rhs)
		{
			return new Vec4(lhs.X - rhs.X, lhs.Y - rhs.Y, lhs.Z - rhs.Z, lhs.W - rhs.W);
		}
		public static Vec4 operator *(Vec4 lhs, Vec4 rhs)
		{
			return new Vec4(lhs.X * rhs.X, lhs.Y * rhs.Y, lhs.Z * rhs.Z, lhs.W * rhs.W);
		}
		public static Vec4 operator /(Vec4 lhs, Vec4 rhs)
		{
			return new Vec4(lhs.X / rhs.X, lhs.Y / rhs.Y, lhs.Z / rhs.Z, lhs.W / rhs.W);
		}

		public static Vec4 operator +(Vec4 lhs, float rhs)
		{
			return new Vec4(lhs.X + rhs, lhs.Y + rhs, lhs.Z + rhs, lhs.W + rhs);
		}
		public static Vec4 operator -(Vec4 lhs, float rhs)
		{
			return new Vec4(lhs.X - rhs, lhs.Y - rhs, lhs.Z - rhs, lhs.W - rhs);
		}
		public static Vec4 operator *(Vec4 lhs, float rhs)
		{
			return new Vec4(lhs.X * rhs, lhs.Y * rhs, lhs.Z * rhs, lhs.W * rhs);
		}
		public static Vec4 operator /(Vec4 lhs, float rhs)
		{
			return new Vec4(lhs.X / rhs, lhs.Y / rhs, lhs.Z / rhs, lhs.W / rhs);
		}

		public static Vec4 operator +(float rhs, Vec4 lhs)
		{
			return new Vec4(lhs.X + rhs, lhs.Y + rhs, lhs.Z + rhs, lhs.W + rhs);
		}
		public static Vec4 operator -(float rhs, Vec4 lhs)
		{
			return new Vec4(lhs.X - rhs, lhs.Y - rhs, lhs.Z - rhs, lhs.W - rhs);
		}
		public static Vec4 operator *(float rhs, Vec4 lhs)
		{
			return new Vec4(lhs.X * rhs, lhs.Y * rhs, lhs.Z * rhs, lhs.W * rhs);
		}
		public static Vec4 operator /(float rhs, Vec4 lhs)
		{
			return new Vec4(lhs.X / rhs, lhs.Y / rhs, lhs.Z / rhs, lhs.W / rhs);
		}
		#endregion

		public static float Dot(Vec4 lhs, Vec4 rhs)
		{
			return lhs.X * rhs.X + lhs.Y * rhs.Y + lhs.Z * rhs.Z + lhs.W * rhs.W;
		}

		public float SqrMagnitude
		{
			get
			{
				return Dot(this, this);
			}
		}
		public float Magnitude
		{
			get
			{
				return (float)Math.Sqrt(SqrMagnitude);
			}
		}

		public Vec4 Normalized
		{
			get
			{
				float n = 1f / Magnitude;
				return new Vec4(X / n, Y / n, Z / n, W / n);
			}
		}

		public void Normalize()
		{
			this = Normalized;
		}
	}
}
