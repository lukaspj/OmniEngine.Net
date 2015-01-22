using System;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;
using WinterLeaf.Engine.Enums;

namespace WinterLeaf.Demo.Full.Models.Base.Creators
{
   /// <summary>
   /// 
   /// </summary>
   public class GuiInspectorTypeBitMask32Instance : GuiInspectorFieldInstance
   {
      public GuiInspectorTypeBitMask32Instance(string _name = "", string _className = "GuiInspectorTypeBitMask32", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiInspectorTypeBitMask32(GuiInspectorTypeBitMask32Instance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiInspectorTypeBitMask32 ret = new GuiInspectorTypeBitMask32();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiInspectorTypeBitMask32Instance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
