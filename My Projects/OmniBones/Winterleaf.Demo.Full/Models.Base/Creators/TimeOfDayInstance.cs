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
   public class TimeOfDayInstance : SceneObjectInstance
   {
      public TimeOfDayInstance(string _name = "", string _className = "TimeOfDay", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public float axisTilt
      {
         set { Fields["axisTilt"] = value.ToString(); }
      }

      public float azimuthOverride
      {
         set { Fields["azimuthOverride"] = value.ToString(); }
      }

      public float dayLength
      {
         set { Fields["dayLength"] = value.ToString(); }
      }

      public float dayScale
      {
         set { Fields["dayScale"] = value.ToString(); }
      }

      public float nightScale
      {
         set { Fields["nightScale"] = value.ToString(); }
      }

      public bool play
      {
         set { Fields["play"] = value.ToString(); }
      }

      public float startTime
      {
         set { Fields["startTime"] = value.ToString(); }
      }

      public float time
      {
         set { Fields["time"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator TimeOfDay(TimeOfDayInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         TimeOfDay ret = new TimeOfDay();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(TimeOfDayInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
