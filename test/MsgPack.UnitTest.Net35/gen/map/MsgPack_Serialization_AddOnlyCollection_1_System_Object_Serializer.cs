﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:2.0.50727.8009
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers.MapBased {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.6.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_AddOnlyCollection_1_System_Object_Serializer : MsgPack.Serialization.CollectionSerializers.EnumerableMessagePackSerializer<MsgPack.Serialization.AddOnlyCollection<object>, object> {
        
        public MsgPack_Serialization_AddOnlyCollection_1_System_Object_Serializer(MsgPack.Serialization.SerializationContext context) : 
                base(context, MsgPack_Serialization_AddOnlyCollection_1_System_Object_Serializer.RestoreSchema()) {
        }
        
        protected override void AddItem(MsgPack.Serialization.AddOnlyCollection<object> collection, object item) {
            collection.Add(item);
        }
        
        protected internal override MsgPack.Serialization.AddOnlyCollection<object> UnpackFromCore(MsgPack.Unpacker unpacker) {
            if ((unpacker.IsArrayHeader == false)) {
                throw MsgPack.Serialization.SerializationExceptions.NewIsNotArrayHeader();
            }
            int itemsCount = default(int);
            itemsCount = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
            MsgPack.Serialization.AddOnlyCollection<object> collection = default(MsgPack.Serialization.AddOnlyCollection<object>);
            collection = new MsgPack.Serialization.AddOnlyCollection<object>();
            this.UnpackToCore(unpacker, collection);
            return collection;
        }
        
        protected override MsgPack.Serialization.AddOnlyCollection<object> CreateInstance(int initialCapacity) {
            MsgPack.Serialization.AddOnlyCollection<object> collection = default(MsgPack.Serialization.AddOnlyCollection<object>);
            collection = new MsgPack.Serialization.AddOnlyCollection<object>();
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
