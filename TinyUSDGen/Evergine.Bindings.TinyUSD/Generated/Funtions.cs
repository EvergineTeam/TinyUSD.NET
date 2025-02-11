using System;
using System.Runtime.InteropServices;

namespace Evergine.Bindings.TinyUSD
{
	public static unsafe partial class TinyUSDNative
	{
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern void* c_tinyusd_malloc(UIntPtr nbytes);

		/// <summary>
		/// Returns 0 when failed. 
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_free(void* ptr);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr c_tinyusd_token_new([MarshalAs(UnmanagedType.LPStr)] string str);

		/// <summary>
		/// Duplicate token object. Return null when failed. 
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr c_tinyusd_token_dup(IntPtr tok);

		/// <summary>
		/// Length of token string. equivalent to std::string::size. 
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern UIntPtr c_tinyusd_token_size(IntPtr tok);

		/// <summary>
		/// Get C char from a token.
		/// Returned char pointer is valid until `c_tinyusd_token` instance is free'ed.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern string c_tinyusd_token_str(IntPtr tok);

		/// <summary>
		/// Free token
		/// Return 0 when failed to free.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_token_free(IntPtr tok);

		/// <summary>
		/// New token vector(array) with size zero(empty) 
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr c_tinyusd_token_vector_new_empty();

		/// <summary>
		/// New token vector(array) with given size `n` 
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr c_tinyusd_token_vector_new(UIntPtr n, [MarshalAs(UnmanagedType.LPStr)] string toks);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_token_vector_free(IntPtr sv);

		/// <summary>
		/// Returns number of elements.
		/// 0 when empty or `tv` is invalid.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern UIntPtr c_tinyusd_token_vector_size(IntPtr sv);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_token_vector_clear(IntPtr sv);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_token_vector_resize(IntPtr sv, UIntPtr n);

		/// <summary>
		/// Return const string pointer for given index.
		/// Returns nullptr when index is out-of-range.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern string c_tinyusd_token_vector_str(IntPtr sv, UIntPtr idx);

		/// <summary>
		/// Replace `index`th token.
		/// Returns 0 when `sv` is invalid or `index` is out-of-range.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_token_vector_replace(IntPtr sv, UIntPtr idx, [MarshalAs(UnmanagedType.LPStr)] string str);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr c_tinyusd_string_new_empty();

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr c_tinyusd_string_new([MarshalAs(UnmanagedType.LPStr)] string str);

		/// <summary>
		/// Length of string. equivalent to std::string::size. 
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern UIntPtr c_tinyusd_string_size(IntPtr s);

		/// <summary>
		/// Replace existing string with given `str`.
		/// `c_tinyusd_string` object must be new'ed beforehand.
		/// Return 0 when failed to set.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_string_replace(IntPtr s, [MarshalAs(UnmanagedType.LPStr)] string str);

		/// <summary>
		/// Get C char(`std::string::c_str()`)
		/// Returned char pointer is valid until `c_tinyusd_string` instance is free'ed.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern string c_tinyusd_string_str(IntPtr s);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_string_free(IntPtr s);

		/// <summary>
		/// New string vector(array) with given size `n` 
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_string_vector_new_empty(c_tinyusd_string_vector* sv, UIntPtr n);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_string_vector_new(c_tinyusd_string_vector* sv, UIntPtr n, [MarshalAs(UnmanagedType.LPStr)] string strs);

		/// <summary>
		/// Returns number of elements.
		/// 0 when empty or `sv` is invalid.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern UIntPtr c_tinyusd_string_vector_size(c_tinyusd_string_vector* sv);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_string_vector_clear(c_tinyusd_string_vector* sv);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_string_vector_resize(c_tinyusd_string_vector* sv, UIntPtr n);

		/// <summary>
		/// Return const string pointer for given index.
		/// Returns nullptr when index is out-of-range.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern string c_tinyusd_string_vector_str(c_tinyusd_string_vector* sv, UIntPtr idx);

