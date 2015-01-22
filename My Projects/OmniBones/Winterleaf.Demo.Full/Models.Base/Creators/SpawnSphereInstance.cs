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
   public class SpawnSphereInstance : MissionMarkerInstance
   {
      public SpawnSphereInstance(string _name = "", string _className = "SpawnSphere", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public bool autoSpawn
      {
         set { Fields["autoSpawn"] = value.ToString(); }
      }

      public float indoorWeight
      {
         set { Fields["indoorWeight"] = value.ToString(); }
      }

      public float outdoorWeight
      {
         set { Fields["outdoorWeight"] = value.ToString(); }
      }

      public float radius
      {
         set { Fields["radius"] = value.ToString(); }
      }

      public String spawnClass
      {
         set { Fields["spawnClass"] = value.ToString(); }
      }

      public String spawnDatablock
      {
         set { Fields["spawnDatablock"] = value.ToString(); }
      }

      public String spawnProperties
      {
         set { Fields["spawnProperties"] = value.ToString(); }
      }

      public String spawnScript
      {
         set { Fields["spawnScript"] = value.ToString(); }
      }

      public bool spawnTransform
      {
         set { Fields["spawnTransform"] = value.ToString(); }
      }

      public float sphereWeight
      {
         set { Fields["sphereWeight"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator SpawnSphere(SpawnSphereInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         SpawnSphere ret = new SpawnSphere();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(SpawnSphereInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
