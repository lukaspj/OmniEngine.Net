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
   public class CustomMaterialInstance : MaterialInstance
   {
      public CustomMaterialInstance(string _name = "", string _className = "CustomMaterial", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public Material fallback
      {
         set { Fields["fallback"] = value.ToString(); }
      }

      public bool forwardLit
      {
         set { Fields["forwardLit"] = value.ToString(); }
      }

      public String shader
      {
         set { Fields["shader"] = value.ToString(); }
      }

      public GFXStateBlockData stateBlock
      {
         set { Fields["stateBlock"] = value.ToString(); }
      }

      public String target
      {
         set { Fields["target"] = value.ToString(); }
      }

      public float version
      {
         set { Fields["version"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator CustomMaterial(CustomMaterialInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         CustomMaterial ret = new CustomMaterial();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(CustomMaterialInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
