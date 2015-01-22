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
   public class ForestBrushToolInstance : ForestToolInstance
   {
      public ForestBrushToolInstance(string _name = "", string _className = "ForestBrushTool", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public float hardness
      {
         set { Fields["hardness"] = value.ToString(); }
      }

      public TypeForestBrushMode mode
      {
         set { Fields["mode"] = value.ToString(); }
      }

      public float pressure
      {
         set { Fields["pressure"] = value.ToString(); }
      }

      public float size
      {
         set { Fields["size"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator ForestBrushTool(ForestBrushToolInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         ForestBrushTool ret = new ForestBrushTool();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(ForestBrushToolInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
