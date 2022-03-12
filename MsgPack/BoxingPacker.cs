using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MsgPack2
{
	public static class BoxingPacker
	{
		private static readonly Type KeyValuePairDefinitionType;

		static BoxingPacker()
		{
			KeyValuePairDefinitionType = typeof(KeyValuePair<object, object>).GetGenericTypeDefinition();
		}

		private static void Pack(Stream strm, object o)
		{
			var writer = new MsgPackWriter(strm);
			Pack(writer, o);
		}

		public static byte[] Pack(object o)
        {
            using var memoryStream = new MemoryStream();
            Pack(memoryStream, o);
            return memoryStream.ToArray();
        }

		private static void Pack(MsgPackWriter writer, object o)
		{
			switch (o)
            {
                case null:
                    writer.WriteNil();
                    return;
                case string s:
                    writer.Write(Encoding.UTF8.GetBytes(s));
                    return;
            }

            var type = o.GetType();
			if (type.IsPrimitive)
			{
				if (type == typeof(int))
				{
					writer.Write((int)o);
					return;
				}
				if (type == typeof(uint))
				{
					writer.Write((uint)o);
					return;
				}
				if (type == typeof(float))
				{
					writer.Write((float)o);
					return;
				}
				if (type == typeof(double))
				{
					writer.Write((double)o);
					return;
				}
				if (type == typeof(long))
				{
					writer.Write((long)o);
					return;
				}
				if (type == typeof(ulong))
				{
					writer.Write((ulong)o);
					return;
				}
				if (type == typeof(bool))
				{
					writer.Write((bool)o);
					return;
				}
				if (type == typeof(byte))
				{
					writer.Write((byte)o);
					return;
				}
				if (type == typeof(sbyte))
				{
					writer.Write((sbyte)o);
					return;
				}
				if (type == typeof(short))
				{
					writer.Write((short)o);
					return;
				}
				if (type == typeof(ushort))
				{
					writer.Write((ushort)o);
					return;
				}
				throw new NotSupportedException();
			}

            if (o is IDictionary dictionary)
			{
				writer.WriteMapHeader(dictionary.Count);
				foreach (DictionaryEntry item in dictionary)
				{
					Pack(writer, item.Key);
					Pack(writer, item.Value);
				}
			}
			else
			{
				if (!type.IsArray)
				{
					return;
				}
				var array = (Array)o;
				var elementType = type.GetElementType() ?? throw new InvalidOperationException();
				if (elementType.IsGenericType && elementType.GetGenericTypeDefinition() == KeyValuePairDefinitionType)
				{
					var property = elementType.GetProperty("Key") ?? throw new InvalidOperationException();
					var property2 = elementType.GetProperty("Value") ?? throw new InvalidOperationException();
					writer.WriteMapHeader(array.Length);
					for (var i = 0; i < array.Length; i++)
					{
						var value = array.GetValue(i);
						Pack(writer, property.GetValue(value, null));
						Pack(writer, property2.GetValue(value, null));
					}
				}
				else
				{
					writer.WriteArrayHeader(array.Length);
					for (var j = 0; j < array.Length; j++)
					{
						Pack(writer, array.GetValue(j));
					}
				}
			}
		}

		private static object Unpack(Stream strm)
		{
			var reader = new MsgPackReader(strm);
			var obj = Unpack(reader);
			return obj;
		}

        private static object Unpack(byte[] buf, int offset, int size)
        {
            using var strm = new MemoryStream(buf, offset, size);
            return Unpack(strm);
        }

		public static object Unpack(byte[] buf)
		{
			return Unpack(buf, 0, buf.Length);
		}

		private static object Unpack(MsgPackReader reader)
		{
			if (!reader.Read())
			{
				throw new FormatException();
			}
			switch (reader.Type)
			{
			case TypePrefixes.PositiveFixNum:
			case TypePrefixes.Int8:
			case TypePrefixes.Int16:
			case TypePrefixes.Int32:
			case TypePrefixes.NegativeFixNum:
				return reader.ValueSigned;
			case TypePrefixes.Int64:
				return reader.ValueSigned64;
			case TypePrefixes.UInt8:
			case TypePrefixes.UInt16:
			case TypePrefixes.UInt32:
				return reader.ValueUnsigned;
			case TypePrefixes.UInt64:
				return reader.ValueUnsigned64;
			case TypePrefixes.True:
				return true;
			case TypePrefixes.False:
				return false;
			case TypePrefixes.Float:
				return reader.ValueFloat;
			case TypePrefixes.Double:
				return reader.ValueDouble;
			case TypePrefixes.Nil:
				return null;
			case TypePrefixes.FixRaw:
				case TypePrefixes.Raw8:
			case TypePrefixes.Raw16:
			case TypePrefixes.Raw32:
			{
				var array2 = new byte[reader.Length];
				reader.ReadValueRaw(array2, 0, array2.Length);
				return array2;
			}
			case TypePrefixes.FixArray:
			case TypePrefixes.Array16:
			case TypePrefixes.Array32:
			{
				var array = new object[reader.Length];
                if (reader.Length == 0) return null;
				for (var j = 0; j < array.Length; j++)
				{
					array[j] = Unpack(reader);
				}
				return array;
			}
			case TypePrefixes.FixMap:
			case TypePrefixes.Map16:
			case TypePrefixes.Map32:
			{
				IDictionary<object, object> dictionary = new Dictionary<object, object>((int)reader.Length);
				var length = (int)reader.Length;
				for (var i = 0; i < length; i++)
				{
					var key = Unpack(reader) ?? "null";
					var value = Unpack(reader);

							if (key is byte[] ba) key = Encoding.UTF8.GetString(ba);
					if (value is byte[] ba2) value = Encoding.UTF8.GetString(ba2);

					dictionary.Add(key, value);
				}
				return dictionary;
			}
			default:
				throw new FormatException();
			}
		}
	}
}
