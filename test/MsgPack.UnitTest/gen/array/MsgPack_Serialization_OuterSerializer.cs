﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.34209
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers.ArrayBased {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.6.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_OuterSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.Outer> {
        
        private MsgPack.Serialization.MessagePackSerializer<string> _serializer0;
        
        private MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.Inner> _serializer1;
        
        public MsgPack_Serialization_OuterSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<string>(schema0);
            MsgPack.Serialization.PolymorphismSchema schema1 = default(MsgPack.Serialization.PolymorphismSchema);
            schema1 = null;
            this._serializer1 = context.GetSerializer<MsgPack.Serialization.Inner>(schema1);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.Outer objectTree) {
            packer.PackArrayHeader(3);
            this._serializer0.PackTo(packer, objectTree.A);
            this._serializer1.PackTo(packer, objectTree.Inner);
            this._serializer0.PackTo(packer, objectTree.O);
        }
        
        protected internal override MsgPack.Serialization.Outer UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.Outer result = default(MsgPack.Serialization.Outer);
            result = new MsgPack.Serialization.Outer();
            if (unpacker.IsArrayHeader) {
                int unpacked = default(int);
                int itemsCount = default(int);
                itemsCount = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                string nullable = default(string);
                if ((unpacked < itemsCount)) {
                    nullable = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.Outer), "System.String A");
                }
                if (((nullable == null) 
                            == false)) {
                    result.A = nullable;
                }
                unpacked = (unpacked + 1);
                MsgPack.Serialization.Inner nullable0 = default(MsgPack.Serialization.Inner);
                if ((unpacked < itemsCount)) {
                    if ((unpacker.Read() == false)) {
                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(1);
                    }
                    if (((unpacker.IsArrayHeader == false) 
                                && (unpacker.IsMapHeader == false))) {
                        nullable0 = this._serializer1.UnpackFrom(unpacker);
                    }
                    else {
                        MsgPack.Unpacker disposable = default(MsgPack.Unpacker);
                        disposable = unpacker.ReadSubtree();
                        try {
                            nullable0 = this._serializer1.UnpackFrom(disposable);
                        }
                        finally {
                            if (((disposable == null) 
                                        == false)) {
                                disposable.Dispose();
                            }
                        }
                    }
                }
                if (((nullable0 == null) 
                            == false)) {
                    result.Inner = nullable0;
                }
                unpacked = (unpacked + 1);
                string nullable1 = default(string);
                if ((unpacked < itemsCount)) {
                    nullable1 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.Outer), "System.String O");
                }
                if (((nullable1 == null) 
                            == false)) {
                    result.O = nullable1;
                }
                unpacked = (unpacked + 1);
            }
            else {
                int itemsCount0 = default(int);
                itemsCount0 = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                for (int i = 0; (i < itemsCount0); i = (i + 1)) {
                    string key = default(string);
                    string nullable2 = default(string);
                    nullable2 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.Outer), "MemberName");
                    if (((nullable2 == null) 
                                == false)) {
                        key = nullable2;
                    }
                    else {
                        throw MsgPack.Serialization.SerializationExceptions.NewNullIsProhibited("MemberName");
                    }
                    if ((key == "O")) {
                        string nullable5 = default(string);
                        nullable5 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.Outer), "System.String O");
                        if (((nullable5 == null) 
                                    == false)) {
                            result.O = nullable5;
                        }
                    }
                    else {
                        if ((key == "Inner")) {
                            MsgPack.Serialization.Inner nullable4 = default(MsgPack.Serialization.Inner);
                            if ((unpacker.Read() == false)) {
                                throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                            }
                            if (((unpacker.IsArrayHeader == false) 
                                        && (unpacker.IsMapHeader == false))) {
                                nullable4 = this._serializer1.UnpackFrom(unpacker);
                            }
                            else {
                                MsgPack.Unpacker disposable0 = default(MsgPack.Unpacker);
                                disposable0 = unpacker.ReadSubtree();
                                try {
                                    nullable4 = this._serializer1.UnpackFrom(disposable0);
                                }
                                finally {
                                    if (((disposable0 == null) 
                                                == false)) {
                                        disposable0.Dispose();
                                    }
                                }
                            }
                            if (((nullable4 == null) 
                                        == false)) {
                                result.Inner = nullable4;
                            }
                        }
                        else {
                            if ((key == "A")) {
                                string nullable3 = default(string);
                                nullable3 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.Outer), "System.String A");
                                if (((nullable3 == null) 
                                            == false)) {
                                    result.A = nullable3;
                                }
                            }
                            else {
                                unpacker.Skip();
                            }
                        }
                    }
                }
            }
            return result;
        }
        
        private static T @__Conditional<T>(bool condition, T whenTrue, T whenFalse)
         {
            if (condition) {
                return whenTrue;
            }
            else {
                return whenFalse;
            }
        }
    }
}
