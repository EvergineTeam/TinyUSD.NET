using System;
using System.Runtime.InteropServices;

namespace Evergine.Bindings.TinyUSD
{
	/// <summary>
	/// Assume struct elements will be tightly packed in C11.
	/// TODO: Ensure struct elements are tightly packed.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct c_tinyusd_int2_t
	{
		public int x;
		public int y;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct c_tinyusd_int3_t
	{
		public int x;
		public int y;
		public int z;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct c_tinyusd_int4_t
	{
		public int x;
		public int y;
		public int z;
		public int w;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct c_tinyusd_uint2_t
	{
		public uint x;
		public uint y;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct c_tinyusd_uint3_t
	{
		public uint x;
		public uint y;
		public uint z;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct c_tinyusd_uint4_t
	{
		public uint x;
		public uint y;
		public uint z;
		public uint w;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct c_tinyusd_half2_t
	{
		public ushort x;
		public ushort y;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct c_tinyusd_half3_t
	{
		public ushort x;
		public ushort y;
		public ushort z;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct c_tinyusd_half4_t
	{
		public ushort x;
		public ushort y;
		public ushort z;
		public ushort w;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct c_tinyusd_float2_t
	{
		public float x;
		public float y;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct c_tinyusd_float3_t
	{
		public float x;
		public float y;
		public float z;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct c_tinyusd_float4_t
	{
		public float x;
		public float y;
		public float z;
		public float w;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct c_tinyusd_double2_t
	{
		public double x;
		public double y;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct c_tinyusd_double3_t
	{
		public double x;
		public double y;
		public double z;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct c_tinyusd_double4_t
	{
		public double x;
		public double y;
		public double z;
		public double w;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct c_tinyusd_matrix2d_t
	{
		public double m0;
		public double m1;
		public double m2;
		public double m3;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct c_tinyusd_matrix3d_t
	{
		public double m0;
		public double m1;
		public double m2;
		public double m3;
		public double m4;
		public double m5;
		public double m6;
		public double m7;
		public double m8;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct c_tinyusd_matrix4d_t
	{
		public double m0;
		public double m1;
		public double m2;
		public double m3;
		public double m4;
		public double m5;
		public double m6;
		public double m7;
		public double m8;
		public double m9;
		public double m10;
		public double m11;
		public double m12;
		public double m13;
		public double m14;
		public double m15;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct c_tinyusd_quath_t
	{
		public ushort imag0;
		public ushort imag1;
		public ushort imag2;
		public ushort real;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct c_tinyusd_quatf_t
	{
		public float imag0;
		public float imag1;
		public float imag2;
		public float real;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct c_tinyusd_quatd_t
	{
		public double imag0;
		public double imag1;
		public double imag2;
		public double real;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct c_tinyusd_string_vector
	{

		/// <summary>
		/// opaque pointer to `std::vector
		/// <std
		/// ::string>`.
		/// </summary>
		public void* data;
	}

}

