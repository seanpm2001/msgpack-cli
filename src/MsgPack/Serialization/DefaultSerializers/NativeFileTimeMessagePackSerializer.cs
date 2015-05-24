#region -- License Terms --
//
// MessagePack for CLI
//
// Copyright (C) 2010-2014 FUJIWARA, Yusuke
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//
#endregion -- License Terms --

using System;
using System.Runtime.InteropServices.ComTypes;

namespace MsgPack.Serialization.DefaultSerializers
{
	/// <summary>
	///		<see cref="FILETIME"/> serializer using native representation.
	/// </summary>
	internal sealed class NativeFileTimeMessagePackSerializer : MessagePackSerializer<FILETIME>
	{
		public NativeFileTimeMessagePackSerializer( SerializationContext ownerContext ) : base( ownerContext ) { }

		protected internal override void PackToCore( Packer packer, FILETIME objectTree )
		{
			packer.Pack( objectTree.ToDateTime().ToBinary() );
		}

		protected internal override FILETIME UnpackFromCore( Unpacker unpacker )
		{
			return DateTime.FromBinary( unpacker.LastReadData.AsInt64() ).ToWin32FileTimeUtc();
		}
	}
}