		/// <summary>
		/// Replace `index`th string.
		/// Returns 0 when `sv` is invalid or `index` is out-of-range.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_string_vector_replace(c_tinyusd_string_vector* sv, UIntPtr idx, [MarshalAs(UnmanagedType.LPStr)] string str);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_string_vector_free(c_tinyusd_string_vector* sv);

		/// <summary>
		/// Return the name of Prim type(e.g. "Xform", "Mesh", ...).
		/// Return NULL for unsupported/unknown Prim type.
		/// Returned char pointer is valid until Prim is modified or deleted.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern string c_tinyusd_prim_type_name(CTinyUSDPrimType prim_type);

		/// <summary>
		/// Return Builtin PrimType from a string.
		/// Returns C_TINYUSD_PRIM_UNKNOWN for invalid or unknown/unsupported Prim type
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern CTinyUSDPrimType c_tinyusd_prim_type_from_string([MarshalAs(UnmanagedType.LPStr)] string prim_type);

		/// <summary>
		/// Returns name of ValueType.
		/// The pointer points to static Thread-local storage(so thread-safe), thus no
		/// need to free it.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern string c_tinyusd_value_type_name(CTinyUSDValueType value_type);

		/// <summary>
		/// Return 1: Value type is numeric type(float3, int, ...). 0 otherwise(e.g. token, dictionary, ...)
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint c_tinyusd_value_type_is_numeric(CTinyUSDValueType value_type);

		/// <summary>
		/// Returns sizeof(value_type);
		/// For non-numeric value type(e.g. STRING, TOKEN) and invalid enum value, it
		/// returns 0. NOTE: Returns 1 for bool type.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint c_tinyusd_value_type_sizeof(CTinyUSDValueType value_type);

		/// <summary>
		/// Returns the number of components of given value_type;
		/// For example, 3 for C_TINYUSD_VALUE_POINT3F.
		/// For non-numeric value type(e.g. STRING, TOKEN), it returns 0.
		/// For scalar type, it returns 1.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint c_tinyusd_value_type_components(CTinyUSDValueType value_type);

		/// <summary>
		/// Return value type enum.
		/// Returns C_TINYUSD_VALUE_UNKNOWN when `value` is nullptr or invalid.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern CTinyUSDValueType c_tinyusd_value_type(IntPtr value);

		/// <summary>
		/// New Value with null(empty) value.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr c_tinyusd_value_new_null();

		/// <summary>
		/// Free Value.
		/// Internally calls `c_tinyusd_buffer_free` to free buffer associated with this
		/// Value.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_value_free(IntPtr val);

		/// <summary>
		/// Get string representation of Value content(pprint).
		/// Return 0 upon error.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_value_to_string(IntPtr val, IntPtr str);

		/// <summary>
		/// Free Value.
		/// Internally calls `c_tinyusd_buffer_free` to free buffer associated with this
		/// Value.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_value_free(IntPtr val);

		/// <summary>
		/// New Value with token type.
		/// NOTE: token data are copied. So it is safe to free token after calling this
		/// function.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr c_tinyusd_value_new_token(IntPtr val);

		/// <summary>
		/// New Value with string type.
		/// NOTE: string data are copied. So it is safe to free string after calling this
		/// function.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr c_tinyusd_value_new_string(IntPtr val);

		/// <summary>
		/// New Value with specific type.
		/// NOTE: Datas are copied.
		/// Returns 1 upon success, 0 failed.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr c_tinyusd_value_new_int(int val);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr c_tinyusd_value_new_int2(c_tinyusd_int2_t val);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr c_tinyusd_value_new_int3(c_tinyusd_int3_t val);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr c_tinyusd_value_new_int4(c_tinyusd_int4_t val);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr c_tinyusd_value_new_float(float val);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr c_tinyusd_value_new_float2(c_tinyusd_float2_t val);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr c_tinyusd_value_new_float3(c_tinyusd_float3_t val);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr c_tinyusd_value_new_float4(c_tinyusd_float4_t val);

		/// <summary>
		/// Check if the content of Value is the type of `value_type` 
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_value_is_type(IntPtr value, CTinyUSDValueType value_type);

