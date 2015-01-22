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
   public class LightningInstance : GameBaseInstance
   {
      public LightningInstance(string _name = "", string _className = "Lightning", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public float boltStartRadius
      {
         set { Fields["boltStartRadius"] = value.ToString(); }
      }

      public float chanceToHitTarget
      {
         set { Fields["chanceToHitTarget"] = value.ToString(); }
      }

      public ColorF color
      {
         set { Fields["color"] = value.ToString(); }
      }

      public ColorF fadeColor
      {
         set { Fields["fadeColor"] = value.ToString(); }
      }

      public float strikeRadius
      {
         set { Fields["strikeRadius"] = value.ToString(); }
      }

      public int strikesPerMinute
      {
         set { Fields["strikesPerMinute"] = value.ToString(); }
      }

      public float strikeWidth
      {
         set { Fields["strikeWidth"] = value.ToString(); }
      }

      public bool useFog
      {
         set { Fields["useFog"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator Lightning(LightningInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         Lightning ret = new Lightning();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(LightningInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
