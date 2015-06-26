/*
 * Copyright (C) Sony Computer Entertainment America LLC. 
 * All Rights Reserved. 
 */

using Sce.Atf.Dom;

namespace Sce.Sled.Lua.Dom
{
    public class SledLuaVarUpvalueListType : SledLuaVarBaseListType<SledLuaVarUpvalueType>
    {
        protected override string Description
        {
            get { return "Lua Upvalue Variables"; }
        }

        protected override string[] TheColumnNames
        {
            get { return SledLuaVarBaseType.ColumnNames; }
        }

        protected override AttributeInfo NameAttributeInfo
        {
            get { return SledLuaSchema.SledLuaVarUpvalueListType.nameAttribute; }
        }

        protected override ChildInfo VariablesChildInfo
        {
            get { return SledLuaSchema.SledLuaVarUpvalueListType.UpvaluesChild; }
        }
    }
}