		/// <summary>
		/// Get the actual value in CTinyUSDValue by specifying the type.
		/// NOTE: Datas are copied.
		/// Returns 1 upon success, 0 failed(e.g. Value is invalid, type mismatch).
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_value_as_int(IntPtr value, int* val);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_value_as_int2(IntPtr value, c_tinyusd_int2_t* val);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_value_as_int3(IntPtr value, c_tinyusd_int3_t* val);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_value_as_int4(IntPtr value, c_tinyusd_int4_t* val);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_value_as_float(IntPtr value, float* val);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_value_as_float2(IntPtr value, c_tinyusd_float2_t* val);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_value_as_float3(IntPtr value, c_tinyusd_float3_t* val);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_value_as_float4(IntPtr value, c_tinyusd_float4_t* val);

		/// <summary>
		/// New Value with 1D array ofspecific type.
		/// NOTE: Array data is copied.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr c_tinyusd_value_new_array_int(ulong n, int* vals);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr c_tinyusd_value_new_array_int2(ulong n, c_tinyusd_int2_t* vals);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr c_tinyusd_value_new_array_int3(ulong n, c_tinyusd_int3_t* vals);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr c_tinyusd_value_new_array_int4(ulong n, c_tinyusd_int4_t* vals);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr c_tinyusd_value_new_array_float(ulong n, float* vals);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr c_tinyusd_value_new_array_float2(ulong n, c_tinyusd_float2_t* vals);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr c_tinyusd_value_new_array_float3(ulong n, c_tinyusd_float3_t* vals);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr c_tinyusd_value_new_array_float4(ulong n, c_tinyusd_float4_t* vals);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr c_tinyusd_relationsip_new(uint n, [MarshalAs(UnmanagedType.LPStr)] string targetPaths);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_relationsip_free(IntPtr rel);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_relationsip_is_blocked(IntPtr rel);

		/// <summary>
		/// Returns 0 = declaration only(e.g. `rel myrel`) 
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint c_tinyusd_relationsip_num_targetPaths(IntPtr rel);

		/// <summary>
		/// Get i'th targetPath
		/// Returned `targetPath` is just a reference, so no need to free it.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_relationsip_get_targetPath(IntPtr rel, uint i, IntPtr targetPath);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_attribute_connection_set(IntPtr attr, IntPtr connectionPath);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_attribute_connections_set(IntPtr attr, uint n, IntPtr connectionPaths);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_attribute_meta_set(IntPtr attr, [MarshalAs(UnmanagedType.LPStr)] string meta_name, IntPtr value);

		/// <summary>
		/// Get metadata value.
		/// Returns 0 when `attr` is nullptr.
		/// Returns -1 when requested metadata is not authored.
		/// `value` is just a pointer so no need to free it(the pointer is valid until `attr` is modified/deleted)
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_attribute_meta_get(IntPtr attr, [MarshalAs(UnmanagedType.LPStr)] string meta_name, IntPtr value);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_property_new(IntPtr prop);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_property_new_attribute(IntPtr prop, IntPtr attr);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_property_new_relationship(IntPtr prop, IntPtr rel);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_property_free(IntPtr prop);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_property_set_attribute(IntPtr prop, IntPtr attr);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_property_set_relationship(IntPtr prop, IntPtr rel);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_property_is_attribute(IntPtr prop);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_property_is_attribute_connection(IntPtr prop);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_property_is_relationship(IntPtr prop);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_property_is_custom(IntPtr prop);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_property_is_varying(IntPtr prop);

		/// <summary>
		/// Create Prim with name.
		/// Will create a builtin Prim when `prim_type` is a builtin Prim name(e.g.
		/// "Xform")
		/// Otherwise create a Model Prim(Generic Prim).
		/// Return nullptr when `prim_type` is null or `prim_type` contains invalid
		/// character (A character which cannot be used for Prim type name(e.g. '%') and
		/// fills `err` with error message.
		/// (App need to free `err` after using it.)
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr c_tinyusd_prim_new([MarshalAs(UnmanagedType.LPStr)] string prim_type, IntPtr err);

