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
   public class ItemDataInstance : ShapeBaseDataInstance
   {
      public ItemDataInstance(string _name = "", string _className = "ItemData", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public float elasticity
      {
         set { Fields["elasticity"] = value.ToString(); }
      }

      public float friction
      {
         set { Fields["friction"] = value.ToString(); }
      }

      public float gravityMod
      {
         set { Fields["gravityMod"] = value.ToString(); }
      }

      public ColorF lightColor
      {
         set { Fields["lightColor"] = value.ToString(); }
      }

      public bool lightOnlyStatic
      {
         set { Fields["lightOnlyStatic"] = value.ToString(); }
      }

      public float lightRadius
      {
         set { Fields["lightRadius"] = value.ToString(); }
      }

      public int lightTime
      {
         set { Fields["lightTime"] = value.ToString(); }
      }

      public TypeItemLightType lightType
      {
         set { Fields["lightType"] = value.ToString(); }
      }

      public float maxVelocity
      {
         set { Fields["maxVelocity"] = value.ToString(); }
      }

      public bool simpleServerCollision
      {
         set { Fields["simpleServerCollision"] = value.ToString(); }
      }

      public bool sticky
      {
         set { Fields["sticky"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator ItemData(ItemDataInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         ItemData ret = new ItemData();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(ItemDataInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
