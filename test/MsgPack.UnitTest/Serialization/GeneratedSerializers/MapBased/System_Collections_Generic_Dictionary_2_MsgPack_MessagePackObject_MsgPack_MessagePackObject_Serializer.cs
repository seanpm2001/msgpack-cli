﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.34209
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers.MapBased {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.6.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class System_Collections_Generic_Dictionary_2_MsgPack_MessagePackObject_MsgPack_MessagePackObject_Serializer : MsgPack.Serialization.CollectionSerializers.DictionaryMessagePackSerializer<System.Collections.Generic.Dictionary<MsgPack.MessagePackObject, MsgPack.MessagePackObject>, MsgPack.MessagePackObject, MsgPack.MessagePackObject> {
        
        public System_Collections_Generic_Dictionary_2_MsgPack_MessagePackObject_MsgPack_MessagePackObject_Serializer(MsgPack.Serialization.SerializationContext context) : 
                base(context, System_Collections_Generic_Dictionary_2_MsgPack_MessagePackObject_MsgPack_MessagePackObject_Serializer.RestoreSchema()) {
        }
        
        protected override System.Collections.Generic.Dictionary<MsgPack.MessagePackObject, MsgPack.MessagePackObject> CreateInstance(int initialCapacity) {
            System.Collections.Generic.Dictionary<MsgPack.MessagePackObject, MsgPack.MessagePackObject> collection = default(System.Collections.Generic.Dictionary<MsgPack.MessagePackObject, MsgPack.MessagePackObject>);
            collection = new System.Collections.Generic.Dictionary<MsgPack.MessagePackObject, MsgPack.MessagePackObject>(initialCapacity);
            return collection;
        }
        
        private static MsgPack.Serialization.PolymorphismSchema RestoreSchema() {
            MsgPack.Serialization.PolymorphismSchema schema = default(MsgPack.Serialization.PolymorphismSchema);
            schema = null;
            return schema;
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
