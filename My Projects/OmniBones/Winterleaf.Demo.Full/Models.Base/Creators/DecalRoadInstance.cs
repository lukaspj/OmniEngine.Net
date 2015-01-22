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
   public class DecalRoadInstance : SceneObjectInstance
   {
      public DecalRoadInstance(string _name = "", string _className = "DecalRoad", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public float breakAngle
      {
         set { Fields["breakAngle"] = value.ToString(); }
      }

      public TypeMaterialName material
      {
         set { Fields["material"] = value.ToString(); }
      }

      public String node
      {
         set { Fields["node"] = value.ToString(); }
      }

      public int renderPriority
      {
         set { Fields["renderPriority"] = value.ToString(); }
      }

      public float textureLength
      {
         set { Fields["textureLength"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator DecalRoad(DecalRoadInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         DecalRoad ret = new DecalRoad();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(DecalRoadInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
