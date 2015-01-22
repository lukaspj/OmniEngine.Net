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
   public class RenderFormatTokenInstance : RenderPassStateTokenInstance
   {
      public RenderFormatTokenInstance(string _name = "", string _className = "RenderFormatToken", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public PostEffect copyEffect
      {
         set { Fields["copyEffect"] = value.ToString(); }
      }

      public TypeGFXFormat depthFormat
      {
         set { Fields["depthFormat"] = value.ToString(); }
      }

      public TypeGFXFormat format
      {
         set { Fields["format"] = value.ToString(); }
      }

      public PostEffect resolveEffect
      {
         set { Fields["resolveEffect"] = value.ToString(); }
      }

      public int aaLevel
      {
         set { Fields["aaLevel"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator RenderFormatToken(RenderFormatTokenInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         RenderFormatToken ret = new RenderFormatToken();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(RenderFormatTokenInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
