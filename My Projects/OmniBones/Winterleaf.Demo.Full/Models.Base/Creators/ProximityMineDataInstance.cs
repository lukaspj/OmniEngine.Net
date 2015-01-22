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
   public class ProximityMineDataInstance : ItemDataInstance
   {
      public ProximityMineDataInstance(string _name = "", string _className = "ProximityMineData", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public float armingDelay
      {
         set { Fields["armingDelay"] = value.ToString(); }
      }

      public TypeSFXTrackName armingSound
      {
         set { Fields["armingSound"] = value.ToString(); }
      }

      public float autoTriggerDelay
      {
         set { Fields["autoTriggerDelay"] = value.ToString(); }
      }

      public float explosionOffset
      {
         set { Fields["explosionOffset"] = value.ToString(); }
      }

      public float triggerDelay
      {
         set { Fields["triggerDelay"] = value.ToString(); }
      }

      public bool triggerOnOwner
      {
         set { Fields["triggerOnOwner"] = value.ToString(); }
      }

      public float triggerRadius
      {
         set { Fields["triggerRadius"] = value.ToString(); }
      }

      public TypeSFXTrackName triggerSound
      {
         set { Fields["triggerSound"] = value.ToString(); }
      }

      public float triggerSpeed
      {
         set { Fields["triggerSpeed"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator ProximityMineData(ProximityMineDataInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         ProximityMineData ret = new ProximityMineData();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(ProximityMineDataInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
