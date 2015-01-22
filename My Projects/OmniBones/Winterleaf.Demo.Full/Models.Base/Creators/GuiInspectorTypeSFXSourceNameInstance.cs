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
   public class GuiInspectorTypeSFXSourceNameInstance : GuiInspectorTypeMenuBaseInstance
   {
      public GuiInspectorTypeSFXSourceNameInstance(string _name = "", string _className = "GuiInspectorTypeSFXSourceName", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiInspectorTypeSFXSourceName(GuiInspectorTypeSFXSourceNameInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiInspectorTypeSFXSourceName ret = new GuiInspectorTypeSFXSourceName();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiInspectorTypeSFXSourceNameInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