		/// <summary>
		/// Create Prim with builtin Prim type.
		/// Returns nullptr when invalid `prim_type` enum value is provided.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr c_tinyusd_prim_new_builtin(CTinyUSDPrimType prim_type);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_prim_to_string(IntPtr prim, IntPtr str);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_prim_free(IntPtr prim);

		/// <summary>
		/// Prim type as a const char pointer.
		/// Returns nullptr when `prim` is invalid 
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern string c_tinyusd_prim_type(IntPtr prim);

		/// <summary>
		/// Return the element name of Prim(e.g. "root", "pbr", "xform0").
		/// Return NULL when input `prim` is invalid.
		/// Returned char pointer is valid until Prim is modified or deleted.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern string c_tinyusd_prim_element_name(IntPtr prim);

		/// <summary>
		/// Get list of property names as token array.
		/// 
		/// 
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_prim_get_property_names(IntPtr prim, IntPtr prop_names_out);

		/// <summary>
		/// Get Prim's property. Returns 0 when property `prop_name` does not exist in
		/// the Prim. `prop` just holds pointer to corresponding C++ Property instance,
		/// so no free operation required.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_prim_property_get(IntPtr prim, [MarshalAs(UnmanagedType.LPStr)] string prop_name, IntPtr prop);

		/// <summary>
		/// Add property to the Prim.
		/// It copies the content of `prop`, so please free `prop` after this add
		/// operation. Returns 0 when the operation failed(`err` will be returned. Please
		/// free `err` after using it)
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_prim_property_add(IntPtr prim, [MarshalAs(UnmanagedType.LPStr)] string prop_name, IntPtr prop, IntPtr err);

		/// <summary>
		/// Delete a property in the Prim.
		/// Returns 0 when `prop_name` does not exist in the prim.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_prim_property_del(IntPtr prim, [MarshalAs(UnmanagedType.LPStr)] string prop_name);

		/// <summary>
		/// Set Prim metadatum.
		/// Return 0 when Value type mismatch for builtin metadata.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_prim_meta_set(IntPtr prim, [MarshalAs(UnmanagedType.LPStr)] string meta_name, IntPtr value);

		/// <summary>
		/// Get Prim metadatum.
		/// Return 0 when requested metadatum is not authord or invalid.
		/// Returned `value` is just a pointer, so no need to free it(and the pointer is valid unless `prim` is modified/deleted.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_prim_meta_get(IntPtr prim, [MarshalAs(UnmanagedType.LPStr)] string meta_name, IntPtr value);

		/// <summary>
		/// Check if requested metadatum is authored.
		/// Return 1: authored. 0 not authored.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_prim_meta_authored(IntPtr prim, [MarshalAs(UnmanagedType.LPStr)] string meta_name);

		/// <summary>
		/// Append Prim to `prim`'s children. child Prim object is *COPIED*.
		/// So need to free child Prim after the append_child operation.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_prim_append_child(IntPtr prim, IntPtr child);

		/// <summary>
		/// Append Prim to `prim`'s children. child Prim object is moved(in C++ meaning).
		/// So no need to free child Prim(and `child` pointer is invalid after calling
		/// this function. Usefull if a Prim is a large object(e.g. GeomMesh with 100M
		/// vertices)
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_prim_append_child_move(IntPtr prim, IntPtr child);

		/// <summary>
		/// Delete child at `child_index` position from a Prim.
		/// Return 0 when `child_index` is out-of-range.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_prim_del_child(IntPtr prim, ulong child_index);

		/// <summary>
		/// Return the number of child Prims in this Prim.
		/// Return 0 when `prim` is invalid or nullptr.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong c_tinyusd_prim_num_children(IntPtr prim);

		/// <summary>
		/// Get a child Prim of specified child_index.
		/// Child's conent is just a pointer, so please do not call Prim
		/// deleter(`c_tinyusd_prim_free`) to it. (Please use `c_tinyusd_prim_del_child`
		/// if you want to remove a child Prim)
		/// Also the content(pointer) is valid unless the `prim`'s children is
		/// preserved(i.e., child is not deleted/added)
		/// Return 0 when `child_index` is out-of-range.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_prim_get_child(IntPtr prim, ulong child_index, IntPtr child_prim);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr c_tinyusd_stage_new();

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_stage_to_string(IntPtr stage, IntPtr str);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_stage_free(IntPtr stage);

