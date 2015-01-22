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
   public class TurretShapeDataInstance : ItemDataInstance
   {
      public TurretShapeDataInstance(string _name = "", string _className = "TurretShapeData", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public float cameraOffset
      {
         set { Fields["cameraOffset"] = value.ToString(); }
      }

      public float headingRate
      {
         set { Fields["headingRate"] = value.ToString(); }
      }

      public float maxHeading
      {
         set { Fields["maxHeading"] = value.ToString(); }
      }

      public float maxPitch
      {
         set { Fields["maxPitch"] = value.ToString(); }
      }

      public float minPitch
      {
         set { Fields["minPitch"] = value.ToString(); }
      }

      public float pitchRate
      {
         set { Fields["pitchRate"] = value.ToString(); }
      }

      public bool startLoaded
      {
         set { Fields["startLoaded"] = value.ToString(); }
      }

      public TypeTurretShapeFireLinkType weaponLinkType
      {
         set { Fields["weaponLinkType"] = value.ToString(); }
      }

      public bool zRotOnly
      {
         set { Fields["zRotOnly"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator TurretShapeData(TurretShapeDataInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         TurretShapeData ret = new TurretShapeData();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(TurretShapeDataInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
