﻿using CppAst;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyUSDGen
{
    public static class Helpers
    {
        public static List<string> NondefineStructs = new();

        private static readonly Dictionary<string, string> s_csNameMappings = new Dictionary<string, string>()
        {
            { "uint8_t", "byte" },
            { "c_tinyusd_half_t", "ushort" },
            { "uint16_t", "ushort" },
            { "uint32_t", "uint" },
            { "uint64_t", "ulong" },
            { "int8_t", "sbyte" },
            { "int32_t", "int" },
            { "int16_t", "short" },
            { "int64_t", "long" },
            { "int64_t*", "long*" },
            { "char", "byte" },
            { "size_t", "UIntPtr" },
            { "DWORD", "uint" },
        };

        public static string ConvertToCSharpType(CppType type, bool isPointer = false)
        {
            if (type is CppPrimitiveType primitiveType)
            {
                return GetCsTypeName(primitiveType, isPointer);
            }

            if (type is CppQualifiedType qualifiedType)
            {
                return GetCsTypeName(qualifiedType.ElementType, isPointer);
            }

            if (type is CppEnum enumType)
            {
                var enumCsName = enumType.Name;
                if (isPointer)
                    return enumCsName + "*";

                return enumCsName;
            }

            if (type is CppTypedef typedef)
            {
                var originalName = typedef.Name;
                s_csNameMappings.TryGetValue(originalName, out string typeDefCsName);
                if (isPointer)
                    return typeDefCsName + "*";

                return typeDefCsName;
            }

            if (type is CppClass @class)
            {
                var className = @class.Name;
                if (isPointer)
                    return className + "*";

                return className;
            }

            if (type is CppPointerType pointerType)
            {
                return GetCsTypeName(pointerType);
            }

            if (type is CppArrayType arrayType)
            {
                return GetCsTypeName(arrayType.ElementType, isPointer);
            }

            return string.Empty;
        }

        private static string GetCsTypeName(CppPointerType pointerType)
        {
            if (pointerType.ElementType is CppQualifiedType qualifiedType)
            {
                if (qualifiedType.ElementType is CppPrimitiveType primitiveType)
                {
                    return GetCsTypeName(primitiveType, true);
                }
                else if (qualifiedType.ElementType is CppClass @classType)
                {
                    return GetCsTypeName(@classType, true);
                }
                else if (qualifiedType.ElementType is CppPointerType subPointerType)
                {
                    return GetCsTypeName(subPointerType, true) + "*";
                }
                else if (qualifiedType.ElementType is CppTypedef typedef)
                {
                    return GetCsTypeName(typedef, true);
                }
                else if (qualifiedType.ElementType is CppEnum @enum)
                {
                    return GetCsTypeName(@enum, true);
                }

                return GetCsTypeName(qualifiedType.ElementType, true);
            }

            return GetCsTypeName(pointerType.ElementType, true);
        }

        private static string GetCsTypeName(CppType type, bool isPointer = false)
        {
            if (type is CppPrimitiveType primitiveType)
            {
                return GetCsTypeName(primitiveType, isPointer);
            }

            if (type is CppQualifiedType qualifiedType)
            {
                return GetCsTypeName(qualifiedType.ElementType, isPointer);
            }

            if (type is CppEnum enumType)
            {
                var enumCsName = enumType.Name;
                if (isPointer)
                    return enumCsName + "*";

                return enumCsName;
            }

            if (type is CppTypedef typedef)
            {
                var originalName = typedef.Name;
                s_csNameMappings.TryGetValue(originalName, out string typeDefCsName);
                if (isPointer)
                    return typeDefCsName + "*";

                return typeDefCsName;
            }

            if (type is CppClass @class)
            {
                var className = @class.Name;

                if (isPointer)
                    className += "*";

                if (NondefineStructs.Contains(@class.Name))
                {
                    className = "IntPtr";
                }

                return className;
            }

            if (type is CppPointerType pointerType)
            {
                return GetCsTypeName(pointerType);
            }

            if (type is CppArrayType arrayType)
            {
                return GetCsTypeName(arrayType.ElementType, isPointer);
            }

            return string.Empty;
        }

        private static string GetCsTypeName(CppPrimitiveType primitiveType, bool isPointer)
        {
            string result = string.Empty;

            switch (primitiveType.Kind)
            {
                case CppPrimitiveKind.Void:
                    result = "void";
                    break;
                case CppPrimitiveKind.Bool:
                    result = "bool";
                    break;
                case CppPrimitiveKind.Char:
                    result = "char";
                    break;
                case CppPrimitiveKind.Short:
                    result = "short";
                    break;
                case CppPrimitiveKind.Int:
                    result = "int";
                    break;
                case CppPrimitiveKind.UnsignedShort:
                    result = "ushort";
                    break;
                case CppPrimitiveKind.UnsignedInt:
                    result = "uint";
                    break;
                case CppPrimitiveKind.Float:
                    result = "float";
                    break;
                case CppPrimitiveKind.Double:
                    result = "double";
                    break;
                case CppPrimitiveKind.UnsignedChar:
                case CppPrimitiveKind.LongLong:
                case CppPrimitiveKind.UnsignedLongLong:
                case CppPrimitiveKind.LongDouble:
                case CppPrimitiveKind.WChar:
                default:
                    break;
            }

            if (isPointer)
            {
                result += "*";
            }

            return result;
        }

        public enum Family
        {
            param,
            field,
            ret,
        }

        public static string ShowAsMarshalType(string type, Family family)
        {
            switch (type)
            {
                case "bool":
                    switch (family)
                    {
                        case Family.param:
                            return "[MarshalAs(UnmanagedType.Bool)] bool";
                        case Family.ret:
                            return "bool";
                        case Family.field:
                        default:
                            return "byte";
                    }
                case "bool*":
                    switch (family)
                    {
                        case Family.ret:
                            return "bool";
                        case Family.param:
                        case Family.field:
                        default:
                            return "byte*";
                    }
                case "char*":
                case "unsigned char*":
                    switch (family)
                    {
                        case Family.param:
                            return "[MarshalAs(UnmanagedType.LPStr)] string";
                        case Family.ret:
                            return "string";
                        case Family.field:
                        default:
                            return "byte*";
                    }
                default:
                    return type;
            }
        }

        public static void PrintComments(StreamWriter file, CppComment comment, string tabs = "", bool newLine = false)
        {
            if (comment != null)
            {
                if (newLine) file.WriteLine();

                file.WriteLine($"{tabs}/// <summary>");
                GetText(file, comment, tabs);
                file.WriteLine($"{tabs}/// </summary>");
            }
        }

        private static void GetText(StreamWriter file, CppComment comment, string tabs)
        {
            switch (comment.Kind)
            {
                case CppCommentKind.Text:
                    var commentText = comment as CppCommentTextBase;
                    file.WriteLine($"{tabs}/// {commentText.Text}");
                    break;
                case CppCommentKind.Paragraph:
                case CppCommentKind.Full:
                    foreach (var child in comment.Children)
                    {
                        GetText(file, child, tabs);
                    }
                    break;
                default:
                    ;
                    break;
            }
        }
    }
}
