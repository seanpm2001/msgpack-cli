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
    public class System_Collections_ObjectModel_Collection_1_MsgPack_MessagePackObjectArray_Serializer : MsgPack.Serialization.CollectionSerializers.CollectionMessagePackSerializer<System.Collections.ObjectModel.Collection<MsgPack.MessagePackObject[]>, MsgPack.MessagePackObject[]> {
        
        public System_Collections_ObjectModel_Collection_1_MsgPack_MessagePackObjectArray_Serializer(MsgPack.Serialization.SerializationContext context) : 
                base(context, System_Collections_ObjectModel_Collection_1_MsgPack_MessagePackObjectArray_Serializer.RestoreSchema()) {
        }
        
        protected override System.Collections.ObjectModel.Collection<MsgPack.MessagePackObject[]> CreateInstance(int initialCapacity) {
            System.Collections.ObjectModel.Collection<MsgPack.MessagePackObject[]> collection = default(System.Collections.ObjectModel.Collection<MsgPack.MessagePackObject[]>);
            collection = new System.Collections.ObjectModel.Collection<MsgPack.MessagePackObject[]>();
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