		/// <summary>
		/// Traverse root Prims in the Stage and invoke callback function for each Prim.
		/// 
		/// 
		/// When providing `err`, it must be created with `c_tinyusd_string_new` before
		/// calling this `c_tinyusd_stage_traverse` function, and an App must free it by
		/// calling `c_tinyusd_string_free` after using it.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_stage_traverse(IntPtr stage, CTinyUSDTraversalFunction callback_fun, IntPtr err);

		/// <summary>
		/// Detect file format of input file.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern CTinyUSDFormat c_tinyusd_detect_format([MarshalAs(UnmanagedType.LPStr)] string filename);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_is_usd_file([MarshalAs(UnmanagedType.LPStr)] string filename);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_is_usda_file([MarshalAs(UnmanagedType.LPStr)] string filename);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_is_usdc_file([MarshalAs(UnmanagedType.LPStr)] string filename);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_is_usdz_file([MarshalAs(UnmanagedType.LPStr)] string filename);

		/// <summary>
		/// wide char version. especially for Windows UTF-16 filename.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern CTinyUSDFormat c_tinyusd_detect_format_w([MarshalAs(UnmanagedType.LPStr)] string filename);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_is_usd_file_w([MarshalAs(UnmanagedType.LPStr)] string filename);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_is_usda_file_w([MarshalAs(UnmanagedType.LPStr)] string filename);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_is_usdc_file_w([MarshalAs(UnmanagedType.LPStr)] string filename);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_is_usdz_file_w([MarshalAs(UnmanagedType.LPStr)] string filename);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_is_usd_memory(byte* addr, UIntPtr nbytes);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_is_usda_memory(byte* addr, UIntPtr nbytes);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_is_usdc_memory(byte* addr, UIntPtr nbytes);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_is_usdz_memory(byte* addr, UIntPtr nbytes);

		/// <summary>
		/// Return 1 upon success. 0 when failed.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_load_usd_from_file([MarshalAs(UnmanagedType.LPStr)] string filename, IntPtr stage, IntPtr warn, IntPtr err);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_load_usda_from_file([MarshalAs(UnmanagedType.LPStr)] string filename, IntPtr stage, IntPtr warn, IntPtr err);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_load_usdc_from_file([MarshalAs(UnmanagedType.LPStr)] string filename, IntPtr stage, IntPtr warn, IntPtr err);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_load_usdz_from_file([MarshalAs(UnmanagedType.LPStr)] string filename, IntPtr stage, IntPtr warn, IntPtr err);

		/// <summary>
		/// wide char version. especially for Windows UTF-16 filename.
		/// </summary>
		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_load_usd_from_file_w([MarshalAs(UnmanagedType.LPStr)] string filename, IntPtr stage, IntPtr warn, IntPtr err);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_load_usda_from_file_w([MarshalAs(UnmanagedType.LPStr)] string filename, IntPtr stage, IntPtr warn, IntPtr err);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_load_usdc_from_file_w([MarshalAs(UnmanagedType.LPStr)] string filename, IntPtr stage, IntPtr warn, IntPtr err);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_load_usdz_from_file_w([MarshalAs(UnmanagedType.LPStr)] string filename, IntPtr stage, IntPtr warn, IntPtr err);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_load_usd_from_memory(byte* addr, UIntPtr nbytes, IntPtr warn, IntPtr err);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_load_usda_from_memory(byte* addr, UIntPtr nbytes, IntPtr warn, IntPtr err);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_load_usdc_from_memory(byte* addr, UIntPtr nbytes, IntPtr warn, IntPtr err);

		[DllImport("c-tinyusd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int c_tinyusd_load_usdz_from_memory(byte* addr, UIntPtr nbytes, IntPtr warn, IntPtr err);

	}
}
